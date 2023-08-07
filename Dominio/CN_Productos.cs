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
    public class CN_Productos:CD_Productos
    {
        private int id;
        private string nombre;
        private decimal precio;
        private string descripcion;
        private int cantidad;
        private byte[] imagen;
        public Valores estado;
        

        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public decimal Precio { get { return precio; } set { precio = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public byte[] Imagen { get { return imagen; } set { imagen = value; } }

        public CN_Productos()
        {
            id = Id;
            nombre = Nombre;
            precio = Precio;
            descripcion = Descripcion;
            cantidad = Cantidad;
            imagen = Imagen;
        }

        private void GuardarProducto()
        {
            string transact = "insert into Productos values(@nombre, @precio, @descripcion, @cantidad, @imagen)";
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@nombre", nombre));
            parametros.Add(new SqlParameter("@precio", precio));
            parametros.Add(new SqlParameter("@descripcion", descripcion));
            parametros.Add(new SqlParameter("@cantidad", cantidad));
            parametros.Add(new SqlParameter("@imagen", imagen));
            ExecuteNonQuery(transact);
        }
        private void EditarProducto()
        {
            string transact = "update Productos set nombre = @nombre, precio = @precio, descripcion = @descripcion, cantidad = @cantidad, imagen = @imagen where idProducto = @id";
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id", id));
            parametros.Add(new SqlParameter("@nombre", nombre));
            parametros.Add(new SqlParameter("@precio", precio));
            parametros.Add(new SqlParameter("@descripcion", descripcion));
            parametros.Add(new SqlParameter("@cantidad", cantidad));
            parametros.Add(new SqlParameter("@imagen", imagen));
            ExecuteNonQuery(transact);
        }
        private void EliminarProducto()
        {
            string transact = "delete from Productos where idProducto = @id";
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id", id));
            ExecuteNonQuery(transact);
        }
        public DataTable VerProductos()
        {
            string transact = "select * from Productos";
            return ExecuteReader(transact);
        }

        public string GuardarCambios()
        {
            string mensaje = null;
            try
            {
                switch (estado)
                {
                    case Valores.Agregar:
                        GuardarProducto();
                        mensaje = "Agregado con éxito";
                        break;
                    case Valores.Editar:
                        EditarProducto();
                        mensaje = "Editado con éxito";
                        break;
                    case Valores.Eliminar:
                        EliminarProducto();
                        mensaje = "Eliminado con éxito";
                        break;
                }
            }
            catch (Exception error)
            {
                mensaje = error.ToString();
            }
            return mensaje;
        }

        public void BajarCantidad(int idCarrito, int cantidadCarrito)
        {
            string transact = "update Productos set cantidad = cantidad - @cantidad where idProducto = @id";
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id", idCarrito));
            parametros.Add(new SqlParameter("@cantidad", cantidadCarrito));
            ExecuteNonQuery(transact);
        }
    }
}
