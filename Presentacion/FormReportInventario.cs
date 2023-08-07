using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using Presentacion.Reportes;

namespace Presentacion
{
    public partial class FormReportInventario : Form
    {
        //Variablr tipo array de parametros
        ParameterFields parametros = new ParameterFields();
        //Variable de tipo parametro
        ParameterField ParametroCantidad = new ParameterField();
        //Para guardar el valor que va ir en el parametro
        ParameterDiscreteValue valor = new ParameterDiscreteValue();
        public FormReportInventario()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnVerReporte_Click(object sender, EventArgs e)
        {
            this.ParametroCantidad.ParameterValueType = ParameterValueKind.NumberParameter;
            this.ParametroCantidad.Name = "@cantidad";
            this.valor.Value = int.Parse(this.TxtValorParametro.Text);
            this.ParametroCantidad.CurrentValues.Add(valor);
            this.parametros.Add(ParametroCantidad);
            this.VisorReporteInven.ParameterFieldInfo = parametros;
            CrystalReportInt rpt = new CrystalReportInt();
            this.VisorReporteInven.ReportSource = rpt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ParametroCantidad.ParameterValueType = ParameterValueKind.NumberParameter;
            this.ParametroCantidad.Name = "@cantidad";
            this.valor.Value = 0;
            this.ParametroCantidad.CurrentValues.Add(valor);
            this.parametros.Add(ParametroCantidad);
            this.VisorReporteInven.ParameterFieldInfo = parametros;
            CrystalReportInt rpt = new CrystalReportInt();
            this.VisorReporteInven.ReportSource = rpt;
        }

        private void VisorReporteInven_Load(object sender, EventArgs e)
        {

        }
    }
    
}
