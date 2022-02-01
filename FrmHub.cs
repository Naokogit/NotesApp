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
    public partial class FrmHub : Form
    {
        public FrmHub()
        {
            InitializeComponent();
        }

        User user;
        public FrmHub(User user)
        {
            InitializeComponent();
            this.user = new UserController().GetUser(user.Email);
        }


        int notesIndex = 0;
        int pagesIndex = 0;


        private void btnLoad_Click(object sender, EventArgs e)
        {
            updateNote();
            updatePage();
        }

        private void updateNote()
        {
            try
            {
                lblAuthor.Text = user.Notes[notesIndex].Author;
                lblEmail.Text = user.Email;
                lblUsername.Text = user.Username;
                txtNoteTitle.Text = user.Notes[notesIndex].Title;
            }
            catch { }

        }
        private void updatePage()
        {
            try
            {
                txtPage.Text = user.Notes[notesIndex].Pages[pagesIndex];
                lblPagina.Text = "Pagina: " + pagesIndex;
            }
            catch { }
        }

        private void FrmHub_Load(object sender, EventArgs e)
        {
            updateNote();
            updatePage();
        }

        private void btnPaginaAvanti_Click(object sender, EventArgs e)
        {
            try
            {
                if (pagesIndex > user.Notes[notesIndex].Pages.Count())
                    pagesIndex--;
                if (pagesIndex < 0)
                    pagesIndex++;

                autoSave();
                pagesIndex++;
                updatePage();
            }
            catch { pagesIndex--; lblPagina.Text = "Pagina: " + pagesIndex; }
        }

        private void btnPaginaIndietro_Click(object sender, EventArgs e)
        {
            try
            {
                if (pagesIndex > user.Notes[notesIndex].Pages.Count())
                    pagesIndex--;
                if (pagesIndex < 0)
                    pagesIndex++;

                autoSave();
                pagesIndex--;
                updatePage();
            }
            catch { pagesIndex++; lblPagina.Text = "Pagina: " + pagesIndex; }
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            txtPage.Text = String.Empty;
            user.Notes[notesIndex].Pages.Add("");
            pagesIndex = user.Notes[notesIndex].Pages.Count() - 1;
            lblPagina.Text = "Pagina: " + (user.Notes[notesIndex].Pages.Count() - 1);
        }


        private void autoSave()
        {
            if (txtPage.Text != user.Notes[notesIndex].Pages[pagesIndex])
                user.Notes[notesIndex].Pages[pagesIndex] = txtPage.Text;
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.Notes[notesIndex].Pages.Count() == 1)
                    throw new Exception();
                DialogResult result = MessageBox.Show("Sei sicuro di eliminare la pagina?", "Eliminazione pagina", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    user.Notes[notesIndex].Pages.RemoveAt(pagesIndex);
                    if (pagesIndex == user.Notes[notesIndex].Pages.Count())
                        pagesIndex--;
                    else
                        pagesIndex++;
                    updatePage();
                    MessageBox.Show("Pagina eliminata con successo", "Eliminazione pagina", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Impossibile eliminare pagina", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNoteAvanti_Click(object sender, EventArgs e)
        {
            try
            {
                autoSave();
                notesIndex++;
                pagesIndex = 0;
                updateNote();
                updatePage();
            }
            catch(Exception ex) { notesIndex--; lblPagina.Text = "Pagina: " + pagesIndex; }
        }

        private void btnNoteIndietro_Click(object sender, EventArgs e)
        {
            try
            {
                autoSave();
                notesIndex--;
                pagesIndex = 0;
                updateNote();
                updatePage();
            }
            catch(Exception ex) { notesIndex++; lblPagina.Text = "Pagina: " + pagesIndex; }
        }

        private void btnAggiungiNote_Click(object sender, EventArgs e)
        {
            FrmNewNote frm = new FrmNewNote(user);
            if(frm.ShowDialog() == DialogResult.OK) 
            {
                user = frm.user;
                autoSave();
                notesIndex++;
                pagesIndex = 0;
                updateNote();
                updatePage();
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();
            controller.UpdateUser(user);
            MessageBox.Show("Note e pagine salvate", "File salvati", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminaNota_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.Notes.Count() == 1)
                    throw new Exception();
                DialogResult result = MessageBox.Show("Sei sicuro di eliminare la nota?", "Eliminazione nota", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    user.Notes.RemoveAt(notesIndex);
                    if (notesIndex == user.Notes.Count())
                        notesIndex--;
                    else
                        notesIndex++;
                    updateNote();
                    updatePage();
                    MessageBox.Show("Nota eliminata con successo", "Eliminazione nota", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Impossibile eliminare la nota", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMouseEnter(object sender, EventArgs e) { Buttons.HoverAnimation(sender); }
        private void btnMouseLeave(object sender, EventArgs e) { Buttons.LeaveAnimation(sender); }
        private void btnExitEvent(object sender, EventArgs e) { Buttons.closeEvent(); }
        private void btnMinimizeEvent(object sender, EventArgs e) { Buttons.minimizeEvent(this); }

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
