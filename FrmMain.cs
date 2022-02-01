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

using ButtonsClass;

namespace NotesApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) { }

        private void btnMouseEnter(object sender, EventArgs e) { Buttons.HoverAnimation(sender); }
        private void btnMouseLeave(object sender, EventArgs e) { Buttons.LeaveAnimation(sender); }
        private void btnExitEvent(object sender, EventArgs e) { Buttons.closeEvent(); }
        private void btnMinimizeEvent(object sender, EventArgs e) { Buttons.minimizeEvent(this); }

        private void BtnShowLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();

            Hide();
            Close();
        }

        private void BtnShowRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frm = new FrmRegister();
            frm.Show();
            Hide();
            Close();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }
    }
}
