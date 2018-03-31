using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NubeFactJson
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            DateTime Fecha;

            if (DateTime.TryParse(txtFechaInicial.Text, out Fecha))
            {
                ReporteTodas(txtFechaInicial.Text);
            }
            else
            {
                MessageBox.Show("El formato de fecha debe se: dd-mm-yyyy",
                               "Formato de Fecha",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void ReporteTodas(string fecha)
        {
            var reporteFactura = new ReporteFactura();
            reporteFactura.fecha = fecha;
            var dataTable = reporteFactura.ReporteWinForms(ReporteFactura.TODOS);
            dataGridViewReporte.DataSource = dataTable;
        }

        private void ReporteNoEnviadas(string fecha)
        {
            var reporteFactura = new ReporteFactura();
            reporteFactura.fecha = fecha;
            var dataTable = reporteFactura.ReporteWinForms(ReporteFactura.NO_ENVIADO);
            dataGridViewReporte.DataSource = dataTable;
        }

        private void ReporteEnviadas(string fecha)
        {
            var reporteFactura = new ReporteFactura();
            reporteFactura.fecha = fecha;
            var dataTable = reporteFactura.ReporteWinForms(ReporteFactura.ENVIADO);
            dataGridViewReporte.DataSource = dataTable;
        }

        private void probarConexiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var c = new Connection();
            c.initSqlServer();
            if (c.probarSqlServerConnectionWinForm())
            {
                MessageBox.Show("Conexión de base de datos exitosa",
                    "Conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error con la conexión de base de datos",
                    "Conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
