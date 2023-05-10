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
using System.Security.AccessControl;
using System.Collections;

namespace Grupo4TPWinform
{
    public partial class frmBuscar : Form
    {
        private List<Articulo> listaArticulos;
        public frmBuscar()
        {
            InitializeComponent();
            Text = "Buscando articulos";
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            cargar();
            dgvListarBusqueda.DefaultCellStyle.ForeColor = Color.Black;
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
                dgvListarBusqueda.DataSource = null;
                dgvListarBusqueda.DataSource = listaArticulos;
                dgvListarBusqueda.Columns["idArt"].Visible = false;
                dgvListarBusqueda.Columns["url"].Visible = false;
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

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("No se puede buscar sin cargar datos al filtro primero.");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("El ingreso solo permite datos numericos.");
                    return true;
                }

            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio art = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return; // me corta la ejecucion del evento

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                listaArticulos = art.filtar(campo, criterio, filtro);
                dgvListarBusqueda.Columns.Clear();
                dgvListarBusqueda.AutoResizeColumns();
                dgvListarBusqueda.DataSource = listaArticulos;
                dgvListarBusqueda.Columns["idArt"].Visible = false;
                dgvListarBusqueda.Columns["url"].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}
