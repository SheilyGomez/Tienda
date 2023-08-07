using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public abstract class CD_Productos
    {
        private readonly string CadenaConexion;
        protected List<SqlParameter> parametros;

        public CD_Productos()
        {
            CadenaConexion = "Server=LAPTOP-2RS2E00C\\GOMEZ;DataBase=Proyecto;integrated security=true";
        }

        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }

        //Ejecutar sentencias insert, update y delete
        protected void ExecuteNonQuery(string transact)
        {
            using(var conexion = ObtenerConexion())
            {
                conexion.Open();
                using(var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transact;
                    comando.CommandType = CommandType.Text;
                    foreach(SqlParameter item in parametros)
                    {
                        comando.Parameters.Add(item);
                    }
                    comando.ExecuteNonQuery();
                    parametros.Clear();
                }
            }
        }

        //Ejecutar consultas que regresan una tabla
        protected DataTable ExecuteReader(string transact)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using(var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transact;
                    comando.CommandType = CommandType.Text;
                    SqlDataReader lector = comando.ExecuteReader();
                    using(var tabla = new DataTable())
                    {
                        tabla.Load(lector);
                        lector.Dispose();
                        return tabla;
                    }
                }
            }
        }
    }    
     
}
