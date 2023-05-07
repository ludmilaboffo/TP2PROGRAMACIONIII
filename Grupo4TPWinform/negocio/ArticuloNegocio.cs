﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Xml.Linq;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar() 
        {
            List<Articulo> lista = new List<Articulo>(); 
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Codigo, Nombre, A.Descripcion, Precio, C.Descripcion CATEGORIA , M.Descripcion Marca, ImagenUrl IMAGEN  From ARTICULOS A, CATEGORIAS C, MARCAS M, IMAGENES I Where C.Id = A.IdCategoria AND M.id = A.idMarca AND I.IdArticulo = A.Id");
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    if (!(datos.Lector["Codigo"] is DBNull))
                         aux.Codigo = (string)datos.Lector["Codigo"];

                    if(!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];
                    if(!(datos.Lector["Codigo"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if(!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["Precio"];
                    if (!(datos.Lector["CATEGORIA"] is DBNull))
                        aux.Categoria = new Categoria();
                        aux.Categoria.Descripcion = (string)datos.Lector["CATEGORIA"];
                    if (!(datos.Lector["Marca"] is DBNull))
                        aux.Marca = new Marca();
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    lista.Add(aux);
                }
                return lista;
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


      
        public List<Articulo> filtar(string campo, string criterio, string filtro)
        {
            List<Articulo> listaArt = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select Codigo, Nombre, A.Descripcion, Precio, C.Descripcion CATEGORIA, M.Descripcion Marca, ImagenUrl IMAGEN From ARTICULOS A, CATEGORIAS C, MARCAS M, IMAGENES I Where C.Id = A.IdCategoria AND M.id = A.idMarca AND I.IdArticulo = A.Id AND ";

                if (campo == "Codigo")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Codigo like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "Codigo like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Codigo like '%" + filtro + "%'";
                            break;
                    }
                }
                else if(campo== "Marca")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "M.Descripcion like '" + filtro + "%'";
                            break;
                        case "Termina con":
                             consulta += "M.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                             consulta += "M.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Categoria")
                {
                                
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "C.DescripcioN like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "C.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "C.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "Precio < " + filtro;
                            break;
                        default:
                            consulta += "Precio ="+ filtro;
                            break;
                    }
                }
            
                
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    if (!(datos.Lector["Codigo"] is DBNull))
                        aux.Codigo = (string)datos.Lector["Codigo"];
                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Codigo"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["Precio"];
                    if (!(datos.Lector["CATEGORIA"] is DBNull))
                        aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["CATEGORIA"];
                    if (!(datos.Lector["Marca"] is DBNull))
                        aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    listaArt.Add(aux);
                }
                return listaArt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
