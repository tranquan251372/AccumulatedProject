using HtQlyKTXWindowsFormsApp1.ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HtQlyKTXWindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
        }

      
        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptb_An_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void ptbPhongto_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal    ) 
            {
                MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                ptbPhongto.Image = Properties.Resources.icons8_show_tab_browser_isolated_on_white_background_24;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                ptbPhongto.Image = Properties.Resources.icons8_maximize_25;
            }
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //hàm add form con lên form chính
        private void AddForm(Form f)
        {
            this.grbContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle= FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text= f.Text;
            this.grbContent.Controls.Add(f);
            f.Show();
        }

        private void grbContent_Enter(object sender, EventArgs e)
        {

        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string user = "Phuong";
            string pass = "1234";
            if (user.Equals(txt_Tkhoan.Text) && pass.Equals(txt_Mkhau.Text))
            {
                MessageBox.Show("Dang nhap thanh cong");
                var f = new frmChinh();
                AddForm(f);
            }
            else
                MessageBox.Show("Sai tai khoan hoac mat khau");
        }

        private void btn_Thoát_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_Mkhau_TextChanged(object sender, EventArgs e)
        {
            this.txt_Mkhau.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
