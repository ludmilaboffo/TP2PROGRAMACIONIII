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
                // datos.setearConsulta("Select A.Id, Codigo, Nombre, A.Descripcion, Precio, A.idCategoria, A.idMarca, C.Descripcion CATEGORIA , I.Id, IdArticulo, ImagenUrl Imagen, M.Descripcion Marca From ARTICULOS A, CATEGORIAS C, MARCAS M, IMAGENES I Where C.Id = A.IdCategoria AND M.id = A.idMarca AND idArticulo = A.id");
                datos.setearConsulta("Select A.Id, Codigo, Nombre, A.Descripcion, Precio, A.idCategoria, A.idMarca, C.Descripcion CATEGORIA, M.Descripcion Marca From ARTICULOS A, CATEGORIAS C, MARCAS M, Where C.Id = A.IdCategoria AND M.id = A.idMarca");
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    if (!(datos.Lector["Id"] is DBNull))
                        aux.idArt = (int)datos.Lector["Id"];
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
                        aux.Categoria.iDCategoria = (int)datos.Lector["idCategoria"];
                    if (!(datos.Lector["Marca"] is DBNull))
                        aux.Marca = new Marca();
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                        aux.Marca.id = (int)datos.Lector["idMarca"];
                 //   if (!(datos.Lector["Imagen"] is DBNull))
                   //     aux.url = new Imagen();
                     //   aux.url.ImagenUrl = (string)datos.Lector["Imagen"];

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

        public void altaArticulo(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into ARTICULOS(Codigo, Nombre, Descripcion, Precio, idCategoria, idMarca) values ('"+ nuevo.Codigo + "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', '" + nuevo.Precio+"', @idCategoria, @idMarca)");
           //     datos.setearConsulta("Insert into IMAGENES(IdArticulo, ImagenUrl) values (@idArticuloImagen,"+ "'@urlImagen'");
                datos.setearParametro("@idCategoria", nuevo.Categoria.iDCategoria);
                datos.setearParametro("@idMarca", nuevo.Marca.id);
       
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

        public void modificarArticulo(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Articulos set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, Precio = @precio  where Id = @id");
                datos.setearParametro("@codigo",articulo.Codigo);
                datos.setearParametro("@nombre",articulo.Nombre);
                datos.setearParametro("@descripcion",articulo.Descripcion);
                datos.setearParametro("@idMarca",articulo.Marca.id);
                datos.setearParametro("@idCategoria",articulo.Categoria.iDCategoria);
                datos.setearParametro("@precio",articulo.Precio);
                datos.setearParametro("@id",articulo.idArt);

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


        public List<Articulo> filtar(string campo, string criterio, string filtro)
        {
            List<Articulo> listaArt = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select A.id, Codigo, Nombre, A.Descripcion, Precio, C.Descripcion CATEGORIA, M.Descripcion Marca, ImagenUrl IMAGEN From ARTICULOS A, CATEGORIAS C, MARCAS M, IMAGENES I Where C.Id = A.IdCategoria AND M.id = A.idMarca AND I.IdArticulo = A.Id AND ";

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
                    if (!(datos.Lector["Id"] is DBNull))
                        aux.idArt = (int)datos.Lector["idArt"];
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

        public void eliminarArticulo(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
