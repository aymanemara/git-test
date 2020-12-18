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
    public partial class Frm_Supplier : DevExpress.XtraEditors.XtraForm
    {
        Frm_Buy buyform;
        public Frm_Supplier(Frm_Buy frmbuy)
        {
            InitializeComponent();
            this.buyform = frmbuy;
        }
        public Frm_Supplier()
        {
            InitializeComponent();
            
        }
        DB_OPs db = new DB_OPs();
        DataTable dt = new DataTable();
        int i;
        private void Clearall()
        {
            int no;
            no = db.Auto_Num("Sup_ID", "Suppliers");
            dt.Clear();
            dt = db.Read_Data("select count(Sup_ID) from Suppliers");
            i = Convert.ToInt32(dt.Rows[0][0]);
            txtid.Text = no.ToString();
            txtname.Text = "";
            txtphone.Text = "";
            txtaddress.Text = "";
            txtnotes.Text = "";
            txtfind.Text = "";
            btnadd.Enabled = true;
            btnnew.Enabled = true;
            btnsave.Enabled = false;
            btndel.Enabled = false;
            btndelall.Enabled = false;
        }
        public void Show()
        {
            dt.Clear();
            dt = db.Read_Data("select * from Suppliers");
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("لا توجد بيانات مخزنة", "تنبيه");
                Clearall();
            }
            else
            {
                txtid.Text = dt.Rows[i][0].ToString();
                txtname.Text = dt.Rows[i][1].ToString();
                txtaddress.Text = dt.Rows[i][2].ToString();
                txtphone.Text = dt.Rows[i][3].ToString();
                txtnotes.Text = dt.Rows[i][4].ToString();
                btnadd.Enabled = false;
                btnnew.Enabled = true;
                btnsave.Enabled = true;
                btndel.Enabled = true;
                btndelall.Enabled = true;
            }

        }
        private void Frm_Supplier_Load(object sender, EventArgs e)
        {
            Clearall();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            Clearall();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("الرجاء ادخال اسم المورد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            else
            {
                db.Write_Data("update Suppliers set Sup_Name=N'" + txtname.Text + "',Sup_Address='" + txtaddress.Text + "',Sup_Phone=N'" + txtphone.Text + "',Notes=N'" + txtnotes.Text + "' where Sup_ID=" + txtid.Text + "", "Edit");

            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("الرجاء ادخال اسم المورد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            else
            {
                db.Write_Data("insert into Suppliers values(" + txtid.Text + ",N'" + txtname.Text + "',N'" + txtaddress.Text + "',N'" + txtphone.Text + "',N'" + txtnotes.Text + "')", "Add");
                Clearall();
            }

            

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
                dt = db.Read_Data("select count(Sup_ID) from Suppliers");
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
            dt = db.Read_Data("select count(Sup_ID) from Suppliers");
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
            dt = db.Read_Data("select count(Sup_ID) from Suppliers");
            i = Convert.ToInt32(dt.Rows[0][0]) - 1;
            Show();

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من الحذف", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                db.Write_Data("delete from Suppliers where Sup_ID=" + txtid.Text + "", "Del");
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
                db.Write_Data("delete from Suppliers", "Del");
                Clearall();
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            if (txtfind.Text == "")
            {
                MessageBox.Show("الرجاء ادخال اسم الزبون", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            else
            {
                dt.Clear();
                dt = db.Read_Data("select * from Suppliers where Sup_Name like N'%" + txtname.Text + "%'");
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لم يتم العثور على بيانات الزبون", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    Clearall();
                }
                else
                {
                    txtid.Text = dt.Rows[0][0].ToString();
                    txtname.Text = dt.Rows[0][1].ToString();
                    txtaddress.Text = dt.Rows[0][2].ToString();
                    txtphone.Text = dt.Rows[0][3].ToString();
                    txtnotes.Text = dt.Rows[0][4].ToString();
                    btnadd.Enabled = false;
                    btnnew.Enabled = true;
                    btnsave.Enabled = true;
                    btndel.Enabled = true;
                    btndelall.Enabled = true;

                }

            }
        }

        private void Frm_Supplier_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (buyform != null)
            {
                buyform.Fill_CbxSupplier();
            }
            
        }
    }
}