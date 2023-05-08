using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo4TPWinform
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void tsmBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar ventanaBuscar = new frmBuscar();
            ventanaBuscar.ShowDialog();
        }

        private void tsmListarArts_Click(object sender, EventArgs e)
        {
            frmListar ventanaListar = new frmListar();
            ventanaListar.ShowDialog();
        }
    }
}
