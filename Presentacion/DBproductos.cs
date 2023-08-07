using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public class DBproductos
    {
        private int idProducto;
        private string nombreProducto;
        private string descripcionProducto;
        private decimal precioProducto;
        private byte[] imagenProducto;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string DescripcionProducto { get => descripcionProducto; set => descripcionProducto = value; }
        public decimal PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public byte[] ImagenProducto { get => imagenProducto; set => imagenProducto = value; }

        SqlConnection conexion = new SqlConnection("Server=LAPTOP-2RS2E00C\\GOMEZ;DataBase=Proyecto;integrated security=true");

        public void LlenarProductos(FlowLayoutPanel Contenedor)
        {
            conexion.Open();
            string transacSql = "Select * from Productos";
            SqlCommand comando = new SqlCommand(transacSql, conexion);
            comando.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                IdProducto = Convert.ToInt32(reader[0]);
                NombreProducto = reader[1].ToString();
                DescripcionProducto = reader[3].ToString();
                PrecioProducto = Convert.ToDecimal(reader[2]);
                ImagenProducto = ((byte[])reader[5]);

                vistaProductos componente = new vistaProductos();
                componente.Id = IdProducto;
                componente.Nombre_Producto = NombreProducto;
                componente.Descripcion = DescripcionProducto;
                componente.Precio = PrecioProducto.ToString("C2");
                MemoryStream ms = new MemoryStream(ImagenProducto);
                componente.ImaProducto = Image.FromStream(ms);

                Contenedor.Controls.Add(componente);

            }
            conexion.Close();
            conexion.Dispose();
        }
    }
}
