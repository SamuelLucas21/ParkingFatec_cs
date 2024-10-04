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
    public partial class EsqueceuSenhaViewDialog : Form
    {
        public EsqueceuSenhaViewDialog()
        {
            InitializeComponent();
        }

        private void btnOK_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
