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

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListar ventanaListar = new frmListar();
            ventanaListar.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscar ventanaBuscar = new frmBuscar();
            ventanaBuscar.Show();
        }

        private void agregarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlta ventanaAgregar = new frmAlta();
            ventanaAgregar.ShowDialog();
        }
        private void eliminarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminar ventanaEliminar = new frmEliminar();
            ventanaEliminar.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
