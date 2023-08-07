using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class CD_Usuarios
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarEmpleados()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable Mostrarclientes()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarCli";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsertUsuario(string nombre, string apellido,string numero, string contraseña, string nivel)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Insert into Usuarios values ('"+nombre+"','"+apellido+"','"+numero+"','"+contraseña+"', '"+nivel+"')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        } 

        public void EditarUsuario(string nombre, string apellido, string numero, string contraseña, string nivel, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UpDate Usuarios set nombre ='"+nombre+"', apellido='"+apellido+"',numero='"+numero+"', contraseña='"+contraseña+"' where idCliente ="+id+"";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
        public void EliminarUsuario(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from Usuarios where idCliente ='"+id+"'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
    }

    
}
