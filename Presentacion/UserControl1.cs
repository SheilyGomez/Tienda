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
    public partial class UserControl1 : UserControl
    {
        private int id = 0;
        public UserControl1()
        {
            InitializeComponent();
        }

        public int Id
        {
            get { return id; }
            set { id = value; }

        }
        public string NombreProductos
        {
            get { return labelNombrePC.Text; }
            set { labelNombrePC.Text = value; }

        }

        public string CantidadProducto
        {
            get { return labelCantidadPC.Text; }
            set { labelCantidadPC.Text = value; }

        }

        public string PrecioProducto
        {
            get { return labelPrecioPC.Text; }
            set { labelPrecioPC.Text = value; }
        }
        public string TotalProductos
        {
            get { return LableTotal.Text;}
            set { LableTotal.Text = value; }
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelPrecioPC_Click(object sender, EventArgs e)
        {

        }

        private void LableTotal_Click(object sender, EventArgs e)
        {
            
        }
    }
}
