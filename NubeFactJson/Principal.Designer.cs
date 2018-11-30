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
            this.txtFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.txtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIFinal = new System.Windows.Forms.Label();
            this.radioTodas = new System.Windows.Forms.RadioButton();
            this.radioSiEnviadas = new System.Windows.Forms.RadioButton();
            this.radioNoEnviadas = new System.Windows.Forms.RadioButton();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.probarConexiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAcciones = new System.Windows.Forms.GroupBox();
            this.cmdEnviarUna = new System.Windows.Forms.Button();
            this.cmdVer = new System.Windows.Forms.Button();
            this.cmdVerificar = new System.Windows.Forms.Button();
            this.cmdEnviar = new System.Windows.Forms.Button();
            this.lblEncontrados = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
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
            this.groupBoxFechas.Controls.Add(this.txtFechaInicial);
            this.groupBoxFechas.Controls.Add(this.txtFechaFinal);
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
            // txtFechaInicial
            // 
            this.txtFechaInicial.CustomFormat = "dd-MM-yyyy";
            this.txtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaInicial.Location = new System.Drawing.Point(102, 21);
            this.txtFechaInicial.Name = "txtFechaInicial";
            this.txtFechaInicial.Size = new System.Drawing.Size(89, 23);
            this.txtFechaInicial.TabIndex = 1;
            // 
            // txtFechaFinal
            // 
            this.txtFechaFinal.CustomFormat = "dd-MM-yyyy";
            this.txtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaFinal.Location = new System.Drawing.Point(288, 22);
            this.txtFechaFinal.Name = "txtFechaFinal";
            this.txtFechaFinal.Size = new System.Drawing.Size(89, 23);
            this.txtFechaFinal.TabIndex = 2;
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
            // radioTodas
            // 
            this.radioTodas.AutoSize = true;
            this.radioTodas.Location = new System.Drawing.Point(601, 22);
            this.radioTodas.Name = "radioTodas";
            this.radioTodas.Size = new System.Drawing.Size(66, 21);
            this.radioTodas.TabIndex = 5;
            this.radioTodas.Text = "&Todas";
            this.radioTodas.UseVisualStyleBackColor = true;
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
            // radioNoEnviadas
            // 
            this.radioNoEnviadas.AutoSize = true;
            this.radioNoEnviadas.Checked = true;
            this.radioNoEnviadas.Location = new System.Drawing.Point(383, 23);
            this.radioNoEnviadas.Name = "radioNoEnviadas";
            this.radioNoEnviadas.Size = new System.Drawing.Size(106, 21);
            this.radioNoEnviadas.TabIndex = 3;
            this.radioNoEnviadas.TabStop = true;
            this.radioNoEnviadas.Text = "&No Enviadas";
            this.radioNoEnviadas.UseVisualStyleBackColor = true;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Location = new System.Drawing.Point(673, 19);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(81, 29);
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
            this.dataGridViewReporte.Size = new System.Drawing.Size(760, 373);
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
            this.probarConexiónToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.probarConexiónToolStripMenuItem.Text = "&Probar Conexión";
            this.probarConexiónToolStripMenuItem.Click += new System.EventHandler(this.probarConexiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // groupBoxAcciones
            // 
            this.groupBoxAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAcciones.Controls.Add(this.cmdEnviarUna);
            this.groupBoxAcciones.Controls.Add(this.cmdVer);
            this.groupBoxAcciones.Controls.Add(this.cmdVerificar);
            this.groupBoxAcciones.Controls.Add(this.cmdEnviar);
            this.groupBoxAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAcciones.Location = new System.Drawing.Point(12, 91);
            this.groupBoxAcciones.Name = "groupBoxAcciones";
            this.groupBoxAcciones.Size = new System.Drawing.Size(760, 44);
            this.groupBoxAcciones.TabIndex = 4;
            this.groupBoxAcciones.TabStop = false;
            this.groupBoxAcciones.Text = "Acciones";
            // 
            // cmdEnviarUna
            // 
            this.cmdEnviarUna.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdEnviarUna.Location = new System.Drawing.Point(261, 15);
            this.cmdEnviarUna.Name = "cmdEnviarUna";
            this.cmdEnviarUna.Size = new System.Drawing.Size(95, 23);
            this.cmdEnviarUna.TabIndex = 10;
            this.cmdEnviarUna.Text = "Enviar Una";
            this.cmdEnviarUna.UseVisualStyleBackColor = true;
            this.cmdEnviarUna.Click += new System.EventHandler(this.cmdEnviarUna_Click);
            // 
            // cmdVer
            // 
            this.cmdVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdVer.Location = new System.Drawing.Point(539, 15);
            this.cmdVer.Name = "cmdVer";
            this.cmdVer.Size = new System.Drawing.Size(95, 23);
            this.cmdVer.TabIndex = 9;
            this.cmdVer.Text = "Ver";
            this.cmdVer.UseVisualStyleBackColor = true;
            this.cmdVer.Click += new System.EventHandler(this.cmdVer_Click);
            // 
            // cmdVerificar
            // 
            this.cmdVerificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVerificar.Location = new System.Drawing.Point(404, 15);
            this.cmdVerificar.Name = "cmdVerificar";
            this.cmdVerificar.Size = new System.Drawing.Size(95, 23);
            this.cmdVerificar.TabIndex = 8;
            this.cmdVerificar.Text = "&Verificar";
            this.cmdVerificar.UseVisualStyleBackColor = true;
            this.cmdVerificar.Click += new System.EventHandler(this.cmdVerificar_Click);
            // 
            // cmdEnviar
            // 
            this.cmdEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEnviar.Location = new System.Drawing.Point(126, 15);
            this.cmdEnviar.Name = "cmdEnviar";
            this.cmdEnviar.Size = new System.Drawing.Size(95, 23);
            this.cmdEnviar.TabIndex = 7;
            this.cmdEnviar.Text = "&Enviar";
            this.cmdEnviar.UseVisualStyleBackColor = true;
            this.cmdEnviar.Click += new System.EventHandler(this.cmdEnviar_Click);
            // 
            // lblEncontrados
            // 
            this.lblEncontrados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEncontrados.AutoSize = true;
            this.lblEncontrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncontrados.Location = new System.Drawing.Point(12, 536);
            this.lblEncontrados.Name = "lblEncontrados";
            this.lblEncontrados.Size = new System.Drawing.Size(20, 18);
            this.lblEncontrados.TabIndex = 5;
            this.lblEncontrados.Text = "...";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(713, 535);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(60, 13);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "Versión 0.9";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblEncontrados);
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
        private System.Windows.Forms.GroupBox groupBoxAcciones;
        private System.Windows.Forms.Button cmdVerificar;
        private System.Windows.Forms.Button cmdEnviar;
        private System.Windows.Forms.DateTimePicker txtFechaFinal;
        private System.Windows.Forms.Label lblEncontrados;
        private System.Windows.Forms.DateTimePicker txtFechaInicial;
        private System.Windows.Forms.Button cmdVer;
        private System.Windows.Forms.Button cmdEnviarUna;
        private System.Windows.Forms.Label lblVersion;
    }
}