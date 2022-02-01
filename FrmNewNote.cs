using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class FrmNewNote : Form
    {
        public FrmNewNote()
        {
            InitializeComponent();
        }
        public User user;

        public FrmNewNote(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            user.Notes.Add(new Note(txtTitle.Text, txtAuthor.Text, new List<string>(new string[] { "" })));
            DialogResult = DialogResult.OK;
        }

        private void btnIndietro_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmNewNote_Load(object sender, EventArgs e)
        {

        }
    }
}
