using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HtQlyKTXWindowsFormsApp1.ChucNang
{
    public partial class TimKiemSV : Form
    {
        public TimKiemSV()
        {
            InitializeComponent();
        }
        private Database db;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        /*
        private void timkiemSV()
        {
            
            var db = new Database();
            dgvDStimkiem.DataSource = db.SelectData("LoadDsSV");

           
        }
        */
        private void TimKiemSV_Load(object sender, EventArgs e)
        {
            db = new Database();
            loadDStimkiemSV();

            dgvDStimkiem.Columns["masv"].HeaderText = "Mã sinh vien";
            dgvDStimkiem.Columns["tensv"].HeaderText = "Họ tên SV";
            dgvDStimkiem.Columns["gioitinh"].HeaderText = "Giới tính";
            dgvDStimkiem.Columns["lop"].HeaderText = "lớp";
            dgvDStimkiem.Columns["quequan"].HeaderText = "Quê quán";
            dgvDStimkiem.Columns["sdt"].HeaderText = "Số điện thoại";
            dgvDStimkiem.Columns["maphong"].HeaderText = "Mã phòng";
            dgvDStimkiem.Columns["khuvuc"].HeaderText = "Khu vực";
            dgvDStimkiem.Columns["slsv_dki"].HeaderText = "SLSV đăng kí";
            dgvDStimkiem.Columns["slsv_toida"].HeaderText = "SLSV tối đa";
            dgvDStimkiem.Columns["giaphong"].HeaderText = "Giá phòng";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDStimkiemSV();
        }

        private void txtMasvtim_TextChanged(object sender, EventArgs e)
        {
           
        }
         private void loadDStimkiemSV()
        {
            db = new Database();
            var timkiem = txtMasvtim.Text.Trim();
            var pstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@timkiem",
                    value = timkiem
                }
            };
            var dt = db.SelectData("LoadDStimkiemSV", pstPara);

            dgvDStimkiem.DataSource = dt;

            dgvDStimkiem.Columns[0].Width = 100;
            dgvDStimkiem.Columns[2].Width = 200;
            dgvDStimkiem.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void txtMasvtim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btn_timkiem.PerformClick();
        }
    }
}
