﻿using System;
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
using System.IO;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;

namespace Grupo4TPWinform
{

    public partial class frmAlta : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
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
              ImagenNegocio imgNeg = new ImagenNegocio();  
              Imagen img = new Imagen();
            try
            {
                if(articulo == null)                
                articulo = new Articulo();
                
                
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;               
                articulo.Precio = decimal.Parse(txtPrecio.Text);
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
                    int idArticulo = obtenerID(articulo); 
                    img.idArticulo = idArticulo;
                    img.ImagenUrl = txtURL.Text;
                    imgNeg.altaImagen(img);
                    MessageBox.Show("Carga exitosa");                  
                }
                Close();

                if (archivo!=null)
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Images-folder"] + archivo.SafeFileName);      
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public int obtenerID(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            int id;

            try
            {
                datos.setearConsulta("SELECT @@IDENTITY AS IdArticulo");
                id = Convert.ToInt32(datos.ejecutarEscalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return id;
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
                    txtURL.Text = articulo.url.ImagenUrl;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /*
            private void btnAgregarImg_Click(object sender, EventArgs e)
            {
                OpenFileDialog archivo = new OpenFileDialog();
                archivo.Filter = "jpg|*.jpg;|png|*.png";
                if (archivo.ShowDialog() == DialogResult.OK )
                {
                    txtImagen.Text = archivo.FileName;
                    cargarImagen(archivo.FileName);
                }
            }

            private void txtImagen_Leave(object sender, EventArgs e)
            {
                cargarImagen(txtImagen.Text);
            }
        */
    }
}
