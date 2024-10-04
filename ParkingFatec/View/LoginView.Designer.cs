namespace ParkingFatec
{
    partial class LoginView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            icnFundo = new PictureBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Util.BtnRedondo();
            btnCadastrar = new Util.BtnRedondo();
            lnkEsqueceuSenha = new LinkLabel();
            icnOlho = new PictureBox();
            icnOlhoOff = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)icnFundo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icnOlho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icnOlhoOff).BeginInit();
            SuspendLayout();
            // 
            // icnFundo
            // 
            icnFundo.Image = (Image)resources.GetObject("icnFundo.Image");
            icnFundo.Location = new Point(0, 0);
            icnFundo.Name = "icnFundo";
            icnFundo.Size = new Size(1280, 720);
            icnFundo.TabIndex = 0;
            icnFundo.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(204, 203, 205);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(681, 220);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite seu e-mail...";
            txtEmail.Size = new Size(430, 28);
            txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(204, 203, 205);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.FromArgb(64, 64, 64);
            txtSenha.Location = new Point(681, 346);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite sua senha...";
            txtSenha.Size = new Size(430, 28);
            txtSenha.TabIndex = 2;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(73, 92, 102);
            btnEntrar.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnEntrar.BorderColor = Color.White;
            btnEntrar.BorderRadius = 30;
            btnEntrar.BorderSize = 3;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(811, 443);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(176, 55);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.TextColor = Color.White;
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.MouseClick += btnEntrar_MouseClick;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(73, 92, 102);
            btnCadastrar.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnCadastrar.BorderColor = Color.White;
            btnCadastrar.BorderRadius = 30;
            btnCadastrar.BorderSize = 3;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(893, 585);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(310, 63);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar-se";
            btnCadastrar.TextColor = Color.White;
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.MouseClick += btnCadastrar_MouseClick;
            // 
            // lnkEsqueceuSenha
            // 
            lnkEsqueceuSenha.ActiveLinkColor = SystemColors.ButtonHighlight;
            lnkEsqueceuSenha.AutoSize = true;
            lnkEsqueceuSenha.BackColor = Color.FromArgb(73, 92, 102);
            lnkEsqueceuSenha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lnkEsqueceuSenha.LinkColor = SystemColors.ButtonFace;
            lnkEsqueceuSenha.Location = new Point(970, 391);
            lnkEsqueceuSenha.Name = "lnkEsqueceuSenha";
            lnkEsqueceuSenha.Size = new Size(141, 21);
            lnkEsqueceuSenha.TabIndex = 5;
            lnkEsqueceuSenha.TabStop = true;
            lnkEsqueceuSenha.Text = "Esqueceu a senha?";
            lnkEsqueceuSenha.LinkClicked += lnkEsqueceuSenha_LinkClicked;
            // 
            // icnOlho
            // 
            icnOlho.BackColor = Color.FromArgb(73, 92, 102);
            icnOlho.Cursor = Cursors.Hand;
            icnOlho.Image = (Image)resources.GetObject("icnOlho.Image");
            icnOlho.Location = new Point(1139, 344);
            icnOlho.Name = "icnOlho";
            icnOlho.Size = new Size(34, 34);
            icnOlho.TabIndex = 6;
            icnOlho.TabStop = false;
            icnOlho.MouseClick += icnOlho_MouseClick;
            // 
            // icnOlhoOff
            // 
            icnOlhoOff.BackColor = Color.FromArgb(73, 92, 102);
            icnOlhoOff.Cursor = Cursors.Hand;
            icnOlhoOff.Image = (Image)resources.GetObject("icnOlhoOff.Image");
            icnOlhoOff.Location = new Point(1139, 344);
            icnOlhoOff.Name = "icnOlhoOff";
            icnOlhoOff.Size = new Size(34, 34);
            icnOlhoOff.TabIndex = 7;
            icnOlhoOff.TabStop = false;
            icnOlhoOff.MouseClick += icnOlhoOff_MouseClick;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(icnOlhoOff);
            Controls.Add(icnOlho);
            Controls.Add(lnkEsqueceuSenha);
            Controls.Add(btnCadastrar);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(icnFundo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parking Fatec";
            ((System.ComponentModel.ISupportInitialize)icnFundo).EndInit();
            ((System.ComponentModel.ISupportInitialize)icnOlho).EndInit();
            ((System.ComponentModel.ISupportInitialize)icnOlhoOff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox icnFundo;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Util.BtnRedondo btnEntrar;
        private Util.BtnRedondo btnCadastrar;
        private LinkLabel lnkEsqueceuSenha;
        private PictureBox icnOlho;
        private PictureBox icnOlhoOff;
    }
}
