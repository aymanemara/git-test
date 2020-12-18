using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace POS1
{
    class DB_OPs
           
    {
        SqlConnection CONN = new SqlConnection("server=DESKTOP-SVMF3OA;initial catalog=POS;integrated security=true");
        SqlCommand cmd = new SqlCommand();
        

        public void Write_Data(string qry,string msg)
        {
            try
            {

                cmd.Connection = CONN;
                cmd.CommandText = qry;    
                CONN.Open();
                cmd.ExecuteNonQuery();
                CONN.Close();
                if (msg!="")
                {
                    switch (msg)
                    {
                        case "Add" :
                            MessageBox.Show("تمت الاضافة بنجاح", "تأكيد",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
                            break;
                        case "Edit":
                            MessageBox.Show("تم التعديل بنجاح", "تأكيد",MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                            break;
                        case "Del":
                            MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                            break;

                    }
                    
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ");
                CONN.Close();
            }

        }
        public DataTable Read_Data(string qry)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = CONN;
                cmd.CommandText = qry;
                CONN.Open();
                dt.Load(cmd.ExecuteReader());
                CONN.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ");
                CONN.Close();
            }
            return dt;
        }
        public int Auto_Num(string fld,string tbl)
        {
            int no;
            DataTable dt = new DataTable(); ;
            dt=Read_Data("select max("+fld+") from "+tbl+"");
            if (dt.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                no = 1;

            }
            else
            {
                no = Convert.ToInt32(dt.Rows[0][0]) + 1;
            }
            return no;
            
        }
        





    }
}
