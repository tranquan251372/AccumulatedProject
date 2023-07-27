using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HtQlyKTXWindowsFormsApp1.ChucNang
{
    public partial class QLDichVu : Form
    {
        public QLDichVu()
        {
            InitializeComponent();
        }
       
        private Database db;
        private int xacnhan = 0;

      
        private void txtGiatien_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtGiatien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiadien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGianuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDV_khac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xacnhan = 1;
            txtMadv.ReadOnly = false;
            
            txtGianuoc.ReadOnly = false;
            txtGiadien.ReadOnly = false;
            txtDV_khac.ReadOnly = false;

            btnSuaDV.Enabled = btnThemDV.Enabled = false;
            btnLuuMoi.Enabled = true;

        }
        private void LoadDSDichVu()
        {
            var db = new Database();
            dgvDSDichvu.DataSource = db.SelectData("LoadDSDichVu");

            dgvDSDichvu.Columns[0].Width = 100;
            dgvDSDichvu.Columns[2].Width = 200;
            dgvDSDichvu.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void QLDichVu_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDSDichVu();
            
            txtMadv.ReadOnly = true; //set 
            
            txtGianuoc.ReadOnly = true;
            txtGiadien.ReadOnly = true;
            txtDV_khac.ReadOnly = true;

            btnSuaDV.Enabled = btnThemDV.Enabled = true; //set hiện ẩn của nút
            btnLuuMoi.Enabled = false;
            
        }

        private void dgvDSDichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
              
                txtMadv.Text = (string)dgvDSDichvu.Rows[e.RowIndex].Cells[0].Value;
              
                txtGiadien.Text = dgvDSDichvu.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGianuoc.Text = dgvDSDichvu.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDV_khac.Text = dgvDSDichvu.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            xacnhan = -1;
            txtMadv.ReadOnly =false;
           
            txtGianuoc.ReadOnly =false;
            txtGiadien.ReadOnly = false;
            txtDV_khac.ReadOnly = false;

            btnSuaDV.Enabled = btnThemDV.Enabled = false;
            btnLuuMoi.Enabled = true;
        }


        private void btnLuuMoi_Click(object sender, EventArgs e)
        {
                var Loaiphong = txtMadv.Text.Trim();
                
                var Giadien = int.Parse(txtGiadien.Text);
                var Gianuoc = int.Parse(txtGianuoc.Text);
                var Dvkhac = int.Parse(txtDV_khac.Text);

                //ràng buộc dữ liệu 
                if (string.IsNullOrEmpty(Loaiphong))
                {
                    MessageBox.Show("Vui long nhạp loai phong", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                if (Giadien < 0)
                {
                    MessageBox.Show("Số tiền không hợp lệ!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Gianuoc < 0)
                {
                    MessageBox.Show("Số tiền không hợp lệ!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Dvkhac < 0)
                {
                    MessageBox.Show("Số tiền không hợp lệ !", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var prlist = new List<CustomParameter>();
                if(xacnhan == 1) //trường hợp thêm phòng
                 {         
                    prlist.Add(new CustomParameter
                    {
                        key = "@LoaiPhong",
                        value = Loaiphong
                    });
                    
                    prlist.Add(new CustomParameter
                    {
                        key = "@Giadien",
                        value = Giadien.ToString()
                    });
                    prlist.Add(new CustomParameter
                    {
                        key = "@Gianuoc",
                        value = Gianuoc.ToString()
                    });
                    prlist.Add(new CustomParameter
                    {
                        key = "@DV_khac",
                        value = Dvkhac.ToString()
                    });
                    var rs = db.ExeCute("DichVu", prlist);
                    if (rs == 1)
                    {
                        MessageBox.Show("Thêm thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSDichVu();
                        txtMadv.Text = null;
                       
                        txtGiadien.Text = "0";
                        txtGianuoc.Text = "0";
                        txtDV_khac.Text = "0";
                     }
                 }
                else
                if(xacnhan == -1) //trường hợp sửa thông tin 
                 {
                    prlist.Add(new CustomParameter
                    {
                        key = "@LoaiPhong",
                        value = Loaiphong
                    });
                    
                    
                    prlist.Add(new CustomParameter
                    {
                        key = "@Giadien",
                        value = Giadien.ToString()
                    });
                    prlist.Add(new CustomParameter
                    {
                        key = "@Gianuoc",
                        value = Gianuoc.ToString()
                    });
                    prlist.Add(new CustomParameter
                    {
                        key = "@DV_khac",
                        value = Dvkhac.ToString()
                    });
                    var rs = db.ExeCute("suaDichVu", prlist);
                    if (rs == 1)
                    {
                        MessageBox.Show("sửa thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDSDichVu();
                        txtMadv.Text = null;
                        
                        txtGiadien.Text = "0";
                        txtGianuoc.Text = "0";
                        txtDV_khac.Text = "0";  
                      }
                 }
                    
            txtMadv.ReadOnly = true;
           
            txtGianuoc.ReadOnly = true;
            txtGiadien.ReadOnly = true;
            txtDV_khac.ReadOnly = true;
            btnSuaDV.Enabled = btnThemDV.Enabled = true;
            btnLuuMoi.Enabled =false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "thong báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                         key = "@LoaiPhong",
                        value = txtMadv.Text


                    }

                };
                var rs = db.ExeCute("xoaDichVu", lstPara);
                if(rs == 1)
                {
                    MessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadDSDichVu();
                }

            }

            else return;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    
    
}
