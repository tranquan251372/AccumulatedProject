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
    public partial class HD_dathanhtoan : Form
    {
        public HD_dathanhtoan()
        {
            InitializeComponent();
        }
        private Database db;
        private void dgvHD_thanhtoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void LoadDSHoadon()
        {
            var db = new Database();

            dgvHD_thanhtoan.DataSource = db.SelectData("LoadDSHoadon");


            dgvHD_thanhtoan.Columns[0].Width = 100;
            dgvHD_thanhtoan.Columns[2].Width = 200;
            dgvHD_thanhtoan.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void HD_dathanhtoan_Load(object sender, EventArgs e)
        {
            db = new Database();
           LoadDSHoadon();

         dgvHD_thanhtoan.Columns["maHD"].HeaderText = "Mã hóa đơn";
           dgvHD_thanhtoan.Columns["maphong"].HeaderText = "Mã phòng";
            dgvHD_thanhtoan.Columns["sodien"].HeaderText = "Số điện";
            dgvHD_thanhtoan.Columns["sonuoc"].HeaderText = "Số nước";
            dgvHD_thanhtoan.Columns["dongiadien"].HeaderText = "Đơn giá điện";
            dgvHD_thanhtoan.Columns["dongianuoc"].HeaderText = "Đơn giá nước";
            dgvHD_thanhtoan.Columns["ngaylap"].HeaderText = " Ngày lập";
            dgvHD_thanhtoan.Columns["manguoilap"].HeaderText = "Mã nhân viên";
        }

        private void button1_Click(object sender, EventArgs e)

        {

            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "thong báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var lstPara = new List<CustomParameter>()
                {
                   
                };
                var rs = db.ExeCute("XoaHoadon", lstPara);
                if (rs == 1)
                {
                    MessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSHoadon();
                }
            }
        }
    }
}
