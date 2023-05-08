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

namespace Grupo4TPWinform
{
    public partial class frmAlta : Form
    {
        private Articulo articulo = null;
        public frmAlta()
        {
            InitializeComponent();
        }

        public frmAlta(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
         //   Articulo art = new Articulo();
              ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if(articulo == null)
                {
                    Articulo articulo = new Articulo();
                }
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;               
                articulo.Precio = int.Parse(txtPrecio.Text);
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Marca = (Marca)cboMarca.SelectedItem;


                if(articulo.idArt != 0)
                {
                    negocio.modificarArticulo(articulo);
                    MessageBox.Show("Modificado exitosamente.");
                }
                else
                {
                     negocio.altaArticulo(articulo);
                     MessageBox.Show("Agregado exitosamente.");
                }
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAlta_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                cboMarca.DataSource = marca.listarMarcas();
                cboMarca.ValueMember = "id";
                cboMarca.DisplayMember = "Descripcion";

                cboCategoria.DataSource = negocio.listarCategorias();
                cboCategoria.ValueMember = "idCategoria";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text= articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cboCategoria.SelectedValue = articulo.Categoria.iDCategoria;
                    cboMarca.SelectedValue = articulo.Marca.id;
                   // cargarImagen(articulo.url.ToString());

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
