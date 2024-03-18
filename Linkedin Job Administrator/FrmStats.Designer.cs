namespace Linkedin_Job_Administrator
{
    partial class FrmStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btSemana = new System.Windows.Forms.Button();
            this.btEstado = new System.Windows.Forms.Button();
            this.btEmpresa = new System.Windows.Forms.Button();
            this.btPuesto = new System.Windows.Forms.Button();
            this.btMes = new System.Windows.Forms.Button();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 65);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(1256, 459);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // btSemana
            // 
            this.btSemana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(168)))));
            this.btSemana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSemana.FlatAppearance.BorderSize = 0;
            this.btSemana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(89)))), ((int)(((byte)(102)))));
            this.btSemana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(151)))));
            this.btSemana.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSemana.ForeColor = System.Drawing.SystemColors.Control;
            this.btSemana.Location = new System.Drawing.Point(12, 12);
            this.btSemana.Name = "btSemana";
            this.btSemana.Size = new System.Drawing.Size(107, 47);
            this.btSemana.TabIndex = 1;
            this.btSemana.Text = "Dia Semana";
            this.btSemana.UseVisualStyleBackColor = false;
            this.btSemana.Click += new System.EventHandler(this.MostrarGraficoPorDiaSemana);
            // 
            // btEstado
            // 
            this.btEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(168)))));
            this.btEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEstado.FlatAppearance.BorderSize = 0;
            this.btEstado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(89)))), ((int)(((byte)(102)))));
            this.btEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(151)))));
            this.btEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEstado.ForeColor = System.Drawing.SystemColors.Control;
            this.btEstado.Location = new System.Drawing.Point(238, 12);
            this.btEstado.Name = "btEstado";
            this.btEstado.Size = new System.Drawing.Size(107, 47);
            this.btEstado.TabIndex = 2;
            this.btEstado.Text = "Estado";
            this.btEstado.UseVisualStyleBackColor = false;
            this.btEstado.Click += new System.EventHandler(this.MostrarGraficoPorEstado);
            // 
            // btEmpresa
            // 
            this.btEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(168)))));
            this.btEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEmpresa.FlatAppearance.BorderSize = 0;
            this.btEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(89)))), ((int)(((byte)(102)))));
            this.btEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(151)))));
            this.btEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmpresa.ForeColor = System.Drawing.SystemColors.Control;
            this.btEmpresa.Location = new System.Drawing.Point(351, 12);
            this.btEmpresa.Name = "btEmpresa";
            this.btEmpresa.Size = new System.Drawing.Size(107, 47);
            this.btEmpresa.TabIndex = 3;
            this.btEmpresa.Text = "Empresa";
            this.btEmpresa.UseVisualStyleBackColor = false;
            this.btEmpresa.Click += new System.EventHandler(this.MostrarGraficoPorEmpresa);
            // 
            // btPuesto
            // 
            this.btPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(168)))));
            this.btPuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPuesto.FlatAppearance.BorderSize = 0;
            this.btPuesto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(89)))), ((int)(((byte)(102)))));
            this.btPuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(151)))));
            this.btPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPuesto.ForeColor = System.Drawing.SystemColors.Control;
            this.btPuesto.Location = new System.Drawing.Point(464, 12);
            this.btPuesto.Name = "btPuesto";
            this.btPuesto.Size = new System.Drawing.Size(107, 47);
            this.btPuesto.TabIndex = 4;
            this.btPuesto.Text = "Puesto";
            this.btPuesto.UseVisualStyleBackColor = false;
            this.btPuesto.Click += new System.EventHandler(this.MostrarGraficoPorPuesto);
            // 
            // btMes
            // 
            this.btMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(168)))));
            this.btMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMes.FlatAppearance.BorderSize = 0;
            this.btMes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(89)))), ((int)(((byte)(102)))));
            this.btMes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(151)))));
            this.btMes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMes.ForeColor = System.Drawing.SystemColors.Control;
            this.btMes.Location = new System.Drawing.Point(125, 12);
            this.btMes.Name = "btMes";
            this.btMes.Size = new System.Drawing.Size(107, 47);
            this.btMes.TabIndex = 5;
            this.btMes.Text = "Mes";
            this.btMes.UseVisualStyleBackColor = false;
            this.btMes.Click += new System.EventHandler(this.MostrarGraficoPorMes);
            // 
            // cbStyle
            // 
            this.cbStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Location = new System.Drawing.Point(1070, 26);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(198, 33);
            this.cbStyle.TabIndex = 6;
            this.cbStyle.SelectedIndexChanged += new System.EventHandler(this.cbStyle_SelectedIndexChanged);
            // 
            // FrmStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1280, 536);
            this.Controls.Add(this.cbStyle);
            this.Controls.Add(this.btMes);
            this.Controls.Add(this.btPuesto);
            this.Controls.Add(this.btEmpresa);
            this.Controls.Add(this.btEstado);
            this.Controls.Add(this.btSemana);
            this.Controls.Add(this.chart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStats";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btSemana;
        private System.Windows.Forms.Button btEstado;
        private System.Windows.Forms.Button btEmpresa;
        private System.Windows.Forms.Button btPuesto;
        private System.Windows.Forms.Button btMes;
        private System.Windows.Forms.ComboBox cbStyle;
    }
}