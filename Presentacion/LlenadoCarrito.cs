using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    class LlenadoCarrito
    {
        private static List<UserControl1> elems  = new List<UserControl1>();

        public static int ElemsCount() => elems.Count;

        public static StringBuilder itemsToMail()
        {
            StringBuilder msgBuilder = new StringBuilder();
            msgBuilder.Append("<h1><b>Lista de pedidos</b></h1>");
            elems.ForEach(el => {
                msgBuilder.Append($"<h3>{el.NombreProductos}</h3>");
                msgBuilder.Append($"<ul><li>Precio: {el.PrecioProducto}</li><li>Cantidad: {el.CantidadProducto}</li><li>Precio Total: ${el.TotalProductos}</li></ul>");
            });
            msgBuilder.Append($"<h5><b>Precio Total de compra: ${totalCompra()}</b></h5>");
            return msgBuilder;
        }

        public static void bajarCantidad()
        {
            elems.ForEach(el => {
                Dominio.CN_Productos obj = new Dominio.CN_Productos();
                obj.BajarCantidad(el.Id, int.Parse(el.CantidadProducto));
            });
        }

        public void LlenarCarrito(FlowLayoutPanel Contenedor)
        {
            elems.ForEach(elem => Contenedor.Controls.Add(elem));
        }

        public static string totalCompra()
        {
            double precioTotal = 0;
            elems.ForEach(el =>
            {
                precioTotal = precioTotal + double.Parse(el.TotalProductos);
            });
            return precioTotal.ToString();
        }

        public static void agregarProducto(UserControl1 prod)
        {
            bool existe = false;
            elems.ForEach(el => {
                if (el.Id == prod.Id) {
                    el.CantidadProducto = (int.Parse(el.CantidadProducto) + int.Parse(prod.CantidadProducto)).ToString();
                    el.TotalProductos = (double.Parse(el.TotalProductos) + double.Parse(prod.TotalProductos)).ToString();
                    existe = true; 
                }
            });
            if(!existe) elems.Add(prod);
        }

        public static void quitarProductos(FlowLayoutPanel contenedor)
        {
            if(elems.Count > 0) elems.Clear();
            contenedor.Controls.Clear();
        }
        public static void quitarProductos()
        {
            if(elems.Count > 0) elems.Clear();
        }
    }
}
