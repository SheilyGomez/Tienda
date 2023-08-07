using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class FormCrudUsuarios : Form
        
    {
        CN_Usuarios objetoCN = new CN_Usuarios();
        private string IdCliente = null;
        private bool Editar = false;
        public FormCrudUsuarios()
        {
            InitializeComponent();
        }

        private void MostrarUsuarios()
        {
            CN_Usuarios objeto = new CN_Usuarios();
            dataGridViewUsuarios.DataSource = objeto.MostrarUsu();
        } 

        private void tableLayoutPanelUsuarios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            MostrarUsuarios();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Insercion de datos
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarUser(TexNombre.Text, TexApellido.Text, TextTelefono.Text, textContra.Text, TextNivel.Text);
                    MessageBox.Show("Se inserto Correctamente");
                    MostrarUsuarios();
                    limpiarCli();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex);

                }
            }
            //Editar datos
            if (Editar== true){

                try
                {
                    objetoCN.EditarUser(TexNombre.Text, TexApellido.Text, TextTelefono.Text, textContra.Text, TextNivel.Text, IdCliente);
                    MessageBox.Show("Se edito correctamente");
                    MostrarUsuarios();
                    Editar = false;
                    limpiarCli();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex);
                    
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                Editar = true; 
                TexNombre.Text = dataGridViewUsuarios.CurrentRow.Cells["nombre"].Value.ToString();
                TexApellido.Text = dataGridViewUsuarios.CurrentRow.Cells["apellido"].Value.ToString();
                TextTelefono.Text = dataGridViewUsuarios.CurrentRow.Cells["numero"].Value.ToString();
                textContra.Text = dataGridViewUsuarios.CurrentRow.Cells["contraseña"].Value.ToString();

                IdCliente = dataGridViewUsuarios.CurrentRow.Cells["idCliente"].Value.ToString();


            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }
        private void limpiarCli()
        {
            TexNombre.Clear();
            TexApellido.Clear();
            TextTelefono.Clear();
            textContra.Clear();


        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                IdCliente = dataGridViewUsuarios.CurrentRow.Cells["idCliente"].Value.ToString();
                objetoCN.EliminarUser(IdCliente);
                MessageBox.Show("Eliminado correctamente");
                    MostrarUsuarios();
            }
            else
                MessageBox.Show("Selecione una fila por favor");
        }

        private void TextNivel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
