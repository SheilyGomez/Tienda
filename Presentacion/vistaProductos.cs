using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class vistaProductos: UserControl
    {
        private int id = 0;
        
        
        public vistaProductos()
        {
            InitializeComponent();
        }
        public int Id 
        {
            get { return id; }
            set { id = value; }
        }
        public string Descripcion
        {
            get { return Des.Text; }
            set { Des.Text = value; }
        }

        public string Nombre_Producto
        {
            get { return NombreProducto.Text; }
            set { NombreProducto.Text = value; }
        }
        public string Precio
        {
            get { return precio.Text; }
            set { precio.Text = value; }
        }
        public Image ImaProducto
        {
            get {return imagen.Image; }
            set { imagen.Image = value;}
        }



        private void Descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void vistaProductos_Load(object sender, EventArgs e)
        {

        }

        private void precio_Click(object sender, EventArgs e)
        {

        }

        private void compra_Click(object sender, EventArgs e)
        {
            string mensaje = null;
            if(int.Parse(label2.Text) > 0)
            {
                UserControl1 elementoCarrito = new UserControl1();
                elementoCarrito.Id = Id;
                elementoCarrito.NombreProductos = Nombre_Producto;
                elementoCarrito.CantidadProducto = label2.Text;
                elementoCarrito.PrecioProducto = Precio;
                elementoCarrito.TotalProductos = (double.Parse(Precio.Replace("$","0")) * double.Parse((label2.Text).Replace("$","0"))).ToString();
                LlenadoCarrito.agregarProducto(elementoCarrito);
                mensaje = "Producto añadido con éxito";
            }
            else { mensaje = "La cantidad del producto no debe ser 0"; }
            MessageBox.Show(mensaje);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NombreProducto_Click(object sender, EventArgs e)
        {

        }

        private void mas_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(label2.Text);
            cantidad = cantidad + 1;
            label2.Text = cantidad.ToString();

        }

        private void menos_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(label2.Text);
            
            if (cantidad > 0) {
                cantidad = cantidad - 1;
                            }
            else
            {
                cantidad = 0;
            }
            label2.Text = cantidad.ToString();

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            string cantidad = "0";
            label2.Text = cantidad;

        }
    }
}
