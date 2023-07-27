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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        private Database db;
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            db =   new Database();
            LoadDSPhong();
            LoadDSNhanvien();


          txtDVkhac.ReadOnly = true;
           txtMahd.ReadOnly= true;
           txtGiaphong.ReadOnly = true;
           txtDongiadien.ReadOnly = true;
            txtdongianuoc.ReadOnly = true;
            txtSodien.ReadOnly = true;
            txtSonuoc.ReadOnly = true;
           

          
        }
        private void LoadDSNhanvien()
        {
            var dt = db.SelectData("LoadDSNhanVien");
            cbbManv.DataSource = dt;
            cbbManv.DisplayMember = "manv";
        }
        private void LoadDSPhong()
        {
            var dt = db.SelectData("LoadDSphong");
            cbbMaphong.DataSource = dt;
            cbbMaphong.DisplayMember = "maphong";
        }

        private void TaoHD_Click(object sender, EventArgs e)
        {

            txtDVkhac.ReadOnly = false;
            txtMahd.ReadOnly = false;
            txtGiaphong.ReadOnly = false;
            txtDongiadien.ReadOnly = false;
            txtdongianuoc.ReadOnly = false;
            txtSodien.ReadOnly = false;
            txtSonuoc.ReadOnly = false;
            

        }
       

        private void cbbMaphong_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbbMaphong_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void TinhToan()
        {
           
            string data_textbox_a = txtGiaphong.Text; // lấy dữ liệu từ Textbox A
            string data_textbox_b = txtDVkhac.Text;
            string data_textbox_c = txtDongiadien.Text;
            string data_textboc_d = txtdongianuoc.Text;
            string data_textboc_e = txtSodien.Text;
            string data_textboc_f = txtSonuoc.Text;
            
            
            int a = Int32.Parse(data_textbox_a);
            int b = Int32.Parse(data_textbox_b);
            int c = Int32.Parse(data_textbox_c);
            int d = Int32.Parse(data_textboc_d);
            int e = Int32.Parse(data_textboc_e);
            int g = Int32.Parse(data_textboc_f);
           

            int Tong = (a + b + (c*e) +( d*g));
            txtTong.Text = Tong.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
           TinhToan();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var maHD = txtMahd.Text.Trim();
            var maphong = cbbMaphong.Text.Trim();
            var sodien = int.Parse(txtSodien.Text);
            var sonuoc = int.Parse(txtSodien.Text);       
            var dongiadien = int.Parse(txtDongiadien.Text);
            var dongianuoc = int.Parse(txtdongianuoc.Text);
            var ngaylap = NgaylapdateTimePicker.Text.Trim();
            var manguoilap = cbbManv.Text.Trim();


            //ràng buộc dữ liệu 

            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(maphong))
            {
                MessageBox.Show("Vui lòng nhập mã phòng cần thanh toán!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (sodien == 0)
            {
                MessageBox.Show("Vui lòng nhập đúng số điện!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(sonuoc == 0)
            {
                MessageBox.Show("vui lòng nhập đúng só nước!", "ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dongianuoc < 1000)
            {
                MessageBox.Show("Đơn giá điện không hợp lệ!", "ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dongiadien < 1000)
            {
                MessageBox.Show("Đơn giá điện không hợp lệ!", "ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(ngaylap))
            {
                MessageBox.Show("Vui lòng nhập thời gian thanh toán!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(manguoilap))
            {
                MessageBox.Show("Vui lòng nhập nhân viên thanh toán!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var prlist = new List<CustomParameter>();
            prlist.Add(new CustomParameter
            {
                key = "@maHD",
                value = maHD    
            }) ;
            prlist.Add(new CustomParameter
            {
                key = "@maphong",
                value = maphong
            });
            prlist.Add(new CustomParameter
            {
                key = "@sodien",
                value = sodien.ToString()
            });
            prlist.Add(new CustomParameter
            {
                key = "@sonuoc",
                value = sonuoc.ToString()

            });

            prlist.Add(new CustomParameter
            {
                key = "@dongiadien ",
                value = dongiadien.ToString()
            });
            prlist.Add(new CustomParameter
            {
                key = "@dongianuoc",
                value = dongianuoc.ToString()
            });
            prlist.Add(new CustomParameter
            {
                key = "@ngaylap",
                value = ngaylap
            });
            prlist.Add(new CustomParameter
            {
                key = "@manguoilap",
                value = manguoilap
            });
            var rs = db.ExeCute("ThemHoadon", prlist);
            if (rs == 1)
            {
                MessageBox.Show("Thêm thành công", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }
    }
}
