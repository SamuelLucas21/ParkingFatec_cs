using ParkingFatec.Body;
using ParkingFatec.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingFatec.View
{
    public partial class CadastroView : Form
    {
        public CadastroView()
        {
            InitializeComponent();
            icnOlhoOff.Visible = false;
            txtSenha.UseSystemPasswordChar = true;
        }

        private void icnOlho_MouseClick(object sender, MouseEventArgs e)
        {
            icnOlho.Visible = false;
            icnOlhoOff.Visible = true;
            txtSenha.UseSystemPasswordChar = false;
        }

        private void icnOlhoOff_MouseClick(object sender, MouseEventArgs e)
        {
            icnOlho.Visible = true;
            icnOlhoOff.Visible = false;
            txtSenha.UseSystemPasswordChar = true;
        }

        private void btnVoltar_MouseClick(object sender, MouseEventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            this.Close();
        }

        private void btnCadastrar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEmail.TextLength == 0 || txtNome.TextLength == 0 || txtSenha.TextLength == 0)
            {
                CampoVazioViewDialog campoVazioViewDialog = new CampoVazioViewDialog();
                campoVazioViewDialog.ShowDialog();
            }
            else
            {
                if (!ConnectToDataBase.checkUser(this.txtEmail.Text, this.txtSenha.Text))
                {
                    User user = new User();
                    user.setName(this.txtNome.Text);
                    user.setEmail(this.txtEmail.Text);
                    user.setPassword(this.txtSenha.Text);
                    ConnectToDataBase.insertUser(user, this);
                }
                else
                {
                    MessageBox.Show("Usuário já existe!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
