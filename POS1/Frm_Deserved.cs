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
    public partial class Frm_Deserved : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Deserved()
        {
            InitializeComponent();
        }
        DB_OPs db = new DB_OPs();
        DataTable dt = new DataTable();
        int i;
        public void ClearAll()
        {
            int no;
            no = db.Auto_Num("Des_ID", "Deserved");
            txtid.Text = no.ToString();
            DtpDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            NudPrice.Value = 0;
            CbxType.Text = "";
            txtnotes.Text = "";
            dt.Clear();
            dt = db.Read_Data("select count(Des_ID) from Deserved");
            i = Convert.ToInt32(dt.Rows[0][0]);
            btnadd.Enabled = true;
            btnnew.Enabled = true;
            btnsave.Enabled = false;
            btndel.Enabled = false;
            btndelall.Enabled = false;
            dt.Clear();
            dt = db.Read_Data("select name from Deserved_Type");
            CbxType.Properties.Items.Clear();
            for(int r = 0; r<=Convert.ToInt32(dt.Rows.Count) - 1; r++)
            {
                CbxType.Properties.Items.Add(dt.Rows[r][0].ToString());
            }


        }
        public void Show()
        {
            dt.Clear();
            dt = db.Read_Data("select * from Deserved");
            if (dt.Rows.Count==0)
            {
                MessageBox.Show("لا توجد بيانات مخزنة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                ClearAll();
            }
            else
            {
                txtid.Text = dt.Rows[i][0].ToString();
                
                NudPrice.Value = Convert.ToDecimal(dt.Rows[i][1]);
                DtpDate.Text= dt.Rows[i][2].ToString();
                
                txtnotes.Text = dt.Rows[i][3].ToString();
                int x = Convert.ToInt32(dt.Rows[i][4]);
                dt.Clear();
                dt = db.Read_Data("select Name from Deserved_Type where Des_ID=" + x + "");
                CbxType.Text = dt.Rows[0][0].ToString();
                btnadd.Enabled = false;
                btnnew.Enabled = true;
                btnsave.Enabled = true;
                btndel.Enabled = true;
                btndelall.Enabled = true;
            }
        }
        private void Frm_Deserved_Load(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            i = 0;
            Show();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                dt.Clear();
                dt = db.Read_Data("select count(Des_ID) from Deserved");
                i = Convert.ToInt32(dt.Rows[0][0]) - 1;
                Show();   
            }
            else
            {
                i--;
                Show();
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.Read_Data("select count(Des_ID) from Deserved");
        
            if (i >= Convert.ToInt32(dt.Rows[0][0]) - 1)
            {
                i = 0;
                Show();
            }
            else
            {
                i++;
                Show();
            }
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.Read_Data("select count(Des_ID) from Deserved");
            i = Convert.ToInt32(dt.Rows[0][0]) - 1;
            Show();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (CbxType.Text == "")
            {
                MessageBox.Show("الرجاء اختيار نوع المصروف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            else
            {
                dt.Clear();
                dt = db.Read_Data("select Des_ID from Deserved_Type where Name='" + CbxType.Text + "'");
                int x = Convert.ToInt32(dt.Rows[0][0]);
                db.Write_Data("insert into Deserved values(" + txtid.Text + "," + NudPrice.Value + ",N'" + DtpDate.Text + "',N'" + txtnotes.Text + "'," + x + ")", "Add");
                ClearAll();
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (CbxType.Text == "")
            {
                MessageBox.Show("الرجاء اختيار نوع المصروف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            else
            {
                dt.Clear();
                dt = db.Read_Data("select Des_ID from Deserved_Type where Name='" + CbxType.Text + "'");
                int x = Convert.ToInt32(dt.Rows[0][0]);
                db.Write_Data("update Deserved set Price=" + NudPrice.Value + ",Date='" + DtpDate.Text + "',Notes='" + txtnotes.Text + "',Type_ID="+x+" where Des_ID=" + txtid.Text + "", "Edit");
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                db.Write_Data("delete from Deserved where Des_ID=" + txtid.Text + "", "Del");
                i--;
                if (i < 0)
                {
                    i = 0;
                }
                Show();
            }
        }

        private void btndelall_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من حذف جميع البيانات", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                db.Write_Data("delete from Deserved", "Del");
                ClearAll();
            }
        }
    }
}