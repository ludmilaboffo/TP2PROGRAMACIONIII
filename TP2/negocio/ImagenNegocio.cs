using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ImagenNegocio
    {

        public List<Imagen> listarImagenes()
        {

            List<Imagen> listaImg = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("Select id, IdArticulo, ImagenUrl from IMAGENES");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen img = new Imagen();
                    img.idArticulo = (int)datos.Lector["IdArticulo"];
                    img.idImagen = (int)datos.Lector["id"];
                    img.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    listaImg.Add(img);
                }
                return listaImg;
            }


            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                datos.cerrarConexion();
            }


        }



        public void altaImagen( Imagen img)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into IMAGENES (IdArticulo, ImagenUrl) values ( " + img.idArticulo + ",'" + img.ImagenUrl + "')");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}