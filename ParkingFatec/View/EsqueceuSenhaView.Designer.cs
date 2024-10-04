namespace ParkingFatec.View
{
    partial class EsqueceuSenhaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsqueceuSenhaView));
            icnFundo = new PictureBox();
            btnEnviarEmail = new Util.BtnRedondo();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)icnFundo).BeginInit();
            SuspendLayout();
            // 
            // icnFundo
            // 
            icnFundo.Image = (Image)resources.GetObject("icnFundo.Image");
            icnFundo.Location = new Point(0, 0);
            icnFundo.Name = "icnFundo";
            icnFundo.Size = new Size(400, 300);
            icnFundo.TabIndex = 0;
            icnFundo.TabStop = false;
            // 
            // btnEnviarEmail
            // 
            btnEnviarEmail.BackColor = Color.FromArgb(73, 92, 102);
            btnEnviarEmail.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnEnviarEmail.BorderColor = Color.White;
            btnEnviarEmail.BorderRadius = 15;
            btnEnviarEmail.BorderSize = 2;
            btnEnviarEmail.Cursor = Cursors.Hand;
            btnEnviarEmail.FlatAppearance.BorderSize = 0;
            btnEnviarEmail.FlatStyle = FlatStyle.Flat;
            btnEnviarEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviarEmail.ForeColor = Color.White;
            btnEnviarEmail.Location = new Point(136, 185);
            btnEnviarEmail.Name = "btnEnviarEmail";
            btnEnviarEmail.Size = new Size(115, 28);
            btnEnviarEmail.TabIndex = 1;
            btnEnviarEmail.Text = "Enviar e-mail";
            btnEnviarEmail.TextColor = Color.White;
            btnEnviarEmail.UseVisualStyleBackColor = false;
            btnEnviarEmail.MouseClick += btnEnviarEmail_MouseClick;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(241, 239, 246);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(54, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Digite seu e-mail...";
            txtEmail.Size = new Size(291, 22);
            txtEmail.TabIndex = 2;
            // 
            // EsqueceuSenhaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 300);
            Controls.Add(txtEmail);
            Controls.Add(btnEnviarEmail);
            Controls.Add(icnFundo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EsqueceuSenhaView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Esqueceu a Senha";
            ((System.ComponentModel.ISupportInitialize)icnFundo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox icnFundo;
        private Util.BtnRedondo btnEnviarEmail;
        private TextBox txtEmail;
    }
}