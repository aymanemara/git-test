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
    public partial class Frm_SupplierReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_SupplierReport()
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
            if (dg1.Rows.Count > 0)
            {
                for (int i = 0; i < dg1.Rows.Count; i++)
                {
                    total += Convert.ToDecimal(dg1.Rows[i].Cells[1].Value);
                }
                txttotal.Text = Math.Round(total,2).ToString();


            }



        }

        private void Frm_SupplierReport_Load(object sender, EventArgs e)
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
            CbxSupplier.Enabled = false;
            RadioSupplier.SelectedIndex = 0;
            dt.Clear();
            dt = db.Read_Data("select Order_ID,Paid,Suppliers.Sup_Name,Date from Supplier_Report,Suppliers where Supplier_Report.Sup_ID=Suppliers.Sup_ID");
            if (dt.Rows.Count > 0)
            {
                dg1.DataSource = dt;
                Sum();
                btndel.Enabled = true;
            }
            else { btndel.Enabled = false; }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (RadioSupplier.SelectedIndex == 0)
            {
                
                dt = db.Read_Data("select Order_ID,Paid,Suppliers.Sup_Name,Date from Supplier_Report,Suppliers where Supplier_Report.Sup_ID=Suppliers.Sup_ID");
               
            }
            else if(RadioSupplier.SelectedIndex == 1 && CbxSupplier.Text!="")
            {
                
                dt = db.Read_Data("select Order_ID,Paid,Suppliers.Sup_Name,Date from Supplier_Report,Suppliers where" +
                    " Supplier_Report.Sup_ID=Suppliers.Sup_ID and Sup_Name='" + CbxSupplier.Text + "'");
                
            }
            
                if (dt.Rows.Count > 0)
                {
                    
                    dg1.DataSource = dt;
                    Sum();
                btndel.Enabled = true;
                }
            else { btndel.Enabled = false; }
            
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            
            if (RadioSupplier.SelectedIndex == 1 && CbxSupplier.Text != "")
            {
                if (MessageBox.Show("هل انتا متاكد من حذف البيانات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DataTable dt1 = new DataTable();
                    dt1 = db.Read_Data("select Sup_ID from Suppliers where Sup_Name='" + CbxSupplier.Text + "'");
                    int supid = Convert.ToInt32(dt1.Rows[0][0]);
                    db.Write_Data("delete from Supplier_Report where Sup_ID="+supid+" ", "del");
                    Frm_SupplierReport_Load(null, null);

                }
                
            }
            else
            {
                errorpov1.SetError(CbxSupplier, "الرجاء احتيار اسم المورد");
            }
        }

        private void CbxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorpov1.SetError(CbxSupplier, "");
        }

        private void RadioSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioSupplier.SelectedIndex == 1) { CbxSupplier.Enabled = true; }
            else if (RadioSupplier.SelectedIndex == 0) { CbxSupplier.Enabled = false; }
        }
    }
}