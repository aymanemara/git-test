using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace POS1
{
    public partial class Frm_SupplierMoney : DevExpress.XtraEditors.XtraForm
    {
        public Frm_SupplierMoney()
        {
            InitializeComponent();
        }
        DB_OPs db = new DB_OPs();
        DataTable dt = new DataTable();

        private void Fill_CbxSupplier()
        {

            CbxSupplier.Properties.Items.Clear();
            DataTable dt1 = new DataTable();
            dt1 = db.Read_Data("select Sup_Name from Suppliers");
            if (dt1.Rows.Count > 0)
            {
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    CbxSupplier.Properties.Items.Add(dt1.Rows[i][0]);
                }
            }
        }
        private void Sum()
        {
            decimal total = 0;
            if(dg1.Rows.Count > 0)
            {
                for(int i = 0; i < dg1.Rows.Count; i++)
                {
                    total += Convert.ToDecimal(dg1.Rows[i].Cells[2].Value);
                }
                txttotal.Text = Math.Round(total,2).ToString();
                

            }
               

            
        }
        private void Frm_SupplierMoney_Load(object sender, EventArgs e)
        {
            dg1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dg1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dg1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dg1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dg1.BackgroundColor = Color.White;

            dg1.EnableHeadersVisualStyles = false;
            dg1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dg1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dg1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Fill_CbxSupplier();
            dt.Clear();
            dt = db.Read_Data("select Order_ID,Suppliers.Sup_Name,Mount,Date,Dreminder from Supplier_Money,Suppliers where Supplier_Money.Sup_ID=Suppliers.Sup_ID");
            if (dt.Rows.Count > 0)
            {
                dg1.DataSource = dt;
                Sum();
            }
            
            
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                int sup_id=0;

                Frm_Printing frm = new Frm_Printing();
                frm.crystalReportViewer1.RefreshReport();
                RptSupplierMoney rpt = new RptSupplierMoney();
                
                rpt.SetDatabaseLogon("", "", "USER-PC", "POS");
                
                rpt.SetDataSource(dt);
                //rpt.ParameterFields["ID"].CurrentValues.IsNoValue = true;
                if (RadioSupplier.SelectedIndex == 1 && CbxSupplier.Text != "")
                {
                    DataTable Supdt = new DataTable();
                    Supdt = db.Read_Data("select Sup_ID from Suppliers where Sup_Name='" + CbxSupplier.Text + "'");
                    sup_id = Convert.ToInt32(Supdt.Rows[0][0]);
                    rpt.SetParameterValue("ID", sup_id);
                    // Create parameter objects
                    //ParameterFields myParams = new ParameterFields();
                    //ParameterField myParam = new ParameterField();
                    //ParameterDiscreteValue myDiscreteValue = new ParameterDiscreteValue();
                    // Set the ParameterFieldName to the name of the parameter
                    // created in the Field Explorer
                    //myParam.ParameterFieldName = "ID";
                    // Add first country
                    //myDiscreteValue.Value = sup_id;
                    //myParam.CurrentValues.Add(myDiscreteValue);
                    // Add param object to params collection
                    //myParams.Add(myParam);
                    // Assign the params collection to the report viewer
                    //frm.crystalReportViewer1.ParameterFieldInfo = myParams;
                    // Assign the Report to the report viewer.
                    // This method uses a strongly typed report,
                    // but other methods are possible as well.
                    rpt.RecordSelectionFormula = "{ Suppliers.Sup_ID}=" + sup_id + "";




                }

                frm.crystalReportViewer1.ReportSource = rpt;

                frm.ShowDialog();
            }
            
            


        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (RadioSupplier.SelectedIndex == 0)
            {
                
                dt = db.Read_Data("select Order_ID,Suppliers.Sup_Name,Mount,Date,Dreminder from Supplier_Money,Suppliers " +
                    "where Supplier_Money.Sup_ID=Suppliers.Sup_ID");

            }
            else if (RadioSupplier.SelectedIndex == 1)
            {
               
                dt = db.Read_Data("select Order_ID,Suppliers.Sup_Name,Mount,Date,Dreminder from Supplier_Money,Suppliers " +
                    "where Supplier_Money.Sup_ID=Suppliers.Sup_ID and Sup_Name='" + CbxSupplier.Text + "'");
            }
            if (dt.Rows.Count > 0)
            {
                
                dg1.DataSource = dt;
                Sum();
            }
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            if (dg1.Rows.Count > 0)
            {
                if (MessageBox.Show("هل انتا متاكد من تسديد المبلغ", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string sup_name = dg1.CurrentRow.Cells[1].Value.ToString();
                    DataTable Supdt = new DataTable();
                    Supdt = db.Read_Data("select Sup_ID from Suppliers where Sup_Name='" + sup_name + "'");
                    int sup_id = Convert.ToInt32(Supdt.Rows[0][0]);
                    string d = DateTime.Now.ToString("yyyy/MM/dd");

                    if (RadioPay.SelectedIndex == 0)
                    {

                        db.Write_Data("delete from Supplier_Money where Order_ID=" + dg1.CurrentRow.Cells[0].Value + "", "");
                        db.Write_Data("insert into Supplier_Report values(" + dg1.CurrentRow.Cells[0].Value + "," +
                            "" + dg1.CurrentRow.Cells[2].Value + "," + sup_id + ",'" + d + "')", "");
                        db.Write_Data("update Buy set Paid=" + dg1.CurrentRow.Cells[2].Value + ",Debit=" + 0 + " where Order_ID=" + dg1.CurrentRow.Cells[0].Value + "", "");


                    }
                    else if (RadioPay.SelectedIndex == 1 && CbxSupplier.Text!="")
                    {
                        decimal updmount = Convert.ToDecimal(dg1.CurrentRow.Cells[2].Value) - NudMount.Value;
                        db.Write_Data("update Supplier_Money set Mount=" + updmount + " where Order_ID=" + dg1.CurrentRow.Cells[0].Value + "", "");
                        db.Write_Data("insert Supplier_Report values(" + dg1.CurrentRow.Cells[0].Value + "," +
                            "" + NudMount.Value + "," + sup_id + ",'" + d + "')", "");
                        db.Write_Data("update Buy set Paid=Paid+" + NudMount.Value + ",Debit=" + updmount + " where Order_ID=" + dg1.CurrentRow.Cells[0].Value + "", "");
                    }
                    MessageBox.Show("تمت العملية بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    Frm_SupplierMoney_Load(null, null);
                }
                
            }
        }

        
    }
}