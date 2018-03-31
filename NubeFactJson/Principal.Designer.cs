namespace NubeFactJson
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.groupBoxFechas = new System.Windows.Forms.GroupBox();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.probarConexiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioNoEnviadas = new System.Windows.Forms.RadioButton();
            this.radioSiEnviadas = new System.Windows.Forms.RadioButton();
            this.radioTodas = new System.Windows.Forms.RadioButton();
            this.lblFechaIFinal = new System.Windows.Forms.Label();
            this.txtFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.groupBoxAcciones = new System.Windows.Forms.GroupBox();
            this.cmdEnviar = new System.Windows.Forms.Button();
            this.cmdVerificar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBoxFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.groupBoxAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFechas
            // 
            this.groupBoxFechas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFechas.Controls.Add(this.dateTimePicker1);
            this.groupBoxFechas.Controls.Add(this.txtFechaInicial);
            this.groupBoxFechas.Controls.Add(this.lblFechaIFinal);
            this.groupBoxFechas.Controls.Add(this.radioTodas);
            this.groupBoxFechas.Controls.Add(this.radioSiEnviadas);
            this.groupBoxFechas.Controls.Add(this.radioNoEnviadas);
            this.groupBoxFechas.Controls.Add(this.cmdConsultar);
            this.groupBoxFechas.Controls.Add(this.lblFechaInicial);
            this.groupBoxFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFechas.Location = new System.Drawing.Point(12, 37);
            this.groupBoxFechas.Name = "groupBoxFechas";
            this.groupBoxFechas.Size = new System.Drawing.Size(760, 54);
            this.groupBoxFechas.TabIndex = 1;
            this.groupBoxFechas.TabStop = false;
            this.groupBoxFechas.Text = "Rango de Fechas";
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Location = new System.Drawing.Point(673, 19);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(81, 23);
            this.cmdConsultar.TabIndex = 6;
            this.cmdConsultar.Text = "&Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Location = new System.Drawing.Point(6, 23);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(90, 17);
            this.lblFechaInicial.TabIndex = 0;
            this.lblFechaInicial.Text = "Fecha Inicial:";
            // 
            // dataGridViewReporte
            // 
            this.dataGridViewReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporte.Location = new System.Drawing.Point(12, 141);
            this.dataGridViewReporte.Name = "dataGridViewReporte";
            this.dataGridViewReporte.Size = new System.Drawing.Size(760, 387);
            this.dataGridViewReporte.TabIndex = 2;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 25);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.probarConexiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
            // 
            // probarConexiónToolStripMenuItem
            // 
            this.probarConexiónToolStripMenuItem.Name = "probarConexiónToolStripMenuItem";
            this.probarConexiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.probarConexiónToolStripMenuItem.Text = "&Probar Conexión";
            this.probarConexiónToolStripMenuItem.Click += new System.EventHandler(this.probarConexiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // radioNoEnviadas
            // 
            this.radioNoEnviadas.AutoSize = true;
            this.radioNoEnviadas.Checked = true;
            this.radioNoEnviadas.Location = new System.Drawing.Point(383, 22);
            this.radioNoEnviadas.Name = "radioNoEnviadas";
            this.radioNoEnviadas.Size = new System.Drawing.Size(106, 21);
            this.radioNoEnviadas.TabIndex = 3;
            this.radioNoEnviadas.TabStop = true;
            this.radioNoEnviadas.Text = "&No Enviadas";
            this.radioNoEnviadas.UseVisualStyleBackColor = true;
            // 
            // radioSiEnviadas
            // 
            this.radioSiEnviadas.AutoSize = true;
            this.radioSiEnviadas.Location = new System.Drawing.Point(495, 23);
            this.radioSiEnviadas.Name = "radioSiEnviadas";
            this.radioSiEnviadas.Size = new System.Drawing.Size(100, 21);
            this.radioSiEnviadas.TabIndex = 4;
            this.radioSiEnviadas.Text = "&Si Enviadas";
            this.radioSiEnviadas.UseVisualStyleBackColor = true;
            // 
            // radioTodas
            // 
            this.radioTodas.AutoSize = true;
            this.radioTodas.Location = new System.Drawing.Point(601, 21);
            this.radioTodas.Name = "radioTodas";
            this.radioTodas.Size = new System.Drawing.Size(66, 21);
            this.radioTodas.TabIndex = 5;
            this.radioTodas.Text = "&Todas";
            this.radioTodas.UseVisualStyleBackColor = true;
            // 
            // lblFechaIFinal
            // 
            this.lblFechaIFinal.AutoSize = true;
            this.lblFechaIFinal.Location = new System.Drawing.Point(197, 23);
            this.lblFechaIFinal.Name = "lblFechaIFinal";
            this.lblFechaIFinal.Size = new System.Drawing.Size(85, 17);
            this.lblFechaIFinal.TabIndex = 6;
            this.lblFechaIFinal.Text = "Fecha Final:";
            // 
            // txtFechaInicial
            // 
            this.txtFechaInicial.CustomFormat = "dd-MM-yyyy";
            this.txtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaInicial.Location = new System.Drawing.Point(102, 20);
            this.txtFechaInicial.Name = "txtFechaInicial";
            this.txtFechaInicial.Size = new System.Drawing.Size(89, 23);
            this.txtFechaInicial.TabIndex = 1;
            this.txtFechaInicial.Value = new System.DateTime(2018, 3, 31, 13, 7, 2, 0);
            // 
            // groupBoxAcciones
            // 
            this.groupBoxAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAcciones.Controls.Add(this.cmdVerificar);
            this.groupBoxAcciones.Controls.Add(this.cmdEnviar);
            this.groupBoxAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAcciones.Location = new System.Drawing.Point(12, 97);
            this.groupBoxAcciones.Name = "groupBoxAcciones";
            this.groupBoxAcciones.Size = new System.Drawing.Size(760, 38);
            this.groupBoxAcciones.TabIndex = 4;
            this.groupBoxAcciones.TabStop = false;
            this.groupBoxAcciones.Text = "Acciones";
            // 
            // cmdEnviar
            // 
            this.cmdEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEnviar.Location = new System.Drawing.Point(286, 9);
            this.cmdEnviar.Name = "cmdEnviar";
            this.cmdEnviar.Size = new System.Drawing.Size(75, 23);
            this.cmdEnviar.TabIndex = 7;
            this.cmdEnviar.Text = "&Enviar";
            this.cmdEnviar.UseVisualStyleBackColor = true;
            // 
            // cmdVerificar
            // 
            this.cmdVerificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVerificar.Location = new System.Drawing.Point(402, 9);
            this.cmdVerificar.Name = "cmdVerificar";
            this.cmdVerificar.Size = new System.Drawing.Size(75, 23);
            this.cmdVerificar.TabIndex = 8;
            this.cmdVerificar.Text = "&Verificar";
            this.cmdVerificar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(89, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBoxAcciones);
            this.Controls.Add(this.dataGridViewReporte);
            this.Controls.Add(this.groupBoxFechas);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Principal";
            this.Text = "Principal";
            this.groupBoxFechas.ResumeLayout(false);
            this.groupBoxFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxFechas;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.DataGridView dataGridViewReporte;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem probarConexiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioTodas;
        private System.Windows.Forms.RadioButton radioSiEnviadas;
        private System.Windows.Forms.RadioButton radioNoEnviadas;
        private System.Windows.Forms.Label lblFechaIFinal;
        private System.Windows.Forms.DateTimePicker txtFechaInicial;
        private System.Windows.Forms.GroupBox groupBoxAcciones;
        private System.Windows.Forms.Button cmdVerificar;
        private System.Windows.Forms.Button cmdEnviar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}