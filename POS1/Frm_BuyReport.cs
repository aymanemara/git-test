using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace POS1
{
    public partial class Frm_BuyReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_BuyReport()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        DB_OPs db = new DB_OPs();
        int id;
        private void Fill_Cbxsuppllier()
        {
            DataTable Sup_dt = new DataTable();
            Sup_dt = db.Read_Data("select Sup_Name from Suppliers");
            if (Sup_dt.Rows.Count > 0)
            {
               for(int i = 0; i < Sup_dt.Rows.Count; i++)
                {
                    CbxSupplier.Properties.Items.Add(Sup_dt.Rows[i][0]);
                }
            }
        }
        private void Sum()
        {
            decimal Sum = 0;
            for(int i = 0; i < dg1.Rows.Count; i++)
            {
                Sum += Convert.ToDecimal(dg1.Rows[i].Cells[3].Value);
            }
            txttotal.Text = Math.Round(Sum, 2).ToString();
        }
        //private void print()
        //{
        //    DataTable dt1=new DataTable();
        //    dt1 = db.Read_Data("SELECT [Order_ID],Suppliers.Sup_Name,Products.Pro_Name,[Date],Buy_Details.Qty,[Price],Buy_Details.Discount,[Total]  FROM [dbo].[Buy_Details],Products,Suppliers where Buy_Details.Pro_ID=Products.Pro_ID and Buy_Details.Sup_ID=Suppliers.Sup_ID and Order_ID=" + dg1.CurrentRow.Cells[1].Value + "");
        //    DataTable dt2 = new DataTable();
        //    dt2 = db.Read_Data("SELECT [Order_ID],[Date],[Sup_ID],[Total_Mount],[Paid],[Debit],[UserName] FROM [dbo].[Buy] where Order_ID=" + dg1.CurrentRow.Cells[1].Value + "");
        //    DataSet ds = new DataSet();
        //    ds.Tables.Add(dt1);
        //    ds.Tables.Add(dt2);
        //    Frm_Printing frm = new Frm_Printing();
        //    frm.crystalReportViewer1.RefreshReport();
        //    RptOrderBuy rpt = new RptOrderBuy();
        //    rpt.SetDatabaseLogon("", "", "User-PC", "POS");
        //    rpt.SetDataSource(ds);
        //    rpt.SetParameterValue("ID", dg1.CurrentRow.Cells[1].Value);
        //    frm.crystalReportViewer1.ReportSource = rpt;

        //    frm.ShowDialog();
        //}
        private void Frm_BuyReport_Load(object sender, EventArgs e)
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
            Fill_Cbxsuppllier();
            dtfrom.Text = DateTime.Now.ToString("yyyy/MM/dd");
            dtto.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (RadioSupplier.SelectedIndex == 0)
            {
                if (chkorderID.Checked == false && chkdt.Checked == false)
                {
                    dt=db.Read_Data("SELECT [Order_ID],Suppliers.Sup_Name,[Total_Mount],[Paid],[Debit],[Date] FROM [dbo].[Buy],Suppliers where buy.Sup_ID=Suppliers.Sup_ID");

                }
                else if (chkorderID.Checked == true)
                {
                    dt = db.Read_Data("SELECT [Order_ID],Suppliers.Sup_Name,[Total_Mount],[Paid],[Debit],[Date] FROM [dbo].[Buy],Suppliers where buy.Sup_ID=Suppliers.Sup_ID and Order_ID=" + txtorderID.Text+"");

                }
                else if (chkorderID.Checked == false && chkdt.Checked == true)
                {
                    dt = db.Read_Data("SELECT [Order_ID],Suppliers.Sup_Name,[Total_Mount],[Paid],[Debit],[Date] FROM [dbo].[Buy],Suppliers where buy.Sup_ID=Suppliers.Sup_ID and convert(date,date,111) between '" + dtfrom.Text + "' and '" + dtto.Text + "'");
                }
                
            }
            if (RadioSupplier.SelectedIndex == 1)
            {
                if (CbxSupplier.Text != "")
                {

                    DataTable dtsup = new DataTable();
                    dtsup = db.Read_Data("select Sup_ID from Suppliers where Sup_Name=N'" + CbxSupplier.Text + "'");
                    id = Convert.ToInt32(dtsup.Rows[0][0]);
                    if (chkdt.Checked == false)
                    {
                        dt = db.Read_Data("SELECT [Order_ID],Suppliers.Sup_Name,[Total_Mount],[Paid],[Debit],[Date] FROM [dbo].[Buy],Suppliers where buy.Sup_ID=Suppliers.Sup_ID and Buy.Sup_ID=" + id+"");

                    }
                    
                    else if (chkdt.Checked == true)
                    {
                        dt = db.Read_Data("SELECT [Order_ID],Suppliers.Sup_Name,[Total_Mount],[Paid],[Debit],[Date] FROM [dbo].[Buy],Suppliers where buy.Sup_ID=Suppliers.Sup_ID and convert(date,date,111) between '" + dtfrom.Text + "' and '" + dtto.Text + "' and Buy.Sup_ID=" + id + "");
                    }


                }
            }
            if (dt.Rows.Count > 0)
            {
                dg1.DataSource = dt;

                Sum();
            }
            
            
        }

        private void dg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dg1.Rows.Count > 0)
            {
                if (e.ColumnIndex == 0)
                {
                    dt = db.Read_Data("SELECT [Order_ID],Suppliers.Sup_Name,[Paid],[Debit],[UserName] FROM[dbo].[Buy],Suppliers where Buy.Sup_ID=Suppliers.Sup_ID and Order_ID=" + dg1.CurrentRow.Cells[1].Value + "");
                    DataTable dt1 = new DataTable();
                    dt1 = db.Read_Data("SELECT Buy_Details.Order_ID, Products.Pro_Name,Buy_Details.Qty,[Price],[Buy_Details].[Discount],[Total] FROM[dbo].[Buy_Details], Products where Buy_Details.Pro_ID = Products.Pro_ID and Buy_Details.Order_ID =" + dg1.CurrentRow.Cells[1].Value + "");
                    RptOrderBuy rpt = new RptOrderBuy();
                    DataSet ds = new DataSet();
                    ds.Tables.Add(dt);
                    ds.Tables.Add(dt1);
                    rpt.SetDatabaseLogon("", "", "DESKTOP-SVMF3OA", "POS");
                    rpt.SetDataSource(ds);
                    rpt.SetParameterValue("ID", dg1.CurrentRow.Cells[1].Value);
                    rpt.RecordSelectionFormula = "{Buy.Order_ID}="+ dg1.CurrentRow.Cells[1].Value + "";
                    Frm_Printing frm = new Frm_Printing();
                    frm.crystalReportViewer1.RefreshReport();
                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.ShowDialog();

                }
            }
           
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (dg1.Rows.Count > 0)
            {
                if (MessageBox.Show("هل أنت متأكد من الحذف", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    db.Write_Data("delete from Buy where Order_ID=" + dg1.CurrentRow.Cells[1].Value + "", "Del");
                    dg1.Rows.RemoveAt(dg1.CurrentRow.Index);
                }
                
            }
        }

        private void btnprintall_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                RptbuyorderDate rpt = new RptbuyorderDate();

               
                Frm_Printing frm = new Frm_Printing();
                frm.crystalReportViewer1.RefreshReport();
                rpt.SetDatabaseLogon("", "", "DESKTOP-SVMF3OA", "POS");
                rpt.SetDataSource(dt);
                if (RadioSupplier.SelectedIndex == 0)
                {
                    if (chkorderID.Checked == true && txtorderID.Text != "")
                    {
                        rpt.SetParameterValue("ID", Convert.ToInt32(txtorderID.Text));
                        rpt.RecordSelectionFormula = "{Buy.Order_ID}=" + Convert.ToInt32(txtorderID.Text) + "";
                    }
                    else if (chkdt.Checked == true)
                    {
                        
                        rpt.SetParameterValue("From", dtfrom.Text);
                        rpt.SetParameterValue("To", dtto.Text);
                        rpt.RecordSelectionFormula = "{Buy.Date} in '" + dtfrom.Text + "' to '" + dtto.Text + "'";
                        
                    }

                }
                if (RadioSupplier.SelectedIndex == 1)
                {
                    if (chkdt.Checked == false)
                    {
                        rpt.SetParameterValue("No", id);
                        rpt.RecordSelectionFormula = "{Buy.Sup_ID}=" + id + "";
                    }
                    else if (chkdt.Checked == true)
                    {
                        rpt.SetParameterValue("No", id);
                        rpt.SetParameterValue("From", dtfrom.Text);
                        rpt.SetParameterValue("To", dtto.Text);
                        rpt.RecordSelectionFormula = "{Buy.Sup_ID}=" + id + "";
                        rpt.RecordSelectionFormula = "Datevalue({Buy.Date}) in '" + dtfrom.Text + "' to '" + dtto.Text + "'";
                    }
                }
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.ShowDialog();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

        }
    }
}