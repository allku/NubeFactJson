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

        private void cmdProbar_Click(object sender, EventArgs e)
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
    }
}
