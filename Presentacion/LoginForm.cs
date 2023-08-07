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
using Dominio;

namespace Presentacion
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                if (txtContraseña.Text != "")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUsuario.Text, txtContraseña.Text);
                    if (validLogin)
                    {
                        panelPrincipalForm mainMenu = new panelPrincipalForm();
                        mainMenu.Show();
                        mainMenu.FormClosed += cerrarSesion;
                        this.Hide();
                    }
                    else
                    {
                        mostrarError("Usuario o contraseña incorrecto");
                        txtContraseña.Clear();
                        txtUsuario.Focus();
                    }
                }
                else mostrarError("Campo de contraseña vacío");
            }
            else mostrarError("Campo de usuario vacío");
        }

        private void mostrarError(string msg)
        {
            msgError.Text = msg;
            msgError.Visible = true;
        }
        private void cerrarSesion(Object sender, FormClosedEventArgs e)
        {
            txtContraseña.Clear();
            txtUsuario.Clear();
            msgError.Visible = false;
            this.Show();
            txtUsuario.Focus();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
