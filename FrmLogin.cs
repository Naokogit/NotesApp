using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using ButtonsClass;

namespace NotesApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        int c = 0;
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (c % 2 == 0)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '●';
            c++;
        }
        private void btnMouseEnter(object sender, EventArgs e) { Buttons.HoverAnimation(sender); }
        private void btnMouseLeave(object sender, EventArgs e) { Buttons.LeaveAnimation(sender); }
        private void btnExitEvent(object sender, EventArgs e) { Buttons.closeEvent(); }
        private void btnMinimizeEvent(object sender, EventArgs e) { Buttons.minimizeEvent(this); }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtPassword.Text))
                    throw new Exception("Alcuni campi sono vuoti.");
                User user = new User();

                user.Email = txtEmail.Text;
                user.Password = txtPassword.Text;

                UserController controller = new UserController();

                if (controller.FindUser(user))
                {
                    FrmHub frm = new FrmHub(user);
                    frm.Show();
                    Close();
                }
                else
                    throw new Exception("Utente non trovato");
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            frm.Show();
            Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

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
