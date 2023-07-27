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
    public partial class TimKiemPhong : Form
    {
        public TimKiemPhong()
        {
            InitializeComponent();
        }
        private Database db;
        private void TimKiemPhong_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDStimkiemPhong();


            dgvDStimkiemPhong.Columns["maphong"].HeaderText = "Mã phòng";
            dgvDStimkiemPhong.Columns["khuvuc"].HeaderText = "Khu vực";
            dgvDStimkiemPhong.Columns["slsv_dki"].HeaderText = "SLSV đăng kí";
            dgvDStimkiemPhong.Columns["slsv_toida"].HeaderText = "SLSV tối đa";
            dgvDStimkiemPhong.Columns["giaphong"].HeaderText = "Giá phòng";
            dgvDStimkiemPhong.Columns["masv"].HeaderText = "Mã sinh viên";
            dgvDStimkiemPhong.Columns["tensv"].HeaderText = "Họ tên SV";
        }
        private void LoadDStimkiemPhong()
        {
            db = new Database();
            var timKiem = txtMatimkiem.Text.Trim();
            var pstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@timKiem",
                    value = timKiem
                }
            };
            var dt = db.SelectData("timkiemPhong", pstPara);

            dgvDStimkiemPhong.DataSource = dt;

           dgvDStimkiemPhong.Columns[0].Width = 100;
            dgvDStimkiemPhong.Columns[2].Width = 200;
            dgvDStimkiemPhong.Columns[1].Width = 200;
            dgvDStimkiemPhong.Columns[3].Width= 200;

           dgvDStimkiemPhong.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void txtMatimkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnTimkiem.PerformClick();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            LoadDStimkiemPhong();
        }
    }
}
