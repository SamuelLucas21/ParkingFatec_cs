namespace ParkingFatec.View
{
    partial class CadastroView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroView));
            icnFundo = new PictureBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnVoltar = new Util.BtnRedondo();
            btnCadastrar = new Util.BtnRedondo();
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
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(204, 203, 205);
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.FromArgb(64, 64, 64);
            txtNome.Location = new Point(688, 219);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Digite seu nome...";
            txtNome.Size = new Size(430, 28);
            txtNome.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(204, 203, 205);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(688, 347);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite seu e-mail...";
            txtEmail.Size = new Size(430, 28);
            txtEmail.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(204, 203, 205);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.FromArgb(64, 64, 64);
            txtSenha.Location = new Point(688, 475);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite sua senha...";
            txtSenha.Size = new Size(430, 28);
            txtSenha.TabIndex = 4;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(73, 92, 102);
            btnVoltar.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnVoltar.BorderColor = Color.White;
            btnVoltar.BorderRadius = 30;
            btnVoltar.BorderSize = 3;
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(688, 588);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(176, 55);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextColor = Color.White;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            btnVoltar.MouseClick += btnVoltar_MouseClick;
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
            btnCadastrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(932, 588);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(176, 55);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar-se";
            btnCadastrar.TextColor = Color.White;
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.MouseClick += btnCadastrar_MouseClick;
            // 
            // icnOlho
            // 
            icnOlho.BackColor = Color.FromArgb(73, 92, 102);
            icnOlho.Cursor = Cursors.Hand;
            icnOlho.Image = (Image)resources.GetObject("icnOlho.Image");
            icnOlho.Location = new Point(1147, 473);
            icnOlho.Name = "icnOlho";
            icnOlho.Size = new Size(34, 34);
            icnOlho.TabIndex = 7;
            icnOlho.TabStop = false;
            icnOlho.MouseClick += icnOlho_MouseClick;
            // 
            // icnOlhoOff
            // 
            icnOlhoOff.BackColor = Color.FromArgb(73, 92, 102);
            icnOlhoOff.Cursor = Cursors.Hand;
            icnOlhoOff.Image = (Image)resources.GetObject("icnOlhoOff.Image");
            icnOlhoOff.Location = new Point(1147, 473);
            icnOlhoOff.Name = "icnOlhoOff";
            icnOlhoOff.Size = new Size(34, 34);
            icnOlhoOff.TabIndex = 8;
            icnOlhoOff.TabStop = false;
            icnOlhoOff.MouseClick += icnOlhoOff_MouseClick;
            // 
            // CadastroView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(icnOlhoOff);
            Controls.Add(icnOlho);
            Controls.Add(btnCadastrar);
            Controls.Add(btnVoltar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(icnFundo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CadastroView";
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
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Util.BtnRedondo btnVoltar;
        private Util.BtnRedondo btnCadastrar;
        private PictureBox icnOlho;
        private PictureBox icnOlhoOff;
    }
}