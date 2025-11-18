namespace pryChimento_SP4
{
    partial class frmPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnGastosViaticos = new System.Windows.Forms.Button();
            this.lblTipoGrafico = new System.Windows.Forms.Label();
            this.progressBarCarga = new System.Windows.Forms.ProgressBar();
            this.cboTipoGrafico = new System.Windows.Forms.ComboBox();
            this.btnKgCamion = new System.Windows.Forms.Button();
            this.btnGastosCamion = new System.Windows.Forms.Button();
            this.btnCamion = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelConex = new System.Windows.Forms.ToolStripStatusLabel();
            this.chartInfo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGastosViaticos
            // 
            this.btnGastosViaticos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastosViaticos.Location = new System.Drawing.Point(31, 378);
            this.btnGastosViaticos.Name = "btnGastosViaticos";
            this.btnGastosViaticos.Size = new System.Drawing.Size(172, 59);
            this.btnGastosViaticos.TabIndex = 18;
            this.btnGastosViaticos.Text = "Gastos/ Viaticos por Camion";
            this.btnGastosViaticos.UseVisualStyleBackColor = true;
            // 
            // lblTipoGrafico
            // 
            this.lblTipoGrafico.AutoSize = true;
            this.lblTipoGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoGrafico.Location = new System.Drawing.Point(29, 10);
            this.lblTipoGrafico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoGrafico.Name = "lblTipoGrafico";
            this.lblTipoGrafico.Size = new System.Drawing.Size(121, 17);
            this.lblTipoGrafico.TabIndex = 17;
            this.lblTipoGrafico.Text = "Tipo de Grafico";
            // 
            // progressBarCarga
            // 
            this.progressBarCarga.Location = new System.Drawing.Point(285, 8);
            this.progressBarCarga.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarCarga.Name = "progressBarCarga";
            this.progressBarCarga.Size = new System.Drawing.Size(537, 18);
            this.progressBarCarga.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarCarga.TabIndex = 16;
            this.progressBarCarga.Visible = false;
            // 
            // cboTipoGrafico
            // 
            this.cboTipoGrafico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoGrafico.FormattingEnabled = true;
            this.cboTipoGrafico.Location = new System.Drawing.Point(31, 57);
            this.cboTipoGrafico.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoGrafico.Name = "cboTipoGrafico";
            this.cboTipoGrafico.Size = new System.Drawing.Size(139, 21);
            this.cboTipoGrafico.TabIndex = 15;
            // 
            // btnKgCamion
            // 
            this.btnKgCamion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKgCamion.Location = new System.Drawing.Point(31, 288);
            this.btnKgCamion.Name = "btnKgCamion";
            this.btnKgCamion.Size = new System.Drawing.Size(172, 59);
            this.btnKgCamion.TabIndex = 14;
            this.btnKgCamion.Text = "Kilogramos por Camion";
            this.btnKgCamion.UseVisualStyleBackColor = true;
            // 
            // btnGastosCamion
            // 
            this.btnGastosCamion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastosCamion.Location = new System.Drawing.Point(31, 198);
            this.btnGastosCamion.Name = "btnGastosCamion";
            this.btnGastosCamion.Size = new System.Drawing.Size(172, 59);
            this.btnGastosCamion.TabIndex = 13;
            this.btnGastosCamion.Text = "Gastos por Camion";
            this.btnGastosCamion.UseVisualStyleBackColor = true;
            this.btnGastosCamion.Click += new System.EventHandler(this.btnGastosCamion_Click);
            // 
            // btnCamion
            // 
            this.btnCamion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamion.Location = new System.Drawing.Point(31, 108);
            this.btnCamion.Name = "btnCamion";
            this.btnCamion.Size = new System.Drawing.Size(172, 59);
            this.btnCamion.TabIndex = 12;
            this.btnCamion.Text = "Kilometros por Camion";
            this.btnCamion.UseVisualStyleBackColor = true;
            this.btnCamion.Click += new System.EventHandler(this.btnCamion_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConex});
            this.statusStrip1.Location = new System.Drawing.Point(0, 454);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(844, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelConex
            // 
            this.toolStripStatusLabelConex.Name = "toolStripStatusLabelConex";
            this.toolStripStatusLabelConex.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelConex.Text = "toolStripStatusLabel1";
            // 
            // chartInfo
            // 
            chartArea1.Name = "ChartArea1";
            this.chartInfo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartInfo.Legends.Add(legend1);
            this.chartInfo.Location = new System.Drawing.Point(285, 40);
            this.chartInfo.Name = "chartInfo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartInfo.Series.Add(series1);
            this.chartInfo.Size = new System.Drawing.Size(537, 397);
            this.chartInfo.TabIndex = 10;
            this.chartInfo.Text = "chart1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 476);
            this.Controls.Add(this.btnGastosViaticos);
            this.Controls.Add(this.lblTipoGrafico);
            this.Controls.Add(this.progressBarCarga);
            this.Controls.Add(this.cboTipoGrafico);
            this.Controls.Add(this.btnKgCamion);
            this.Controls.Add(this.btnGastosCamion);
            this.Controls.Add(this.btnCamion);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chartInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGastosViaticos;
        private System.Windows.Forms.Label lblTipoGrafico;
        private System.Windows.Forms.ProgressBar progressBarCarga;
        private System.Windows.Forms.ComboBox cboTipoGrafico;
        private System.Windows.Forms.Button btnKgCamion;
        private System.Windows.Forms.Button btnGastosCamion;
        private System.Windows.Forms.Button btnCamion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConex;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInfo;
    }
}

