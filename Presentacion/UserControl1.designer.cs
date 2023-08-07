namespace Presentacion
{
    partial class UserControl1
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
            this.labelNombrePC = new System.Windows.Forms.Label();
            this.labelCantidadPC = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPrecioPC = new System.Windows.Forms.Label();
            this.LableTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNombrePC
            // 
            this.labelNombrePC.AutoSize = true;
            this.labelNombrePC.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombrePC.Location = new System.Drawing.Point(3, 0);
            this.labelNombrePC.Name = "labelNombrePC";
            this.labelNombrePC.Size = new System.Drawing.Size(206, 22);
            this.labelNombrePC.TabIndex = 0;
            this.labelNombrePC.Text = "Nombre de producto";
            // 
            // labelCantidadPC
            // 
            this.labelCantidadPC.AutoSize = true;
            this.labelCantidadPC.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadPC.Location = new System.Drawing.Point(479, 0);
            this.labelCantidadPC.Name = "labelCantidadPC";
            this.labelCantidadPC.Size = new System.Drawing.Size(48, 22);
            this.labelCantidadPC.TabIndex = 1;
            this.labelCantidadPC.Text = " 145";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.83334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.16667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.Controls.Add(this.LableTotal, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPrecioPC, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCantidadPC, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNombrePC, 0, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1069, 27);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // labelPrecioPC
            // 
            this.labelPrecioPC.AutoSize = true;
            this.labelPrecioPC.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioPC.Location = new System.Drawing.Point(675, 0);
            this.labelPrecioPC.Name = "labelPrecioPC";
            this.labelPrecioPC.Size = new System.Drawing.Size(80, 22);
            this.labelPrecioPC.TabIndex = 2;
            this.labelPrecioPC.Text = " $ 45.00";
            this.labelPrecioPC.Click += new System.EventHandler(this.labelPrecioPC_Click);
            // 
            // LableTotal
            // 
            this.LableTotal.AutoSize = true;
            this.LableTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableTotal.Location = new System.Drawing.Point(882, 0);
            this.LableTotal.Name = "LableTotal";
            this.LableTotal.Size = new System.Drawing.Size(80, 22);
            this.LableTotal.TabIndex = 3;
            this.LableTotal.Text = " $ 80.00";
            this.LableTotal.Click += new System.EventHandler(this.LableTotal_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1080, 35);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNombrePC;
        private System.Windows.Forms.Label labelCantidadPC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelPrecioPC;
        private System.Windows.Forms.Label LableTotal;
    }
}
