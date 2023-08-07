using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormCarrito : Form
    {
        public FormCarrito()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Clear();
            LlenarProdsCarrito();
            labelPrecioCarrito.Text = "$ " + LlenadoCarrito.totalCompra();
        }

        private void LlenarProdsCarrito()
        {
            LlenadoCarrito obj = new LlenadoCarrito();
            obj.LlenarCarrito(flowLayoutPanel1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCarrito_Load(object sender, EventArgs e)
        {

        }

        private void btnComprarCarrito_Click(object sender, EventArgs e)
        {
            if(LlenadoCarrito.ElemsCount() > 0)
            {
                string Error = "";
                EnvioCorreo.EnviarCorreo(LlenadoCarrito.itemsToMail(), DateTime.Now, out Error);
                LlenadoCarrito.bajarCantidad();
                LlenadoCarrito.quitarProductos(flowLayoutPanel1);
                labelPrecioCarrito.Text = "$ 0.00";
            }
        }
    }
}
