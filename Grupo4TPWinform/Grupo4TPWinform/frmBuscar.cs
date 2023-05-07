using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Data.SqlClient;


namespace Grupo4TPWinform
{
    public partial class frmBuscar : Form
    {
        private List<Articulo> listaArticulos;
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Categoria");
        }
        private void cargar()
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvListarBusqueda.DataSource = listaArticulos;
                //cargarImagen(listaArticulo[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbBuscarMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if(opcion== "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Igual a");
                cboCriterio.Items.Add("Menor a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void gpbBuscar_Enter(object sender, EventArgs e)
        {

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio art = new ArticuloNegocio();
            try
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvListarBusqueda.DataSource = art.filtar(campo,criterio, filtro);


            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        private void dgvListarBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
