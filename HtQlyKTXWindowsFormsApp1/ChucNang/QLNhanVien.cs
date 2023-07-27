using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HtQlyKTXWindowsFormsApp1.ChucNang
{
    public partial class QLNhanVien : Form
    {
        public QLNhanVien()
        {
            InitializeComponent();
        }
        private Database db;
        private void LoadDSNhanv()
        {
           var db = new Database();
            dvgDsachNV.DataSource = db.SelectData("LoadDSNhanVien");

            dvgDsachNV.Columns[0].Width = 100;
            dvgDsachNV.Columns[2].Width = 200;
            dvgDsachNV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDSNhanv();

            dvgDsachNV.Columns["manv"].HeaderText = "Mã nhân viên";
            dvgDsachNV.Columns["tennv"].HeaderText = "Họ tên";
            dvgDsachNV.Columns["chucvu"].HeaderText = "Chức vụ";
            dvgDsachNV.Columns["sdt"].HeaderText = "Số điện thoại";
            dvgDsachNV.Columns["maphong"].HeaderText = "Mã phòng quản lý";


        }

        private void txt_maNv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ChucVu_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dvgDsachNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_maNv.Text = (string)dvgDsachNV.Rows[e.RowIndex].Cells[0].Value;
                txtHoten.Text = (string)dvgDsachNV.Rows[e.RowIndex].Cells[1].Value;
                txt_ChucVu.Text = (string)dvgDsachNV.Rows[e.RowIndex].Cells[2].Value;

                txtSDT.Text = dvgDsachNV.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtMaphong.Text = (string)dvgDsachNV.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            


            var manv = txt_maNv.Text.Trim();
            var tennv = txtHoten.Text.Trim();
            var chucvu =txt_ChucVu.Text.Trim();
            var sdt = int.Parse(txtSDT.Text);
            var maphong = txtMaphong.Text.Trim();


            //ràng buộc dữ liệu 
      
            if (string.IsNullOrEmpty(chucvu))
            {
                MessageBox.Show("Vui long nhập chức vụ", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(tennv))
            {
                MessageBox.Show("Vui long nhạp tên nhân viên", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(manv))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (sdt == 0 )
            {
                MessageBox.Show("Số điện thoại đăng kí không hợp lệ", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(maphong))
            {
                MessageBox.Show("Vui long nhạp ma phong", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var prlist = new List<CustomParameter>();
            prlist.Add(new CustomParameter
            {
                key = "@manv",
                value = manv
            });

           
            prlist.Add(new CustomParameter
            {
                key = "@tennv",
                value = tennv
            });

            prlist.Add(new CustomParameter
            {
                key = "@chucvu",
                value = chucvu

            });
            prlist.Add(new CustomParameter
            {
                key = "@sdt",
                value = sdt.ToString()
            });
            prlist.Add(new CustomParameter
            {
                key = "@maphong",
                value = maphong
            });
            var rs = db.ExeCute("themNhanVien", prlist);
            if (rs == 1)
            {
                MessageBox.Show("Thêm thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSNhanv();

                txt_maNv.Text = null;
               txt_ChucVu.Text = null;
                txtSDT.Text = null;
                txtMaphong.Text = null;
                txtHoten.Text = null;
            }
        }

        private void btn_CapNhatNV_Click(object sender, EventArgs e)
        {
            txt_maNv.ReadOnly = false;
            txtHoten.ReadOnly = false;
            txt_ChucVu.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtMaphong.ReadOnly = false;


            var manv = txt_maNv.Text.Trim();
            var tennv = txtHoten.Text.Trim();
            var chucvu = txt_ChucVu.Text.Trim();
            var sdt = int.Parse(txtSDT.Text);
            var maphong = txtMaphong.Text.Trim();


            //ràng buộc dữ liệu 

            if (string.IsNullOrEmpty(chucvu))
            {
                MessageBox.Show("Vui long nhập chức vụ", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(tennv))
            {
                MessageBox.Show("Vui long nhạp tên nhân viên", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(manv))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (sdt == 0)
            {
                MessageBox.Show("Số điện thoại đăng kí không hợp lệ", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(maphong))
            {
                MessageBox.Show("Vui long nhạp ma phong", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var prlist = new List<CustomParameter>();
            prlist.Add(new CustomParameter
            {
                key = "@manv",
                value = manv
            });


            prlist.Add(new CustomParameter
            {
                key = "@tennv",
                value = tennv
            });

            prlist.Add(new CustomParameter
            {
                key = "@chucvu",
                value = chucvu

            });
            prlist.Add(new CustomParameter
            {
                key = "@sdt",
                value = sdt.ToString()
            });
            prlist.Add(new CustomParameter
            {
                key = "@maphong",
                value = maphong
            });
            var rs = db.ExeCute("SuaNhanVien", prlist);
            if (rs == 1)
            {
                MessageBox.Show("Cập nhật lại thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSNhanv();

                txt_maNv.Text = null;
                txt_ChucVu.Text = null;
                txtSDT.Text = null;
                txtMaphong.Text = null;
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "thong báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                         key = "@manv",
                        value =txt_maNv.Text


                    }

                };
                var rs = db.ExeCute("XoaNhanvien", lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSNhanv();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dvgDsachNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
