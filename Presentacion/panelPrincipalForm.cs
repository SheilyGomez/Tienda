using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaComun.Cache;

namespace Presentacion
{
    public partial class panelPrincipalForm : Form
    {
        public panelPrincipalForm()
        {
            InitializeComponent();
            
        }

       


        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estás seguro de cerrar la aplicación?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

       


        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessege(System.IntPtr hWnd, int wMsg, int wParam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessege(this.Handle, 0x112, 0xf012, 0);
        }

        private void SubMenuReportes_Paint(object sender, PaintEventArgs e)
        {
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = false;
            AbrirFormHijo(new FormReportInventario());

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = false;
            AbrirFormHijo(new FormReporteCli());
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            SubMenuReportes.Visible = false;
            AbrirFormHijo(new FormReporteEmpleados());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (SubMenuReportes.Visible)
            {
                SubMenuReportes.Visible = false;
            }
            else
            {
                SubMenuReportes.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProductos prod = new FormProductos();
            AbrirFormHijo(prod);
        }

        
        private void AbrirFormHijo(Object formHijo)
        {
            if (this.panelContenido.Controls.Count > 0)
                this.panelContenido.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(fh);
            this.panelContenido.Tag = fh;
            fh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormCarrito());
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estás seguro de cerrar la aplicación? Se perderan datos.", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LlenadoCarrito.quitarProductos();
                this.Close();
            }
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormCrudProducto());
        }

        private void panelPrincipalForm_Load(object sender, EventArgs e)
        {
            if (UserLoginCache.NivelUser == Cargos.Cliente)
            {
                BtnProducto.Enabled = false;
                BtnProducto.Visible = false;
                panel4.Visible = false;
                BtnClientesCrud.Enabled = false;
                BtnClientesCrud.Visible = false;
                panel6.Visible = false;
            }
            if (UserLoginCache.NivelUser == Cargos.Cliente || UserLoginCache.NivelUser == Cargos.Empleado)
            {
                BtnEmpleadosCrud.Enabled = false;
                BtnEmpleadosCrud.Visible = false;
                panel5.Visible = false;
                btnReportes.Enabled = false;
                btnReportes.Visible = false;
                panel7.Visible = false;
            }
        }

        private void BtnClientesCrud_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormCrudUsuarios());
             
        }

        private void BtnEmpleadosCrud_Click(object sender, EventArgs e)
        {
            
            AbrirFormHijo(new FormCrudEmpleado());
           
        }
    }
}






