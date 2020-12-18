using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace POS1
{
    public partial class Frm_DeservedReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_DeservedReport()
        {
            InitializeComponent();
        }
        DB_OPs db = new DB_OPs();
        DataTable dt = new DataTable();
        decimal total;
        private void Sum()
        {
            if (dt.Rows.Count == 0)
            {

                dg1.Rows[0].Cells[3].Value = "لا توجد بيانات";
                txttotal.Text = "0";
            }
            else
            {
                dg1.DataSource = dt;
                total = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    total += Convert.ToDecimal(dt.Rows[i][2]);
                }
                txttotal.Text = Math.Round(total, 2).ToString();
                
            }
            
           
        }
        private void Frm_DeservedReport_Load(object sender, EventArgs e)
        {
            dtfrom.Text = DateTime.Now.ToString("yyyy/MM/dd");
            dtto.Text = DateTime.Now.ToString("yyyy/MM/dd");

            dt.Clear();
            dt = db.Read_Data("select Deserved.Des_ID,Deserved_Type.Name,Price,Date,Notes from Deserved,Deserved_Type where Deserved.Type_ID=Deserved_Type.Des_ID");
            Sum();






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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.Read_Data("select Deserved.Des_ID,Deserved_Type.Name,Price,Date,Notes from Deserved,Deserved_Type where Deserved.Type_ID=Deserved_Type.Des_ID and convert(date,date,111) between '" + dtfrom.Text + "' and '" + dtto.Text + "'");

            Sum();


        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                if (MessageBox.Show("هل أنت متأكد من الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    for (int i=0;i<dt.Rows.Count;i++)
                    {
                        db.Write_Data("delete from Deserved where Des_ID="+Convert.ToInt32(dt.Rows[i][0])+"","");
                        
                    }
                    dt.Clear();
                    dt = db.Read_Data("select Deserved.Des_ID,Deserved_Type.Name,Price,Date,Notes from Deserved,Deserved_Type where Deserved.Type_ID=Deserved_Type.Des_ID");
                    Sum();

                }
            }
        }
    }
}