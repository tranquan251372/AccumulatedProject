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
    public partial class QLSinhVien : Form
    {
        public QLSinhVien()
        {
            InitializeComponent();
        }
        private Database db;

       
        private void LoadDsSV()
        {
            var db = new Database();

            dgvDsachSV.DataSource = db.SelectData("LoadDSSinhvien");


            dgvDsachSV.Columns[0].Width = 100;
            dgvDsachSV.Columns[2].Width = 200;
            dgvDsachSV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void QLSinhVien_Load(object sender, EventArgs e)
        {
             db = new Database();
            LoadDsSV();

            dgvDsachSV.Columns["masv"].HeaderText = "Mã sinh vien";
            dgvDsachSV.Columns["tensv"].HeaderText = "Họ tên SV";
            dgvDsachSV.Columns["gioitinh"].HeaderText = "Giới tính";
            dgvDsachSV.Columns["lop"].HeaderText = "lớp";
            dgvDsachSV.Columns["quequan"].HeaderText = "Quê quán";
            dgvDsachSV.Columns["sdt"].HeaderText = "Số điện thoại";
            dgvDsachSV.Columns["maphong"].HeaderText = "Mã phòng";
            
        }
        private void dgvDsachSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_maSV.Text = (string)dgvDsachSV.Rows[e.RowIndex].Cells[0].Value;
                txt_HotenSV.Text = (string)dgvDsachSV.Rows[e.RowIndex].Cells[1].Value;
                txtGioitinh.Text= (string)dgvDsachSV.Rows[e.RowIndex].Cells[2].Value;
                txtLop.Text = (string)dgvDsachSV.Rows[e.RowIndex].Cells[3].Value;
                
                txtQuequan.Text = (string)dgvDsachSV.Rows[e.RowIndex].Cells[4].Value;
                txtMaphong.Text = (string)dgvDsachSV.Rows[e.RowIndex].Cells[6].Value;

                txtSdt.Text = dgvDsachSV.Rows[e.RowIndex].Cells[5].Value.ToString();

            }
        }
        private void btn_ThemSV_Click(object sender, EventArgs e)
        {
            var masv = txt_maSV.Text.Trim();
            var hoten = txt_HotenSV.Text.Trim();
            var gioitinh = txtGioitinh.Text.Trim();
            var lop = txtLop.Text.Trim();
            var quequan = txtQuequan.Text.Trim();
            var maphong = txtMaphong.Text.Trim();
            var sdt = int.Parse(txtSdt.Text);

            //ràng buộc dữ liệu 

            if (string.IsNullOrEmpty(masv))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên của bạn!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(gioitinh))
            {
                MessageBox.Show("Vui lòng nhập giới tính của bạn!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(lop))
            {
                MessageBox.Show("Vui lòng nhập lớp học!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (string.IsNullOrEmpty(hoten))
            {
                MessageBox.Show("Vui lòng nhập tên!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(quequan))
            {
                MessageBox.Show("Vui lòng nhập quê quán !", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(maphong))
            {
                MessageBox.Show("Vui lòng nhập mã phòng!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (sdt == 0)
            {
                MessageBox.Show("Số điện thoại đăng kí không hợp lệ", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var prlist = new List<CustomParameter>();
            prlist.Add(new CustomParameter
            {
                key = "@masv",
                value = masv
            });
            prlist.Add(new CustomParameter
            {
                key = "@tensv",
                value = hoten
            });
            prlist.Add(new CustomParameter
            {
                key = "@gioitinh",
                value = gioitinh
            });
            prlist.Add(new CustomParameter
            {
                key = "@lop",
                value =lop

            });
            
            prlist.Add(new CustomParameter
            {
                key = "@quequan",
                value = quequan
            });
            prlist.Add(new CustomParameter
            {
                key = "@maphong",
                value = maphong
            });
            prlist.Add(new CustomParameter
            {
                key = "@sdt",
                value = sdt.ToString()
            });
       
            var rs = db.ExeCute("themSinhvien", prlist);
            if (rs == 1)
            {
                MessageBox.Show("Thêm thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsSV();
            }
        }
      
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var masv = txt_maSV.Text.Trim();
            var hoten = txt_HotenSV.Text.Trim();
            var gioitinh = txtGioitinh.Text.Trim();
            var lop = txtLop.Text.Trim();
            var quequan = txtQuequan.Text.Trim();
            var maphong = txtMaphong.Text.Trim();
            var sdt = int.Parse(txtSdt.Text);

            //ràng buộc dữ liệu 

            if (string.IsNullOrEmpty(masv))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên của bạn!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(gioitinh))
            {
                MessageBox.Show("Vui lòng nhập giới tính của bạn!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(lop))
            {
                MessageBox.Show("Vui lòng nhập lớp học!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(hoten))
            {
                MessageBox.Show("Vui lòng nhập tên!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(quequan))
            {
                MessageBox.Show("Vui lòng nhập quê quán !", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(maphong))
            {
                MessageBox.Show("Vui lòng nhập mã phòng!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (sdt == 0)
            {
                MessageBox.Show("Số điện thoại đăng kí không hợp lệ", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var prlist = new List<CustomParameter>();
            prlist.Add(new CustomParameter
            {
                key = "@masv",
                value = masv
            });
            prlist.Add(new CustomParameter
            {
                key = "@tensv",
                value = hoten
            });
            prlist.Add(new CustomParameter
            {
                key = "@gioitinh",
                value = gioitinh
            });
            prlist.Add(new CustomParameter
            {
                key = "@lop",
                value = lop

            });

            prlist.Add(new CustomParameter
            {
                key = "@quequan",
                value = quequan
            });
            prlist.Add(new CustomParameter
            {
                key = "@maphong",
                value = maphong
            });
            prlist.Add(new CustomParameter
            {
                key = "@sdt",
                value = sdt.ToString()
            });

            

            var rs = db.ExeCute("suaSinhvien", prlist);
            if (rs == 1)
            {
                MessageBox.Show("Sửa thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsSV();
            }
        }
        private void btn_XoaSV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "thong báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@masv",
                        value = txt_maSV.Text


                    }

                };
             var rs = db.ExeCute("XoaSinhvien", lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDsSV();
                }
            }
        }
        private void txtLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_maSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_HotenSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuequan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
