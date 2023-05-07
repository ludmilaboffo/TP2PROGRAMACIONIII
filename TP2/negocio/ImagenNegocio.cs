﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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

    }
}
