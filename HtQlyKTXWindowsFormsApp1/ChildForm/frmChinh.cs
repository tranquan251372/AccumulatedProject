using HtQlyKTXWindowsFormsApp1.ChucNang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HtQlyKTXWindowsFormsApp1.ChildForm
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }
        private void AddForm(Form f)
        {
            this.grpChinh.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.grpChinh.Controls.Add(f);
            f.Show();
        }
        private void txt_Tkhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
          
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new QLNhanVien();
            AddForm(f);
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new QLSinhVien();
            AddForm(f);
        }

        private void sinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new TimKiemSV();
            AddForm(f);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form1();
            AddForm(f);
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new QLPhong();
            AddForm(f);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new TimkiemNV();
            AddForm(f);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tms_Dichvu_Click(object sender, EventArgs e)
        {
            var f = new QLDichVu();
            AddForm(f);
        }

        private void trangChủToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          var f = new trangchu();
           AddForm(f);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void phòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new TimKiemPhong();
            AddForm(f);
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new HoaDon();
            AddForm(f); 
        }

        private void đãThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new HD_dathanhtoan();
            AddForm(f);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
