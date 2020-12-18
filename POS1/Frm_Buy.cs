using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace POS1
{
    public partial class Frm_Buy : DevExpress.XtraEditors.XtraForm
    {
        //private static Frm_Buy frm;
        //static void frm_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    frm = null;
        //}
        //public static Frm_Buy bringdata
        //{

        //    get
        //    {
        //        if (frm == null)
        //        {
        //            frm = new Frm_Buy();
        //            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
        //        }
        //        return frm;
        //    }
        //}
        public Frm_Buy()
        {
            InitializeComponent();
            
            //if (frm == null)
            //    frm = this;

        }
        DB_OPs db = new DB_OPs();
        DataTable dt = new DataTable();

        public void ClearAll()
        {
            int no;
            no = db.Auto_Num("Order_ID", "Buy");
            txtid.Text =no.ToString();
            txtBarcode.Text = "";
            txttotal.Text = "0";
            DtpOrder.Text = DateTime.Now.ToString("yyyy/MM/dd");
            DtpDeservedDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            nudQty.Value = 0;
            NudBuyprice.Value = 0;
            RadioPay.SelectedIndex = 0;
            CbxProduct.SelectedIndex = -1;
            CbxSupplier.SelectedIndex = -1;
            dg1.Rows.Clear();
            Fill_CbxProduct();
            
            Fill_CbxSupplier();


        }
        public void Fill_CbxProduct()
        {
            dt.Clear();
            CbxProduct.Properties.Items.Clear();
            dt = db.Read_Data("select Pro_Name from Products");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CbxProduct.Properties.Items.Add(dt.Rows[i][0]);
                }
            }
            
        }
        public void Fill_CbxSupplier()
        {
            dt.Clear();
            CbxSupplier.Properties.Items.Clear();
            dt = db.Read_Data("select Sup_Name from Suppliers");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CbxSupplier.Properties.Items.Add(dt.Rows[i][0]);
                }

            }
            
        }
        private void Total()
        {
            decimal total = 0;
            for (int i = 0; i < dg1.Rows.Count; i++)
            {

                total += Convert.ToDecimal(dg1.Rows[i].Cells[6].Value);
                txttotal.Text = Math.Round(total, 2).ToString();
            }
        }

        private void PayOrder()
        {
            dt.Clear();
            dt = db.Read_Data("select Sup_ID from Suppliers where Sup_Name=N'" + CbxSupplier.Text + "'");

            if (dt.Rows.Count > 0)
            {
                int x = Convert.ToInt32(dt.Rows[0][0]);
                db.Write_Data("insert into Buy values(" + txtid.Text + ",N'" + DtpOrder.Text + "'," + x + ",'" + txttotal.Text + "'," +
                    "" + NudPaid.Value + ",'" + txtdebit.Text + "','123')", "");
                for (int i = 0; i < dg1.Rows.Count; i++)
                {
                    db.Write_Data("insert into Buy_Details values(" + txtid.Text + "," + dg1.Rows[i].Cells[1].Value + "," +
                        "" + dg1.Rows[i].Cells[3].Value + "," + dg1.Rows[i].Cells[4].Value + "," +
                        "" + dg1.Rows[i].Cells[5].Value + "," + dg1.Rows[i].Cells[6].Value + ")", "");
                    db.Write_Data("update Products set Qty=Qty+" + dg1.Rows[i].Cells[3].Value + " where Pro_ID=" + dg1.Rows[i].Cells[1].Value + "", "");

                }
                if (RadioPay.SelectedIndex == 0)
                {
                    db.Write_Data("insert into Supplier_Report values(" + txtid.Text + "," + NudPaid.Value + "," + x + ",'" + DtpOrder.Text + "')", "New");

                }
                else if (RadioPay.SelectedIndex == 1)
                {
                    db.Write_Data("insert into Supplier_Money values(" + txtid.Text + "," + x + ",'" + txtdebit.Text + "','" + DtpOrder.Text + "','" + DtpDeservedDate.Text + "')", "New");
                    if (NudPaid.Value > 0)
                    {
                        db.Write_Data("insert into Supplier_Report values(" + txtid.Text + "," +NudPaid.Value + "," + x + ",'" + DtpOrder.Text + "')", "");

                    }
                }
                groupControl5.Visible = false;
                Print();
                ClearAll();

            }
        }
        private void Add_Item()
        {
            if (CbxProduct.Properties.Items.Count <= 0)
            {
                MessageBox.Show("الرجاء ادخال أصناف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            if (CbxProduct.Text == "")
            {
                MessageBox.Show("الرجاء اختار صنف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            if (nudQty.Value == 0)
            {
                MessageBox.Show("الرجاء ادخال الكمية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            if (NudBuyprice.Value == 0)
            {
                MessageBox.Show("الرجاء ادخال السعر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            dt.Clear();
            dt = db.Read_Data("select * from Products where Pro_Name=N'" + CbxProduct.Text + "'");

            dg1.Rows.Add(id, dt.Rows[0][0], dt.Rows[0][1], nudQty.Value, NudBuyprice.Value, dt.Rows[0][7]
                , nudQty.Value * NudBuyprice.Value);

            id++;
            CbxProduct.Text = "";
            Total();
            dg1.ClearSelection();
            dg1.FirstDisplayedScrollingRowIndex = dg1.Rows.Count - 1;
            dg1.Rows[dg1.Rows.Count - 1].Selected = true;
        }
        private void Del_Item()
        {
            if (dg1.Rows.Count > 0)
            {


                int row_index = dg1.SelectedRows[0].Index;
                dg1.Rows.RemoveAt(row_index);
                if (row_index > 0)
                {
                    dg1.ClearSelection();
                    dg1.FirstDisplayedScrollingRowIndex = row_index - 1;
                    dg1.Rows[row_index - 1].Selected = true;
                }
                if (dg1.Rows.Count <= 0)
                {
                    txttotal.Text = "0";
                }
                decimal total = 0;
                for (int i = 0; i < dg1.Rows.Count; i++)
                {

                    total += Convert.ToDecimal(dg1.Rows[i].Cells[6].Value);
                    txttotal.Text = Math.Round(total, 2).ToString();
                }
                id = 1;
                for (int i = 0; i < dg1.Rows.Count; i++)
                {


                    dg1.Rows[i].Cells[0].Value = id;
                    id++;
                }



            }
        }
        private void Frm_Buy_Load(object sender, EventArgs e)
        {


            ClearAll();
            //txttotal.Text = RadioPay.Properties.Items[RadioPay.SelectedIndex].Description;
            //dg1.BorderStyle = BorderStyle.None;
            dg1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dg1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dg1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dg1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dg1.BackgroundColor = Color.White;

            dg1.EnableHeadersVisualStyles = false;
            dg1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dg1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dg1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        


        private void btnAdditem_Click(object sender, EventArgs e)
        {
            Frm_Product frm = new Frm_Product(this);
            frm.ShowDialog();
        }

        

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Frm_Supplier frm = new Frm_Supplier(this);
            
            frm.ShowDialog();
        }

        private void btndelproduct_Click(object sender, EventArgs e)
        {
            Del_Item();
            
            
        }
        int id = 1;
        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            Add_Item();
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dt.Clear();
                dt = db.Read_Data("select * from Products where Barcode=N'" + txtBarcode.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    dg1.Rows.Add(id, dt.Rows[0][0], dt.Rows[0][1], nudQty.Value, NudBuyprice.Value, dt.Rows[0][7]
                    , nudQty.Value * NudBuyprice.Value);

                    id++;
                    CbxProduct.Text = "";
                    Total();
                }

            }
        }

       

        
        
        private void Frm_Buy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PayOrder();
            }
            else if (e.KeyCode == Keys.F1)
            {
                if (CbxSupplier.SelectedIndex < 0)
                {
                    MessageBox.Show("الرجاء ادخال اسم المورد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }
                if (dg1.Rows.Count <= 0)
                {
                    MessageBox.Show("الرجاء اضافة أصناف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }
                groupControl5.Visible = true;
                txt_total.Text = txttotal.Text;
                NudPaid.Value = 0;
                NudPaid.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                groupControl5.Visible = false;
            }
            else if (e.KeyCode == Keys.F2)
            {
                Add_Item();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                Del_Item();
            }
        }
        int indx;
       

        private void dg1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indx = dg1.SelectedRows[0].Index;
                int qty = Convert.ToInt32(dg1.Rows[indx].Cells[3].Value);
                decimal price = Convert.ToDecimal(dg1.Rows[indx].Cells[4].Value);
                decimal discount = Convert.ToDecimal(dg1.Rows[indx].Cells[5].Value);
                dg1.Rows[indx].Cells[6].Value = (qty*price)-discount;
                Total();
            }
            catch { }
            
        }

        

        private void btnOK_Click(object sender, EventArgs e)
        {
            PayOrder();
            
        
        }
        private void Print()
        {
            int id = Convert.ToInt32(txtid.Text);
            DataTable rptdt1 = new DataTable();
            DataTable rptdt2 = new DataTable();
            rptdt1.Clear();
            rptdt1 = db.Read_Data("SELECT Buy_Details.Order_ID, Products.Pro_Name,Buy_Details.Qty,[Price],[Buy_Details].[Discount],[Total] FROM[dbo].[Buy_Details], Products where Buy_Details.Pro_ID = Products.Pro_ID and Buy_Details.Order_ID = " + id+"");
            rptdt2 = db.Read_Data("SELECT [Order_ID],Suppliers.Sup_Name,[Paid],[Debit],[UserName] FROM[dbo].[Buy],Suppliers where Buy.Sup_ID=Suppliers.Sup_ID and Order_ID=" + id+"");
            Frm_Printing frm = new Frm_Printing();
            frm.crystalReportViewer1.RefreshReport();
            RptOrderBuy rpt = new RptOrderBuy();
            rpt.SetDatabaseLogon("", "", "USER-PC", "POS");
            DataSet ds = new DataSet();
            ds.Tables.Add(rptdt1);
            ds.Tables.Add(rptdt2);
            rpt.SetDataSource(ds);
            rpt.SetParameterValue("ID", id);
            rpt.RecordSelectionFormula = "{Buy_Details.Order_ID}=" + id + "";
            frm.crystalReportViewer1.ReportSource = rpt;
            //System.Drawing.Printing.PrintDocument printdoc = new System.Drawing.Printing.PrintDocument();
            //rpt.PrintOptions.PrinterName = printdoc.PrinterSettings.PrinterName;
            //rpt.PrintToPrinter(1, true, 0, 0);
            frm.ShowDialog();
            

        }
        private void btnback_Click(object sender, EventArgs e)
        {
            groupControl5.Visible = false;
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            if (CbxSupplier.SelectedIndex < 0)
            {
                MessageBox.Show("الرجاء ادخال اسم المورد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            if (dg1.Rows.Count <= 0)
            {
                MessageBox.Show("الرجاء اضافة أصناف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            groupControl5.Visible = true;
            txt_total.Text = txttotal.Text;
            if (RadioPay.SelectedIndex == 0)
            {
                NudPaid.Value = Convert.ToDecimal(txttotal.Text);
            }else if (RadioPay.SelectedIndex == 1)
            {
                NudPaid.Value = 0;
                txtdebit.Text = txttotal.Text;
            }
            
            NudPaid.Focus();
        }

        private void NudPaid_EditValueChanged(object sender, EventArgs e)
        {
            txtdebit.Text = (Convert.ToDecimal(txt_total.Text)-NudPaid.Value).ToString();
        }

        private void labelControl19_Click(object sender, EventArgs e)
        {

        }
    }
}