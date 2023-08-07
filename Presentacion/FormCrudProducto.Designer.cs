
namespace Presentacion
{
    partial class FormCrudProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelPrincipalGrud = new System.Windows.Forms.Panel();
            this.ContendorDataGrid = new System.Windows.Forms.Panel();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelImagen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TextCantidad = new System.Windows.Forms.TextBox();
            this.TextDescripcion = new System.Windows.Forms.TextBox();
            this.TexPrecio = new System.Windows.Forms.TextBox();
            this.TexNombre = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelDes = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.LabelNombreProducto = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.PanelPrincipalGrud.SuspendLayout();
            this.ContendorDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.81481F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.18518F));
            this.tableLayoutPanel1.Controls.Add(this.PanelPrincipalGrud, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1080, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PanelPrincipalGrud
            // 
            this.PanelPrincipalGrud.Controls.Add(this.ContendorDataGrid);
            this.PanelPrincipalGrud.Controls.Add(this.panel1);
            this.PanelPrincipalGrud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipalGrud.Location = new System.Drawing.Point(3, 3);
            this.PanelPrincipalGrud.Name = "PanelPrincipalGrud";
            this.PanelPrincipalGrud.Size = new System.Drawing.Size(694, 494);
            this.PanelPrincipalGrud.TabIndex = 0;
            // 
            // ContendorDataGrid
            // 
            this.ContendorDataGrid.Controls.Add(this.dataGridViewProductos);
            this.ContendorDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContendorDataGrid.Location = new System.Drawing.Point(0, 0);
            this.ContendorDataGrid.Name = "ContendorDataGrid";
            this.ContendorDataGrid.Size = new System.Drawing.Size(694, 430);
            this.ContendorDataGrid.TabIndex = 1;
            this.ContendorDataGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProductos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(694, 430);
            this.dataGridViewProductos.TabIndex = 0;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 64);
            this.panel1.TabIndex = 0;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Orchid;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminar.Location = new System.Drawing.Point(147, 13);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(112, 36);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Orchid;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(12, 13);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 36);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.labelImagen);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.TextCantidad);
            this.panel3.Controls.Add(this.TextDescripcion);
            this.panel3.Controls.Add(this.TexPrecio);
            this.panel3.Controls.Add(this.TexNombre);
            this.panel3.Controls.Add(this.labelCantidad);
            this.panel3.Controls.Add(this.labelDes);
            this.panel3.Controls.Add(this.labelPrecio);
            this.panel3.Controls.Add(this.LabelNombreProducto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(703, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 494);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orchid;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(123, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImagen.ForeColor = System.Drawing.SystemColors.Control;
            this.labelImagen.Location = new System.Drawing.Point(13, 231);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(78, 20);
            this.labelImagen.TabIndex = 11;
            this.labelImagen.Text = "Imagen : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumOrchid;
            this.pictureBox1.Location = new System.Drawing.Point(123, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 64);
            this.panel2.TabIndex = 9;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Magenta;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.Location = new System.Drawing.Point(71, 14);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(253, 35);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TextCantidad
            // 
            this.TextCantidad.Location = new System.Drawing.Point(123, 137);
            this.TextCantidad.Name = "TextCantidad";
            this.TextCantidad.Size = new System.Drawing.Size(243, 20);
            this.TextCantidad.TabIndex = 7;
            // 
            // TextDescripcion
            // 
            this.TextDescripcion.Location = new System.Drawing.Point(123, 102);
            this.TextDescripcion.Name = "TextDescripcion";
            this.TextDescripcion.Size = new System.Drawing.Size(243, 20);
            this.TextDescripcion.TabIndex = 6;
            // 
            // TexPrecio
            // 
            this.TexPrecio.Location = new System.Drawing.Point(123, 69);
            this.TexPrecio.Name = "TexPrecio";
            this.TexPrecio.Size = new System.Drawing.Size(243, 20);
            this.TexPrecio.TabIndex = 5;
            // 
            // TexNombre
            // 
            this.TexNombre.Location = new System.Drawing.Point(123, 34);
            this.TexNombre.Name = "TexNombre";
            this.TexNombre.Size = new System.Drawing.Size(243, 20);
            this.TexNombre.TabIndex = 4;
            this.TexNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCantidad.Location = new System.Drawing.Point(13, 137);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(82, 20);
            this.labelCantidad.TabIndex = 3;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDes.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDes.Location = new System.Drawing.Point(13, 102);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(104, 20);
            this.labelDes.TabIndex = 2;
            this.labelDes.Text = "Descripción: ";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPrecio.Location = new System.Drawing.Point(13, 69);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(64, 20);
            this.labelPrecio.TabIndex = 1;
            this.labelPrecio.Text = "Precio: ";
            // 
            // LabelNombreProducto
            // 
            this.LabelNombreProducto.AutoSize = true;
            this.LabelNombreProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombreProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelNombreProducto.Location = new System.Drawing.Point(13, 34);
            this.LabelNombreProducto.Name = "LabelNombreProducto";
            this.LabelNombreProducto.Size = new System.Drawing.Size(72, 20);
            this.LabelNombreProducto.TabIndex = 0;
            this.LabelNombreProducto.Text = "Nombre:";
            // 
            // FormCrudProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1080, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCrudProducto";
            this.Text = "FormCrudProducto";
            this.Load += new System.EventHandler(this.FormCrudProducto_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PanelPrincipalGrud.ResumeLayout(false);
            this.ContendorDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PanelPrincipalGrud;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ContendorDataGrid;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TextCantidad;
        private System.Windows.Forms.TextBox TextDescripcion;
        private System.Windows.Forms.TextBox TexPrecio;
        private System.Windows.Forms.TextBox TexNombre;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label LabelNombreProducto;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}