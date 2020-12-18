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
using System.Globalization;

namespace POS1
{
    public partial class Frm_Product : DevExpress.XtraEditors.XtraForm
    {
        Frm_Buy buyform;
        public Frm_Product(Frm_Buy frmbuy)
        {
            InitializeComponent();
            this.buyform = frmbuy;
        }
        public Frm_Product()
        {
            InitializeComponent();
            
        }
        DB_OPs db = new DB_OPs();
        DataTable dt = new DataTable();
        int row;
        public void Clearall()
        {
            int no;
            no = db.Auto_Num("Pro_ID", "Products");
            txtid.Text = no.ToString();
            txtname.Text = "";
            nudQty.Value = 0;
            NudMinQty.Value = 0;
            NudBuyprice.Value = 0;
            NudSellPrice.Value = 0;
            txtBarcode.Text = "";
            NudDiscount.Value = 0;
            btnadd.Enabled = true;
            btnnew.Enabled = true;
            btnsave.Enabled = false;
            btndel.Enabled = false;
            btndelall.Enabled = false;
            dt.Clear();
            dt = db.Read_Data("select count(Pro_ID) from Products");
            row = Convert.ToInt32(dt.Rows[0][0]);
            Fill_Cbx();
            CbxProduct.SelectedIndex = -1;

        }
        public void Show()
        {
            dt.Clear();
            dt = db.Read_Data("select * from Products");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            else
            {
                txtid.Text = Convert.ToInt32(dt.Rows[row][0]).ToString();
                txtname.Text = dt.Rows[row][1].ToString();
                nudQty.Value= Convert.ToDecimal(dt.Rows[row][2]);
                NudBuyprice.Value= Convert.ToDecimal(dt.Rows[row][3]);
                NudSellPrice.Value= Convert.ToDecimal(dt.Rows[row][4]);
                txtBarcode.Text= dt.Rows[row][5].ToString();
                NudMinQty.Value= Convert.ToDecimal(dt.Rows[row][6]);
                NudDiscount.Value= Convert.ToDecimal(dt.Rows[row][7]);
                btnadd.Enabled = false;
                btnnew.Enabled = true;
                btnsave.Enabled = true;
                btndel.Enabled = true;
                btndelall.Enabled = true;
            }
        }
        public void Fill_Cbx()
        {
            CbxProduct.Properties.Items.Clear();

            dt.Clear();
            dt = db.Read_Data("select Pro_Name from Products");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CbxProduct.Properties.Items.Add(dt.Rows[i][0]);
                }
            }
            
        }
        private void txtname_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-sa"));
        }

        private void Frm_Product_Load(object sender, EventArgs e)
        {
            Clearall();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            Clearall();
           
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("الرجاء ادخال اسم المنتج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
                return;
            }
            if (NudBuyprice.Value <= 0)
            {
                MessageBox.Show("الرجاء ادخال سعر الشراء", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            if (NudSellPrice.Value <= 0)
            {
                MessageBox.Show("الرجاء ادخال سعر البيع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            if (NudDiscount.Value >= NudSellPrice.Value)
            {
                MessageBox.Show("يجب أن يكون الخصم أقل من سعر البيع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            db.Write_Data("insert into Products values(" + txtid.Text + ",N'" + txtname.Text + "'," + nudQty.Value + "," + NudBuyprice.Value + "," + NudSellPrice.Value + ",N'" + txtBarcode.Text + "'," + NudMinQty.Value + "," + NudDiscount.Value + ")", "Add");
            Clearall();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            row = 0;
            Show();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.Read_Data("select count(Pro_ID) from Products");
            if (row == 0)
            {
                row = Convert.ToInt32(dt.Rows[0][0])-1;
                Show();
            }
            else
            {
                row--;
                Show();
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.Read_Data("select count(Pro_ID) from Products");
            if (row >= Convert.ToInt32(dt.Rows[0][0]) - 1)
            {
                row = 0;
                Show();
            }
            else
            {
                row++;
                Show();
            }
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.Read_Data("select count(Pro_ID) from Products");
            row = Convert.ToInt32(dt.Rows[0][0]) - 1;
            Show();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("سيتم حذف بيانات المنتج هل أنت متأكد","تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)==DialogResult.Yes)
            {
                db.Write_Data("delete from Products where Pro_ID=" + txtid.Text + "", "Del");
                row--;
                if (row < 0)
                {
                    row = 0;
                }
                Show();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("الرجاء ادخال اسم المنتج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            if (NudBuyprice.Value <= 0)
            {
                MessageBox.Show("الرجاء ادخال سعر الشراء", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            if (NudSellPrice.Value <= 0)
            {
                MessageBox.Show("الرجاء ادخال سعر البيع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            if (NudDiscount.Value >= NudSellPrice.Value)
            {
                MessageBox.Show("يجب أن يكون الخصم أقل من سعر البيع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            db.Write_Data("update Products set Pro_Name='"+txtname.Text+ "',Qty="+nudQty.Value+ ",Buy_Price="+NudBuyprice.Value+ ",Sale_Price="+NudSellPrice.Value+"" +
                ",Barcode=N'"+txtBarcode.Text+ "',MinQty="+NudMinQty.Value+ ",Discount="+NudDiscount.Value+ " where Pro_ID="+txtid.Text+"", "Edit");
            Fill_Cbx();
           
               
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.Read_Data("select * from Products where Pro_Name like N'%"+txtfind.Text+"%'");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("لم يتم العثور على اسم المنتج", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(dt.Rows[0][0]);
                dt.Clear();
                dt = db.Read_Data("select * from Products");
                ////////////////////////////////////////////////////////
                //https://www.codeproject.com/Questions/698150/how-to-find-the-indexof-row-in-datatable
                //int index = -1;
                //DataRow[] rows = dt.Select("MyColumnName Like '%a%'");
                //if (rows.Count() > 0)
                //{
                //    index = myDataTable.Rows.IndexOf(rows[0]);
                //}
                ///////////////////////////////////////////////////////
                DataRow[] dr = dt.Select("Pro_ID=" + id + "");
                if (dr.Count() > 0)
                {
                    row = dt.Rows.IndexOf(dr[0]);
                    Show();
                }
                
            }
            
            
            

        }

        private void CbxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Clear();
            dt = db.Read_Data("select Pro_ID from Products where Pro_Name='" + CbxProduct.Text + "'");
            if (dt.Rows.Count > 0)
            {
                int id = Convert.ToInt32(dt.Rows[0][0]);
                dt.Clear();
                dt = db.Read_Data("select * from Products");
                DataRow[] dr = dt.Select("Pro_ID=" + id + "");
                if (dr.Count() > 0)
                {
                    row = dt.Rows.IndexOf(dr[0]);
                    Show();
                }
            }
        }

        private void btndelall_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("سيتم حذف جميع بيانات المنتجات هل أنت متأكد", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                db.Write_Data("delete from Products", "Del");
                Clearall();
            }
        }

        private void Frm_Product_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (buyform != null)
            {
                buyform.Fill_CbxProduct();
            }
            

        }

        private void Frm_Product_FormClosing(object sender, FormClosingEventArgs e)
        {

           
           

        }
    }
}