
namespace Presentacion
{
    partial class FormReportInventario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelContenedorRe = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.VisorReporteInven = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.TxtValorParametro = new System.Windows.Forms.TextBox();
            this.BtnVerReporte = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PanelContenedorRe.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelContenedorRe);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 500);
            this.panel1.TabIndex = 0;
            // 
            // PanelContenedorRe
            // 
            this.PanelContenedorRe.BackColor = System.Drawing.Color.MediumPurple;
            this.PanelContenedorRe.Controls.Add(this.panel3);
            this.PanelContenedorRe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorRe.Location = new System.Drawing.Point(0, 100);
            this.PanelContenedorRe.Name = "PanelContenedorRe";
            this.PanelContenedorRe.Size = new System.Drawing.Size(1080, 400);
            this.PanelContenedorRe.TabIndex = 1;
            this.PanelContenedorRe.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.VisorReporteInven);
            this.panel3.Location = new System.Drawing.Point(22, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1037, 400);
            this.panel3.TabIndex = 0;
            // 
            // VisorReporteInven
            // 
            this.VisorReporteInven.ActiveViewIndex = -1;
            this.VisorReporteInven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisorReporteInven.Cursor = System.Windows.Forms.Cursors.Default;
            this.VisorReporteInven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisorReporteInven.Location = new System.Drawing.Point(0, 0);
            this.VisorReporteInven.Name = "VisorReporteInven";
            this.VisorReporteInven.Size = new System.Drawing.Size(1037, 400);
            this.VisorReporteInven.TabIndex = 0;
            this.VisorReporteInven.Load += new System.EventHandler(this.VisorReporteInven_Load);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.labelCantidad);
            this.panel2.Controls.Add(this.TxtValorParametro);
            this.panel2.Controls.Add(this.BtnVerReporte);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(258, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "REPORTES DE INVENTARIO POR CANTIDAD DE PRODUCTO";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Magenta;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(30, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Producto Agotado";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCantidad.Location = new System.Drawing.Point(494, 63);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(162, 16);
            this.labelCantidad.TabIndex = 4;
            this.labelCantidad.Text = "Cantidad de producto: ";
            // 
            // TxtValorParametro
            // 
            this.TxtValorParametro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorParametro.Location = new System.Drawing.Point(668, 60);
            this.TxtValorParametro.Name = "TxtValorParametro";
            this.TxtValorParametro.Size = new System.Drawing.Size(251, 23);
            this.TxtValorParametro.TabIndex = 3;
            // 
            // BtnVerReporte
            // 
            this.BtnVerReporte.BackColor = System.Drawing.Color.Magenta;
            this.BtnVerReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVerReporte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerReporte.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnVerReporte.Location = new System.Drawing.Point(941, 58);
            this.BtnVerReporte.Name = "BtnVerReporte";
            this.BtnVerReporte.Size = new System.Drawing.Size(108, 27);
            this.BtnVerReporte.TabIndex = 0;
            this.BtnVerReporte.Text = "Ver Reporte";
            this.BtnVerReporte.UseVisualStyleBackColor = false;
            this.BtnVerReporte.Click += new System.EventHandler(this.BtnVerReporte_Click);
            // 
            // FormReportInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1080, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportInventario";
            this.Text = "FormReportInventario";
            this.panel1.ResumeLayout(false);
            this.PanelContenedorRe.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelContenedorRe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnVerReporte;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox TxtValorParametro;
        private System.Windows.Forms.Panel panel3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer VisorReporteInven;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}