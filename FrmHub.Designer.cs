namespace NotesApp
{
    partial class FrmHub
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPage = new System.Windows.Forms.RichTextBox();
            this.btnPaginaIndietro = new System.Windows.Forms.Button();
            this.txtNoteTitle = new System.Windows.Forms.GroupBox();
            this.btnElimina = new System.Windows.Forms.Button();
            this.lblPagina = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnPaginaAvanti = new System.Windows.Forms.Button();
            this.btnNoteAvanti = new System.Windows.Forms.Button();
            this.btnNoteIndietro = new System.Windows.Forms.Button();
            this.btnAggiungiNote = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnEliminaNota = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNoteTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(6, 112);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(1062, 430);
            this.txtPage.TabIndex = 6;
            this.txtPage.Text = "";
            // 
            // btnPaginaIndietro
            // 
            this.btnPaginaIndietro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaginaIndietro.Location = new System.Drawing.Point(797, 71);
            this.btnPaginaIndietro.Name = "btnPaginaIndietro";
            this.btnPaginaIndietro.Size = new System.Drawing.Size(128, 30);
            this.btnPaginaIndietro.TabIndex = 9;
            this.btnPaginaIndietro.Text = "Indietro";
            this.btnPaginaIndietro.UseVisualStyleBackColor = true;
            this.btnPaginaIndietro.Click += new System.EventHandler(this.btnPaginaIndietro_Click);
            // 
            // txtNoteTitle
            // 
            this.txtNoteTitle.Controls.Add(this.lblAuthor);
            this.txtNoteTitle.Controls.Add(this.btnElimina);
            this.txtNoteTitle.Controls.Add(this.lblPagina);
            this.txtNoteTitle.Controls.Add(this.btnAggiungi);
            this.txtNoteTitle.Controls.Add(this.btnPaginaAvanti);
            this.txtNoteTitle.Controls.Add(this.btnPaginaIndietro);
            this.txtNoteTitle.Controls.Add(this.txtPage);
            this.txtNoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoteTitle.ForeColor = System.Drawing.Color.Black;
            this.txtNoteTitle.Location = new System.Drawing.Point(7, 212);
            this.txtNoteTitle.Name = "txtNoteTitle";
            this.txtNoteTitle.Size = new System.Drawing.Size(1079, 548);
            this.txtNoteTitle.TabIndex = 10;
            this.txtNoteTitle.TabStop = false;
            this.txtNoteTitle.Text = "Note";
            // 
            // btnElimina
            // 
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.Location = new System.Drawing.Point(217, 72);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(152, 34);
            this.btnElimina.TabIndex = 14;
            this.btnElimina.Text = "Elimina Pagina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagina.Location = new System.Drawing.Point(796, 44);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(78, 24);
            this.lblPagina.TabIndex = 13;
            this.lblPagina.Text = "Pagina: ";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.Location = new System.Drawing.Point(6, 72);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(205, 34);
            this.btnAggiungi.TabIndex = 11;
            this.btnAggiungi.Text = "Aggiungi Pagina";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnPaginaAvanti
            // 
            this.btnPaginaAvanti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaginaAvanti.Location = new System.Drawing.Point(934, 72);
            this.btnPaginaAvanti.Name = "btnPaginaAvanti";
            this.btnPaginaAvanti.Size = new System.Drawing.Size(134, 32);
            this.btnPaginaAvanti.TabIndex = 10;
            this.btnPaginaAvanti.Text = "Avanti";
            this.btnPaginaAvanti.UseVisualStyleBackColor = true;
            this.btnPaginaAvanti.Click += new System.EventHandler(this.btnPaginaAvanti_Click);
            // 
            // btnNoteAvanti
            // 
            this.btnNoteAvanti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoteAvanti.Location = new System.Drawing.Point(941, 173);
            this.btnNoteAvanti.Name = "btnNoteAvanti";
            this.btnNoteAvanti.Size = new System.Drawing.Size(134, 33);
            this.btnNoteAvanti.TabIndex = 12;
            this.btnNoteAvanti.Text = "Avanti";
            this.btnNoteAvanti.UseVisualStyleBackColor = true;
            this.btnNoteAvanti.Click += new System.EventHandler(this.btnNoteAvanti_Click);
            // 
            // btnNoteIndietro
            // 
            this.btnNoteIndietro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoteIndietro.Location = new System.Drawing.Point(804, 173);
            this.btnNoteIndietro.Name = "btnNoteIndietro";
            this.btnNoteIndietro.Size = new System.Drawing.Size(131, 33);
            this.btnNoteIndietro.TabIndex = 11;
            this.btnNoteIndietro.Text = "Indietro";
            this.btnNoteIndietro.UseVisualStyleBackColor = true;
            this.btnNoteIndietro.Click += new System.EventHandler(this.btnNoteIndietro_Click);
            // 
            // btnAggiungiNote
            // 
            this.btnAggiungiNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungiNote.Location = new System.Drawing.Point(13, 173);
            this.btnAggiungiNote.Name = "btnAggiungiNote";
            this.btnAggiungiNote.Size = new System.Drawing.Size(205, 33);
            this.btnAggiungiNote.TabIndex = 13;
            this.btnAggiungiNote.Text = "Aggiungi Nota";
            this.btnAggiungiNote.UseVisualStyleBackColor = true;
            this.btnAggiungiNote.Click += new System.EventHandler(this.btnAggiungiNote_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(467, 170);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(168, 36);
            this.btnSalva.TabIndex = 14;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnEliminaNota
            // 
            this.btnEliminaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaNota.Location = new System.Drawing.Point(224, 173);
            this.btnEliminaNota.Name = "btnEliminaNota";
            this.btnEliminaNota.Size = new System.Drawing.Size(152, 33);
            this.btnEliminaNota.TabIndex = 15;
            this.btnEliminaNota.Text = "Elimina Nota";
            this.btnEliminaNota.UseVisualStyleBackColor = true;
            this.btnEliminaNota.Click += new System.EventHandler(this.btnEliminaNota_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 51);
            this.panel1.TabIndex = 16;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::NotesApp.Properties.Resources.minus_button;
            this.btnMinimize.Location = new System.Drawing.Point(1017, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 34);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimizeEvent);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::NotesApp.Properties.Resources.close;
            this.btnExit.Location = new System.Drawing.Point(1057, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 34);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExitEvent);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Location = new System.Drawing.Point(7, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 5);
            this.panel2.TabIndex = 8;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.BurlyWood;
            this.title.Cursor = System.Windows.Forms.Cursors.Default;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.PapayaWhip;
            this.title.Location = new System.Drawing.Point(8, 4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(128, 29);
            this.title.TabIndex = 7;
            this.title.Text = "NotesApp";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(6, 32);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(66, 24);
            this.lblAuthor.TabIndex = 15;
            this.lblAuthor.Text = "Author";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(17, 57);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(110, 25);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "Username";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(17, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(110, 25);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Username";
            // 
            // FrmHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1098, 772);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminaNota);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnAggiungiNote);
            this.Controls.Add(this.btnNoteAvanti);
            this.Controls.Add(this.btnNoteIndietro);
            this.Controls.Add(this.txtNoteTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHub";
            this.Load += new System.EventHandler(this.FrmHub_Load);
            this.txtNoteTitle.ResumeLayout(false);
            this.txtNoteTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtPage;
        private System.Windows.Forms.Button btnPaginaIndietro;
        private System.Windows.Forms.GroupBox txtNoteTitle;
        private System.Windows.Forms.Button btnPaginaAvanti;
        private System.Windows.Forms.Button btnNoteAvanti;
        private System.Windows.Forms.Button btnNoteIndietro;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnAggiungiNote;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnEliminaNota;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
    }
}