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
    public partial class InicioView : Form
    {
        private static int id =0;
        public InicioView(int id)
        {
            InitializeComponent();
            panelFuncionario.Visible = false;
            panelCadastrar.Visible = false;
            panelConsultar.Visible = false;

        }

        private void btnFuncionario_MouseClick(object sender, MouseEventArgs e)
        {
            //clica a panel aparece e se clicar de novo a panel desaparece
            panelFuncionario.Visible = !panelFuncionario.Visible;
            panelCadastrar.Visible = false;
            panelConsultar.Visible = false;
        }

        private void btnCadastros_MouseClick(object sender, MouseEventArgs e)
        {
            panelCadastrar.Visible = !panelCadastrar.Visible;
            panelFuncionario.Visible = false;
            panelConsultar.Visible = false;
        }

        private void btnConsultar_MouseClick(object sender, MouseEventArgs e)
        {
            panelConsultar.Visible = !panelConsultar.Visible;
            panelCadastrar.Visible = false;
            panelFuncionario.Visible = false;
        }

        private void btnEntradas_MouseClick(object sender, MouseEventArgs e)
        {
            panelFuncionario.Visible = false;
            panelCadastrar.Visible = false;
            panelConsultar.Visible = false;
        }

        private void btnSaidas_MouseClick(object sender, MouseEventArgs e)
        {
            panelFuncionario.Visible = false;
            panelCadastrar.Visible = false;
            panelConsultar.Visible = false;
        }

        private void btnLogout_MouseClick(object sender, MouseEventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            this.Close();
        }
    }
}
