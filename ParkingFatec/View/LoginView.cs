using ParkingFatec.DataBase;
using ParkingFatec.View;

namespace ParkingFatec
{
    public partial class LoginView : Form
    {
        Thread login;
        public LoginView()
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
            icnOlhoOff.Visible = false;
            icnOlho.Visible = true;
            txtSenha.UseSystemPasswordChar = true;
        }

        private void btnCadastrar_MouseClick(object sender, MouseEventArgs e)
        {
            CadastroView cadastroView = new CadastroView();
            cadastroView.Show();
            this.Hide();
        }

        private void lnkEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EsqueceuSenhaView esqueceuSenhaView = new EsqueceuSenhaView();
            esqueceuSenhaView.ShowDialog();
        }

        private void btnEntrar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEmail.TextLength == 0 || txtSenha.TextLength == 0)
            {
                CampoVazioViewDialog campoVazioViewDialog = new CampoVazioViewDialog();
                campoVazioViewDialog.ShowDialog();
            }
            else
            {
                if (ConnectToDataBase.checkUser(this.txtEmail.Text, this.txtSenha.Text))
                {
                    new InicioView(ConnectToDataBase.checkUser(this.txtEmail.Text)).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado", "Aviso!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

    }
}