namespace ParkingFatec.View
{
    partial class EsqueceuSenhaViewDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsqueceuSenhaViewDialog));
            icnFundo = new PictureBox();
            btnOK = new Util.BtnRedondo();
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
            // btnOK
            // 
            btnOK.BackColor = Color.FromArgb(73, 92, 102);
            btnOK.BackgroundColor = Color.FromArgb(73, 92, 102);
            btnOK.BorderColor = Color.White;
            btnOK.BorderRadius = 15;
            btnOK.BorderSize = 2;
            btnOK.Cursor = Cursors.Hand;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(148, 208);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(89, 28);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.TextColor = Color.White;
            btnOK.UseVisualStyleBackColor = false;
            btnOK.MouseClick += btnOK_MouseClick;
            // 
            // EsqueceuSenhaViewDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 300);
            ControlBox = false;
            Controls.Add(btnOK);
            Controls.Add(icnFundo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "EsqueceuSenhaViewDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E-mail enviado";
            ((System.ComponentModel.ISupportInitialize)icnFundo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox icnFundo;
        private Util.BtnRedondo btnOK;
    }
}