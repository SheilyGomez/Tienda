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
    public partial class FormCrudEmpleado : Form
    {
        CN_Usuarios objetoCN = new CN_Usuarios();
        private string IdCliente = null;
        private bool Editar = false;
        public FormCrudEmpleado()
        {
            InitializeComponent();
        }
        private void MostrarUsuarios()
        {
            CN_Usuarios objeto = new CN_Usuarios();
            dataGridViewEmpleados.DataSource = objeto.MostrarEmple();
        }
        private void limpiarCli()
        {
            TexNombre.Clear();
            TexApellido.Clear();
            TextTelefono.Clear();
            textContra.Clear();
        }

        private void dataGridViewEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PanelContenedorData_Paint(object sender, PaintEventArgs e)
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
                catch (Exception ex){
                    MessageBox.Show("No se pudo insertar los datos por: " + ex);
                }
            }
            //Editar datos
            if (Editar == true){
                try{
                    objetoCN.EditarUser(TexNombre.Text, TexApellido.Text, TextTelefono.Text, textContra.Text, TextNivel.Text, IdCliente);
                    MessageBox.Show("Se edito correctamente");
                    MostrarUsuarios();
                    Editar = false;
                    limpiarCli();
                }
                catch (Exception ex){
                    MessageBox.Show("No se pudo editar los datos por: " + ex);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpleados.SelectedRows.Count > 0)
            {
                IdCliente = dataGridViewEmpleados.CurrentRow.Cells["idCliente"].Value.ToString();
                objetoCN.EliminarUser(IdCliente);
                MessageBox.Show("Eliminado correctamente");
                MostrarUsuarios();
            }
            else
                MessageBox.Show("Selecione una fila por favor");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpleados.SelectedRows.Count > 0)
            {
                Editar = true;
                TexNombre.Text = dataGridViewEmpleados.CurrentRow.Cells["nombre"].Value.ToString();
                TexApellido.Text = dataGridViewEmpleados.CurrentRow.Cells["apellido"].Value.ToString();
                TextTelefono.Text = dataGridViewEmpleados.CurrentRow.Cells["numero"].Value.ToString();
                textContra.Text = dataGridViewEmpleados.CurrentRow.Cells["contraseña"].Value.ToString();

                IdCliente = dataGridViewEmpleados.CurrentRow.Cells["idCliente"].Value.ToString();


            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }
    }
    
}
