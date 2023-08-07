using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataAccess;

namespace Dominio
{
    public class CN_Usuarios
    {
        private CD_Usuarios objetoCD = new CD_Usuarios();
        public DataTable MostrarUsu()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrarclientes();
            return tabla;

        }
        public DataTable MostrarEmple()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarEmpleados();
            return tabla;

        }
        public void InsertarUser (string nombre, string apellido, string numero, string contraseña, string nivel) {
            objetoCD.InsertUsuario(nombre, apellido, numero, contraseña, nivel);
        
        }
        public void EditarUser(string nombre, string apellido, string numero, string contraseña, string nivel, string id)
        {
            objetoCD.EditarUsuario(nombre, apellido, numero, contraseña, nivel, Convert.ToInt32(id));
        }

        public void EliminarUser(string id)
        {
            objetoCD.EliminarUsuario(Convert.ToInt32(id));
        }

      
    }
}
