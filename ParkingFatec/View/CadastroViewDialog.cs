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
    public partial class CadastroViewDialog : Form
    {
        private CadastroView o;
        public CadastroViewDialog(CadastroView i)
        {
            this.o = i;
            InitializeComponent();
        }

        private void btnOK_MouseClick(object sender, MouseEventArgs e)
        {
            this.o.Close();
            new LoginView().ShowDialog();
            this.Close();
        }
    }
}
