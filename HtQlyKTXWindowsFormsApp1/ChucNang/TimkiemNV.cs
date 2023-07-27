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
    public partial class TimkiemNV : Form
    {
        public TimkiemNV()
        {
            InitializeComponent();
        }
        private Database db;
        private void TimkiemNV_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDStimkiemNV();

            dgvdsTimkiem.Columns["manv"].HeaderText = "Mã nhân viên";
            dgvdsTimkiem.Columns["tennv"].HeaderText = "Họ tên";
            dgvdsTimkiem.Columns["chucvu"].HeaderText = "Chức vụ";
            dgvdsTimkiem.Columns["sdt"].HeaderText = "Số điện thoại";
            dgvdsTimkiem.Columns["maphong"].HeaderText = "Mã phòng quản lý";


        }
        private void LoadDStimkiemNV()
        {
            db = new Database();
            var timKiem = txtManv.Text.Trim();
            var pstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@timKiem",
                    value = timKiem
                }
            };
            var dt = db.SelectData("LoadDStimkiemNV", pstPara);

          dgvdsTimkiem.DataSource = dt;

            dgvdsTimkiem.Columns[0].Width = 100;
            dgvdsTimkiem.Columns[2].Width = 200;
            dgvdsTimkiem.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            LoadDStimkiemNV();
        }

        private void txtManv_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtManv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
               btnTimkiem.PerformClick();
        }
    
    }
}
