namespace Presentacion
{
    partial class vistaProductos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.producto = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Des = new System.Windows.Forms.TextBox();
            this.menos = new System.Windows.Forms.Button();
            this.mas = new System.Windows.Forms.Button();
            this.compra = new System.Windows.Forms.Button();
            this.precio = new System.Windows.Forms.Label();
            this.NombreProducto = new System.Windows.Forms.Label();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // producto
            // 
            this.producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.producto.Controls.Add(this.label2);
            this.producto.Controls.Add(this.label1);
            this.producto.Controls.Add(this.Des);
            this.producto.Controls.Add(this.menos);
            this.producto.Controls.Add(this.mas);
            this.producto.Controls.Add(this.compra);
            this.producto.Controls.Add(this.precio);
            this.producto.Controls.Add(this.NombreProducto);
            this.producto.Controls.Add(this.imagen);
            this.producto.Location = new System.Drawing.Point(3, 4);
            this.producto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(306, 210);
            this.producto.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(195, 171);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(131, 171);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cantidad:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Des
            // 
            this.Des.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Des.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Des.Enabled = false;
            this.Des.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Des.ForeColor = System.Drawing.Color.White;
            this.Des.Location = new System.Drawing.Point(166, 71);
            this.Des.Margin = new System.Windows.Forms.Padding(0);
            this.Des.Multiline = true;
            this.Des.Name = "Des";
            this.Des.Size = new System.Drawing.Size(123, 81);
            this.Des.TabIndex = 7;
            this.Des.Text = "Des";
            this.Des.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Des.TextChanged += new System.EventHandler(this.Descripcion_TextChanged);
            // 
            // menos
            // 
            this.menos.BackColor = System.Drawing.Color.Fuchsia;
            this.menos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.menos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menos.Location = new System.Drawing.Point(231, 165);
            this.menos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(28, 28);
            this.menos.TabIndex = 6;
            this.menos.Text = "-";
            this.menos.UseVisualStyleBackColor = false;
            this.menos.Click += new System.EventHandler(this.menos_Click);
            // 
            // mas
            // 
            this.mas.BackColor = System.Drawing.Color.Fuchsia;
            this.mas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.mas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mas.Location = new System.Drawing.Point(265, 165);
            this.mas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mas.Name = "mas";
            this.mas.Size = new System.Drawing.Size(29, 28);
            this.mas.TabIndex = 5;
            this.mas.Text = "+";
            this.mas.UseVisualStyleBackColor = false;
            this.mas.Click += new System.EventHandler(this.mas_Click);
            // 
            // compra
            // 
            this.compra.BackColor = System.Drawing.Color.MediumOrchid;
            this.compra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.compra.Cursor = System.Windows.Forms.Cursors.Default;
            this.compra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.compra.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.compra.ForeColor = System.Drawing.SystemColors.Control;
            this.compra.Location = new System.Drawing.Point(14, 165);
            this.compra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.compra.Name = "compra";
            this.compra.Size = new System.Drawing.Size(86, 28);
            this.compra.TabIndex = 4;
            this.compra.Text = "COMPRAR";
            this.compra.UseVisualStyleBackColor = false;
            this.compra.Click += new System.EventHandler(this.compra_Click);
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.precio.Location = new System.Drawing.Point(166, 45);
            this.precio.Name = "precio";
            this.precio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.precio.Size = new System.Drawing.Size(56, 16);
            this.precio.TabIndex = 2;
            this.precio.Text = "$ 100.00";
            this.precio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.precio.Click += new System.EventHandler(this.precio_Click);
            // 
            // NombreProducto
            // 
            this.NombreProducto.AutoSize = true;
            this.NombreProducto.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            this.NombreProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NombreProducto.Location = new System.Drawing.Point(163, 17);
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Size = new System.Drawing.Size(127, 19);
            this.NombreProducto.TabIndex = 1;
            this.NombreProducto.Text = "NombreProducto";
            this.NombreProducto.Click += new System.EventHandler(this.NombreProducto_Click);
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(14, 17);
            this.imagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(130, 126);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagen.TabIndex = 0;
            this.imagen.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // vistaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.producto);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "vistaProductos";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(314, 219);
            this.Load += new System.EventHandler(this.vistaProductos_Load);
            this.producto.ResumeLayout(false);
            this.producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel producto;
        private System.Windows.Forms.TextBox Des;
        private System.Windows.Forms.Button menos;
        private System.Windows.Forms.Button mas;
        private System.Windows.Forms.Button compra;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.Label NombreProducto;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
