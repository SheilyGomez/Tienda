
namespace Presentacion
{
    partial class FormCrudUsuarios
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
            this.tableLayoutPanelUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.tableLayoutPanelUsuarios.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelUsuarios
            // 
            this.tableLayoutPanelUsuarios.ColumnCount = 2;
            this.tableLayoutPanelUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.5F));
            this.tableLayoutPanelUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.5F));
            this.tableLayoutPanelUsuarios.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanelUsuarios.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanelUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelUsuarios.Name = "tableLayoutPanelUsuarios";
            this.tableLayoutPanelUsuarios.RowCount = 1;
            this.tableLayoutPanelUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUsuarios.Size = new System.Drawing.Size(1080, 500);
            this.tableLayoutPanelUsuarios.TabIndex = 0;
            this.tableLayoutPanelUsuarios.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelUsuarios_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.dataGridViewUsuarios);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 494);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(690, 394);
            this.dataGridViewUsuarios.TabIndex = 7;
            this.dataGridViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Controls.Add(this.BtnEliminar);
            this.panel3.Controls.Add(this.btnEditar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 394);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 100);
            this.panel3.TabIndex = 6;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Orchid;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminar.Location = new System.Drawing.Point(145, 30);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(112, 36);
            this.BtnEliminar.TabIndex = 8;
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
            this.btnEditar.Location = new System.Drawing.Point(27, 30);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 36);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(699, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 494);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textContra);
            this.panel5.Controls.Add(this.labelContraseña);
            this.panel5.Controls.Add(this.TextNivel);
            this.panel5.Controls.Add(this.TextTelefono);
            this.panel5.Controls.Add(this.TexApellido);
            this.panel5.Controls.Add(this.TexNombre);
            this.panel5.Controls.Add(this.labelNivel);
            this.panel5.Controls.Add(this.labelNumero);
            this.panel5.Controls.Add(this.labelApellido);
            this.panel5.Controls.Add(this.LabelNombreUsuario);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(378, 394);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
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
            this.TextNivel.Text = "Cliente";
            this.TextNivel.TextChanged += new System.EventHandler(this.TextNivel_TextChanged);
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
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnGuardar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 394);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 100);
            this.panel4.TabIndex = 0;
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
            // FormCrudUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1080, 500);
            this.Controls.Add(this.tableLayoutPanelUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCrudUsuarios";
            this.Text = "FormCrudUsuarios";
            this.tableLayoutPanelUsuarios.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TextNivel;
        private System.Windows.Forms.TextBox TextTelefono;
        private System.Windows.Forms.TextBox TexApellido;
        private System.Windows.Forms.TextBox TexNombre;
        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label LabelNombreUsuario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox textContra;
        private System.Windows.Forms.Label labelContraseña;
    }
}