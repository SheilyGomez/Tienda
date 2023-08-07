using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class FormCrudProducto : Form
    {

        Valores estado;
        CN_Productos CNProd = new CN_Productos();
        int id = 0;

        private byte[] ConvertImg()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.GetBuffer();
        }
        private MemoryStream ByteImg()
        {
            byte[] img = (byte[])dataGridViewProductos.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(img);
            return ms;
        }

        public FormCrudProducto()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridViewProductos.SelectedRows.Count > 0)
            {
                pictureBox1.Image = Image.FromStream(ByteImg());
                id = Convert.ToInt32(dataGridViewProductos.CurrentRow.Cells[0].Value);
                TexNombre.Text = dataGridViewProductos.CurrentRow.Cells[1].Value.ToString();
                TexPrecio.Text = dataGridViewProductos.CurrentRow.Cells[2].Value.ToString();
                TextDescripcion.Text = dataGridViewProductos.CurrentRow.Cells[3].Value.ToString();
                TextCantidad.Text = dataGridViewProductos.CurrentRow.Cells[4].Value.ToString();
                estado = Valores.Editar;
            }
            else
            {
                MessageBox.Show("Seleccionar una fila");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        public void ActualizarCambios()
        {
            dataGridViewProductos.DataSource = CNProd.VerProductos();
            dataGridViewProductos.Columns[5].Visible = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CN_Productos prod = new CN_Productos();
            prod.estado = estado;
            prod.Id = id;
            prod.Nombre = TexNombre.Text;
            prod.Precio = decimal.Parse(TexPrecio.Text);
            prod.Descripcion = TextDescripcion.Text;
            prod.Cantidad = int.Parse(TextCantidad.Text);
            prod.Imagen = ConvertImg();
            MessageBox.Show(prod.GuardarCambios());
            ActualizarCambios();
            pictureBox1.Image.Dispose();
            pictureBox1.Image = null;
            TexNombre.Text = "";
            TexPrecio.Text = "";
            TextDescripcion.Text = "";
            TextCantidad.Text = "";
            estado = Valores.Agregar;

        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG(*.png)|*.png";
            if(getImage.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = getImage.FileName;
            }
            else { }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(dataGridViewProductos.SelectedRows.Count > 0)
            {
                CNProd.Id = Convert.ToInt32(dataGridViewProductos.CurrentRow.Cells[0].Value);
                CNProd.estado = Valores.Eliminar;
                MessageBox.Show(CNProd.GuardarCambios());
                ActualizarCambios();
            }
            else
            {
                MessageBox.Show("Seleccionar una fila");
            }
        }

        private void FormCrudProducto_Load(object sender, EventArgs e)
        {
            ActualizarCambios();
        }
    }
}










