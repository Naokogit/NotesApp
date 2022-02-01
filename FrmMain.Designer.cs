namespace NotesApp
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.BtnShowLogin = new System.Windows.Forms.Button();
            this.BtnShowRegister = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 46);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::NotesApp.Properties.Resources.minus_button;
            this.btnMinimize.Location = new System.Drawing.Point(314, 7);
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
            this.btnExit.Location = new System.Drawing.Point(354, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 34);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExitEvent);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::NotesApp.Properties.Resources.books;
            this.pictureBox1.Location = new System.Drawing.Point(107, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Tan;
            this.title.Cursor = System.Windows.Forms.Cursors.Default;
            this.title.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.PapayaWhip;
            this.title.Location = new System.Drawing.Point(120, 180);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(158, 37);
            this.title.TabIndex = 2;
            this.title.Text = "NotesApp";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnShowLogin
            // 
            this.BtnShowLogin.BackColor = System.Drawing.Color.Tan;
            this.BtnShowLogin.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.BtnShowLogin.FlatAppearance.BorderSize = 3;
            this.BtnShowLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowLogin.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowLogin.ForeColor = System.Drawing.Color.Peru;
            this.BtnShowLogin.Location = new System.Drawing.Point(66, 364);
            this.BtnShowLogin.Name = "BtnShowLogin";
            this.BtnShowLogin.Size = new System.Drawing.Size(258, 62);
            this.BtnShowLogin.TabIndex = 3;
            this.BtnShowLogin.Text = "Accedi";
            this.BtnShowLogin.UseVisualStyleBackColor = false;
            this.BtnShowLogin.Click += new System.EventHandler(this.BtnShowLogin_Click);
            // 
            // BtnShowRegister
            // 
            this.BtnShowRegister.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.BtnShowRegister.FlatAppearance.BorderSize = 3;
            this.BtnShowRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowRegister.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowRegister.ForeColor = System.Drawing.Color.Peru;
            this.BtnShowRegister.Location = new System.Drawing.Point(66, 432);
            this.BtnShowRegister.Name = "BtnShowRegister";
            this.BtnShowRegister.Size = new System.Drawing.Size(258, 62);
            this.BtnShowRegister.TabIndex = 4;
            this.BtnShowRegister.Text = "Registrati";
            this.BtnShowRegister.UseVisualStyleBackColor = true;
            this.BtnShowRegister.Click += new System.EventHandler(this.BtnShowRegister_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Location = new System.Drawing.Point(127, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 5);
            this.panel2.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(389, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnShowRegister);
            this.Controls.Add(this.BtnShowLogin);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button BtnShowLogin;
        private System.Windows.Forms.Button BtnShowRegister;
        private System.Windows.Forms.Panel panel2;
    }
}

