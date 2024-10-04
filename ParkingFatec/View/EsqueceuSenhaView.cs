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
    public partial class EsqueceuSenhaView : Form
    {
        public EsqueceuSenhaView()
        {
            InitializeComponent();
        }

        private void btnEnviarEmail_MouseClick(object sender, MouseEventArgs e)
        {
            EsqueceuSenhaViewDialog esqueceuSenhaViewDialog = new EsqueceuSenhaViewDialog();
            esqueceuSenhaViewDialog.ShowDialog(this);
            this.Close();
        }
    }
}
