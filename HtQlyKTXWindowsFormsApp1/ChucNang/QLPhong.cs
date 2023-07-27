using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HtQlyKTXWindowsFormsApp1.ChucNang
{
    public partial class QLPhong : Form
    {
        public QLPhong()
        {
            InitializeComponent();
        }
        private Database db;
        private int xacnhan = 0;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LoadDSphong()
        {
            var db = new Database();
            dgvDSPhong.DataSource = db.SelectData("LoadDSphong");

            dgvDSPhong.Columns[0].Width = 100;
            dgvDSPhong.Columns[2].Width = 200;
            dgvDSPhong.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

         

        }

        private void dgvDSPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                txtMaphong.Text = (string)dgvDSPhong.Rows[e.RowIndex].Cells[0].Value;
                txtKhuVuc.Text = (string)dgvDSPhong.Rows[e.RowIndex].Cells[1].Value;

                txtsvDadki.Text = dgvDSPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtToida.Text = dgvDSPhong.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGiaphong.Text = dgvDSPhong.Rows[e.RowIndex].Cells[4].Value.ToString();
            }

        }


        private void QLPhong_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDSphong();

            txtKhuVuc.ReadOnly = true;
            txtMaphong.ReadOnly = true;
            txtsvDadki.ReadOnly = true;
            txtToida.ReadOnly = true;

            btnThemPhong.Enabled = btnSua.Enabled = true;
           btnLuu.Enabled = false;

            dgvDSPhong.Columns["maphong"].HeaderText = "Mã phòng";
            dgvDSPhong.Columns["khuvuc"].HeaderText = "Khu vực";
            dgvDSPhong.Columns["slsv_dki"].HeaderText = "SLSV đăng kí";
            dgvDSPhong.Columns["slsv_toida"].HeaderText = "SLSV tối đa";
            dgvDSPhong.Columns["giaphong"].HeaderText = "Giá phòng";

        }


        private void dgvDSPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaphong_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtsvDadki_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtsvDadki_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtToida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            xacnhan = 1;
            txtKhuVuc.ReadOnly = false;
            txtMaphong.ReadOnly = false;
            txtsvDadki.ReadOnly = false;
            txtToida.ReadOnly = false;
            txtGiaphong.ReadOnly=false;

            btnThemPhong.Enabled = btnSua.Enabled = false;
            btnLuu.Enabled =true;

            ///btnSuaDV.Enabled = btnThemDV.Enabled = true;
            // btnLuuMoi.Enabled = false;
        }
       
        private void btnSua_Click(object sender, EventArgs e)
        {
            xacnhan = -1;

            txtKhuVuc.ReadOnly = false;
            txtMaphong.ReadOnly = false;
            txtsvDadki.ReadOnly = false;
            txtToida.ReadOnly = false;

            btnThemPhong.Enabled = btnSua.Enabled = false;
            btnLuu.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var maphong = txtMaphong.Text.Trim();
            var khuvuc = txtKhuVuc.Text.Trim();
            var SLDki = int.Parse(txtsvDadki.Text);
            var SLtoida = int.Parse(txtToida.Text);
            var giaphong = int.Parse(txtGiaphong.Text);


            //ràng buộc dữ liệu 
            if (string.IsNullOrEmpty(maphong))
            {
                MessageBox.Show("Vui long nhạp ma phong", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(khuvuc))
            {
                MessageBox.Show("Vui long nhạp loại phòng", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (SLDki > 10 || SLDki>SLtoida)
            {
                MessageBox.Show("Số lượng đã đăng kí vượt quá chí tiêu và số lượng tối đa", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (SLtoida > 10)
            {
                MessageBox.Show("Số lượng đăng kí tối da không hợp lí!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var prlist = new List<CustomParameter>();
            if (xacnhan == 1)
            {
                prlist.Add(new CustomParameter
                {
                    key = "@Maphong",
                    value = maphong
                });
                prlist.Add(new CustomParameter
                {
                    key = "@khuvuc",
                    value = khuvuc
                });
                prlist.Add(new CustomParameter
                {
                    key = "@SLSV_Dki",
                    value = SLDki.ToString()
                });
                prlist.Add(new CustomParameter
                {
                    key = "@SLSV_toida",
                    value = SLtoida.ToString()
                });
                prlist.Add(new CustomParameter
                {
                    key = "@giaphong",
                    value = giaphong.ToString()
                });

                var rs = db.ExeCute("Themphongktx", prlist);
                if (rs == 1)
                {
                    MessageBox.Show("Thêm thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSphong();

                    txtMaphong.Text = null;
                    txtKhuVuc.Text = null;
                    txtsvDadki.Text = "0";
                    txtToida.Text = "0";
                    txtGiaphong.Text = "0";
                }



            }
            else
             if (xacnhan == -1)
            {
                prlist.Add(new CustomParameter
                {
                    key = "@maphong",
                    value = maphong
                });
                prlist.Add(new CustomParameter
                {
                    key = "@khuvuc",
                    value = khuvuc
                });
                prlist.Add(new CustomParameter
                {
                    key = "@SLSV_Dki",
                    value = SLDki.ToString()
                });
                prlist.Add(new CustomParameter
                {
                    key = "@SLSV_toida",
                    value = SLtoida.ToString()
                });
                prlist.Add(new CustomParameter
                {
                    key = "@giaphong",
                    value = giaphong.ToString()
                });


                var rs = db.ExeCute("SuaPhong", prlist);
                if (rs == 1)
                {
                    MessageBox.Show("sửa thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSphong();

                    txtMaphong.Text = null;
                    txtKhuVuc.Text = null;
                    txtsvDadki.Text = "0";
                    txtToida.Text = "0";
                    txtGiaphong.Text = "0";

                }
            }
            txtKhuVuc.ReadOnly = true;
            txtMaphong.ReadOnly = true;
            txtsvDadki.ReadOnly = true;
            txtToida.ReadOnly = true;

            btnThemPhong.Enabled = btnSua.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "thong báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                         key = "@Maphong",
                        value = txtMaphong.Text


                    }

                };
                var rs = db.ExeCute("xoaPhong", lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSphong();
                }
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
