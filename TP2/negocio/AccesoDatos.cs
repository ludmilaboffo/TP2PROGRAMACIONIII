﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //para conectarse a la base de datos

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion; //para conectarse a la base de datos
        private SqlCommand comando; //para ejecutar comandos sql
        private SqlDataReader lector; //para leer datos de la base de datos
        public SqlDataReader Lector //propiedad para devolver el lector
        {
            get { return lector; }
        }

        public AccesoDatos() //constructor
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            comando = new SqlCommand(); 
        }

        public void setearConsulta(string consulta)
        {
          comando.CommandType = System.Data.CommandType.Text;
          comando.CommandText = consulta; 
        }
        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ejecutarAccion() //para insert, update y delete
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cerrarConexion()
        {
            if(lector != null)
                lector.Close();
            conexion.Close();
        }

    }
}
