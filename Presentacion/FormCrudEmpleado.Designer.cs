
namespace Presentacion
{
    partial class FormCrudEmpleado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelContenedorData = new System.Windows.Forms.Panel();
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.textContra = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.TextNivel = new System.Windows.Forms.TextBox();
            this.TextTelefono = new System.Windows.Forms.TextBox();
            this.TexApellido = new System.Windows.Forms.TextBox();
            this.TexNombre = new System.Windows.Forms.TextBox();
            this.labelNivel = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.LabelNombreUsuario = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelContenedorData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Indigo;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.375F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1080, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelContenedorData);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 494);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.BtnEliminar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 100);
            this.panel2.TabIndex = 0;
            // 
            // PanelContenedorData
            // 
            this.PanelContenedorData.Controls.Add(this.dataGridViewEmpleados);
            this.PanelContenedorData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorData.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedorData.Name = "PanelContenedorData";
            this.PanelContenedorData.Size = new System.Drawing.Size(659, 394);
            this.PanelContenedorData.TabIndex = 1;
            this.PanelContenedorData.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedorData_Paint);
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(659, 394);
            this.dataGridViewEmpleados.TabIndex = 0;
            this.dataGridViewEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpleados_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(668, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(409, 494);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel5.Controls.Add(this.BtnGuardar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 394);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(409, 100);
            this.panel5.TabIndex = 1;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Magenta;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.Location = new System.Drawing.Point(63, 33);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(253, 35);
            this.BtnGuardar.TabIndex = 9;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // textContra
            // 
            this.textContra.Location = new System.Drawing.Point(126, 142);
            this.textContra.Name = "textContra";
            this.textContra.Size = new System.Drawing.Size(243, 20);
            this.textContra.TabIndex = 25;
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.ForeColor = System.Drawing.SystemColors.Control;
            this.labelContraseña.Location = new System.Drawing.Point(16, 142);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(107, 20);
            this.labelContraseña.TabIndex = 24;
            this.labelContraseña.Text = "Contraseña : ";
            // 
            // TextNivel
            // 
            this.TextNivel.Enabled = false;
            this.TextNivel.Location = new System.Drawing.Point(126, 179);
            this.TextNivel.Name = "TextNivel";
            this.TextNivel.Size = new System.Drawing.Size(243, 20);
            this.TextNivel.TabIndex = 23;
            this.TextNivel.Text = "Empleado";
            // 
            // TextTelefono
            // 
            this.TextTelefono.Location = new System.Drawing.Point(126, 107);
            this.TextTelefono.Name = "TextTelefono";
            this.TextTelefono.Size = new System.Drawing.Size(243, 20);
            this.TextTelefono.TabIndex = 22;
            // 
            // TexApellido
            // 
            this.TexApellido.Location = new System.Drawing.Point(126, 74);
            this.TexApellido.Name = "TexApellido";
            this.TexApellido.Size = new System.Drawing.Size(243, 20);
            this.TexApellido.TabIndex = 21;
            // 
            // TexNombre
            // 
            this.TexNombre.Location = new System.Drawing.Point(126, 39);
            this.TexNombre.Name = "TexNombre";
            this.TexNombre.Size = new System.Drawing.Size(243, 20);
            this.TexNombre.TabIndex = 20;
            // 
            // labelNivel
            // 
            this.labelNivel.AutoSize = true;
            this.labelNivel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNivel.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNivel.Location = new System.Drawing.Point(16, 179);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(50, 20);
            this.labelNivel.TabIndex = 19;
            this.labelNivel.Text = "Nivel:";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNumero.Location = new System.Drawing.Point(16, 107);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(83, 20);
            this.labelNumero.TabIndex = 18;
            this.labelNumero.Text = "Telefono : ";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.labelApellido.Location = new System.Drawing.Point(16, 74);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(81, 20);
            this.labelApellido.TabIndex = 17;
            this.labelApellido.Text = "Apellido:  ";
            // 
            // LabelNombreUsuario
            // 
            this.LabelNombreUsuario.AutoSize = true;
            this.LabelNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombreUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelNombreUsuario.Location = new System.Drawing.Point(16, 39);
            this.LabelNombreUsuario.Name = "LabelNombreUsuario";
            this.LabelNombreUsuario.Size = new System.Drawing.Size(72, 20);
            this.LabelNombreUsuario.TabIndex = 16;
            this.LabelNombreUsuario.Text = "Nombre:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel6.Controls.Add(this.textContra);
            this.panel6.Controls.Add(this.labelContraseña);
            this.panel6.Controls.Add(this.TextNivel);
            this.panel6.Controls.Add(this.TextTelefono);
            this.panel6.Controls.Add(this.TexApellido);
            this.panel6.Controls.Add(this.TexNombre);
            this.panel6.Controls.Add(this.labelNivel);
            this.panel6.Controls.Add(this.labelNumero);
            this.panel6.Controls.Add(this.labelApellido);
            this.panel6.Controls.Add(this.LabelNombreUsuario);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(409, 394);
            this.panel6.TabIndex = 2;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Orchid;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminar.Location = new System.Drawing.Point(157, 32);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(112, 36);
            this.BtnEliminar.TabIndex = 10;
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
            this.btnEditar.Location = new System.Drawing.Point(39, 32);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 36);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FormCrudEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCrudEmpleado";
            this.Text = "FormCrudEmpleado";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PanelContenedorData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelContenedorData;
        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textContra;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox TextNivel;
        private System.Windows.Forms.TextBox TextTelefono;
        private System.Windows.Forms.TextBox TexApellido;
        private System.Windows.Forms.TextBox TexNombre;
        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label LabelNombreUsuario;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button btnEditar;
    }
}