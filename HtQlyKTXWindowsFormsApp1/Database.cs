using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HtQlyKTXWindowsFormsApp1
{
    public class Database
    {
            private string connetionString = @" Data Source=PHUONG\SQLEXPRESS;Initial Catalog=QLyKTX;Integrated Security=True";
            private SqlConnection conn;
            private DataTable dt;
            private SqlCommand cmd;

            public Database()
            {
                try
                {
                    conn = new SqlConnection(connetionString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kết nối thất bại: " + ex.Message);
                }
            }
      
        public DataTable SelectData(String sql, List<CustomParameter> lstPara = null)
            {
                try
                {
                    conn.Open();

                cmd = new SqlCommand(sql, conn); //nội dung sql được truyền vào
                    cmd.CommandType = CommandType.StoredProcedure; //set command type cho cmd
                   if(lstPara != null )
                {
                    foreach (var para in lstPara)
                    {
                        cmd.Parameters.AddWithValue(para.key, para.value);


                    }
                }
                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load dữ liệu" + ex.Message);
                    return null;
                }
                finally
                {
                    conn.Close();
                }
            }

            public int ExeCute(string sql, List<CustomParameter> lstPara = null)
            {
                try
                {


                    //string sql, list<customparameter> lstPara là tham số truyền vào

                    conn.Open();
                    cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var p in lstPara)
                    {
                        cmd.Parameters.AddWithValue(p.key, p.value);
                    }
                    var rs = cmd.ExecuteNonQuery();
                    return (int)rs;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thực thi câu lệnh:" + ex.Message);
                    return -100;
                }
                finally
                {
                    conn.Close();
                }
            }// thêm bớt và nhập dữ liệu 

            public DataRow Select(string sql)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand(sql, conn); //truyền giá trị vào cmd
                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader()); //thực thi câu lệnh 
                    return dt.Rows[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load thông tin chi tiết: " + ex.Message);
                    return null;

                }
                finally
                {
                    conn.Close(); //cuối cùng đóng kết nối
                }
            }
        }

        public class CustomParameter
        {
            public string key { get; set; }
            public string value { get; set; }
        }

}