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
            lblEncontrados.Text = "Buscando ...";
            Cursor.Current = Cursors.WaitCursor;
            if (radioTodas.Checked)
            {
                ReporteTodos(txtFechaInicial.Value, txtFechaFinal.Value);
            }
            else if (radioNoEnviadas.Checked)
            {
                ReporteNoEnviadas(txtFechaInicial.Value, txtFechaFinal.Value);
            }
            else if (radioSiEnviadas.Checked)
            {
                ReporteEnviadas(txtFechaInicial.Value, txtFechaFinal.Value);
            }
            Cursor.Current = Cursors.Default;
            lblEncontrados.Text = "Encontrados: " + (dataGridViewReporte.RowCount - 1);
        }

        private void ReporteTodos(DateTime fechaInicio, DateTime fechaFin)
        {
            var reporteFactura = new ReporteFactura
            {
                FechaInicio = fechaInicio,
                FechaFin = fechaFin
            };
            var dataTable = reporteFactura.Reporte(ReporteFactura.TODOS);
            dataGridViewReporte.DataSource = dataTable;
        }

        private void ReporteNoEnviadas(DateTime fechaInicio, DateTime fechaFin)
        {
            var reporteFactura = new ReporteFactura();
            reporteFactura.FechaInicio = fechaInicio;
            reporteFactura.FechaFin = fechaFin;
            var dataTable = reporteFactura.Reporte(ReporteFactura.NO_ENVIADO);
            dataGridViewReporte.DataSource = dataTable;
        }

        private void ReporteEnviadas(DateTime fechaInicio, DateTime fechaFin)
        {
            var reporteFactura = new ReporteFactura();
            reporteFactura.FechaInicio = fechaInicio;
            reporteFactura.FechaFin = fechaFin;
            var dataTable = reporteFactura.Reporte(ReporteFactura.ENVIADO);
            dataGridViewReporte.DataSource = dataTable;
        }

        private void probarConexiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var c = new Connection();
            c.initSqlServer();
            if (c.probarSqlServerConnection())
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

        void EnviarNubeFact(DateTime fechaInicio, DateTime fechaFin)
        {
            var nubeFact = new NubeFact
            {
                FechaInicio = fechaInicio,
                FechaFin = fechaFin
            };
            string mensaje = nubeFact.Enviar();
            if (!mensaje.Equals(""))
            {
                Console.WriteLine(mensaje);
            }
        }

        void VerificarNubeFact(DateTime fechaInicio, DateTime fechaFin)
        {
            var nubeFact = new NubeFact
            {
                FechaInicio = fechaInicio,
                FechaFin = fechaFin
            };
            string mensaje = nubeFact.Verificar();
            if (!mensaje.Equals(""))
            {
                Console.WriteLine(mensaje);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdEnviar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            EnviarNubeFact(txtFechaInicial.Value, txtFechaFinal.Value);
            Cursor.Current = Cursors.Default;
        }

        private void cmdVerificar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            VerificarNubeFact(txtFechaInicial.Value, txtFechaFinal.Value);
            Cursor.Current = Cursors.Default;
        }
    }
}
