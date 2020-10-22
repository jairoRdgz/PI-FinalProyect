namespace Proyecto_Integrador
{
    partial class UserInterface
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.filtros = new System.Windows.Forms.ComboBox();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.filtrado = new System.Windows.Forms.TextBox();
            this.Home = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jobChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.housingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.debtChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.maritalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.Home.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housingChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maritalChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Filter:";
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(173, 22);
            this.path.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(0, 17);
            this.path.TabIndex = 34;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(16, 16);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(129, 28);
            this.btnLoad.TabIndex = 33;
            this.btnLoad.Text = "Load data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // filtros
            // 
            this.filtros.FormattingEnabled = true;
            this.filtros.Items.AddRange(new object[] {
            ""});
            this.filtros.Location = new System.Drawing.Point(65, 54);
            this.filtros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filtros.Name = "filtros";
            this.filtros.Size = new System.Drawing.Size(181, 24);
            this.filtros.TabIndex = 26;
            // 
            // tablaDatos
            // 
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Location = new System.Drawing.Point(12, 87);
            this.tablaDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.RowHeadersWidth = 51;
            this.tablaDatos.Size = new System.Drawing.Size(1281, 548);
            this.tablaDatos.TabIndex = 25;
            this.tablaDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDatos_CellContentClick);
            // 
            // filtrado
            // 
            this.filtrado.Location = new System.Drawing.Point(284, 55);
            this.filtrado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filtrado.Name = "filtrado";
            this.filtrado.Size = new System.Drawing.Size(456, 22);
            this.filtrado.TabIndex = 37;
            this.filtrado.TextChanged += new System.EventHandler(this.filtrado_TextChanged);
            // 
            // Home
            // 
            this.Home.Controls.Add(this.tabPage1);
            this.Home.Controls.Add(this.tabPage2);
            this.Home.Location = new System.Drawing.Point(16, 15);
            this.Home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Home.Name = "Home";
            this.Home.SelectedIndex = 0;
            this.Home.Size = new System.Drawing.Size(1345, 683);
            this.Home.TabIndex = 38;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tablaDatos);
            this.tabPage1.Controls.Add(this.filtrado);
            this.tabPage1.Controls.Add(this.filtros);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnLoad);
            this.tabPage1.Controls.Add(this.path);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1337, 654);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ageChart);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.jobChart);
            this.tabPage2.Controls.Add(this.housingChart);
            this.tabPage2.Controls.Add(this.debtChart);
            this.tabPage2.Controls.Add(this.maritalChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1337, 654);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graphics";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(704, 366);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "HOUSING CHART";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 366);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "DEBT CHART";
            // 
            // jobChart
            // 
            chartArea6.Name = "ChartArea1";
            this.jobChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.jobChart.Legends.Add(legend6);
            this.jobChart.Location = new System.Drawing.Point(436, 22);
            this.jobChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jobChart.Name = "jobChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.jobChart.Series.Add(series6);
            this.jobChart.Size = new System.Drawing.Size(413, 321);
            this.jobChart.TabIndex = 5;
            this.jobChart.Text = "chart5";
            this.jobChart.Click += new System.EventHandler(this.jobChart_Click);
            // 
            // housingChart
            // 
            chartArea7.Name = "ChartArea1";
            this.housingChart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.housingChart.Legends.Add(legend7);
            this.housingChart.Location = new System.Drawing.Point(708, 366);
            this.housingChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.housingChart.Name = "housingChart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.housingChart.Series.Add(series7);
            this.housingChart.Size = new System.Drawing.Size(593, 255);
            this.housingChart.TabIndex = 4;
            this.housingChart.Text = "HOUSING";
            title3.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title3.Name = "HOUSING";
            this.housingChart.Titles.Add(title3);
            // 
            // debtChart
            // 
            chartArea8.Name = "ChartArea1";
            this.debtChart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.debtChart.Legends.Add(legend8);
            this.debtChart.Location = new System.Drawing.Point(33, 366);
            this.debtChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.debtChart.Name = "debtChart";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.debtChart.Series.Add(series8);
            this.debtChart.Size = new System.Drawing.Size(609, 255);
            this.debtChart.TabIndex = 3;
            this.debtChart.Text = "DEBT";
            title4.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title4.Name = "DEBT";
            this.debtChart.Titles.Add(title4);
            // 
            // maritalChart
            // 
            chartArea9.Name = "ChartArea1";
            this.maritalChart.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.maritalChart.Legends.Add(legend9);
            this.maritalChart.Location = new System.Drawing.Point(880, 22);
            this.maritalChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maritalChart.Name = "maritalChart";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.maritalChart.Series.Add(series9);
            this.maritalChart.Size = new System.Drawing.Size(447, 321);
            this.maritalChart.TabIndex = 2;
            this.maritalChart.Text = "MARITAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(898, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "MARITAl";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(492, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "JOB ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "AGE";
            // 
            // ageChart
            // 
            chartArea10.Name = "ChartArea1";
            this.ageChart.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.ageChart.Legends.Add(legend10);
            this.ageChart.Location = new System.Drawing.Point(20, 28);
            this.ageChart.Name = "ageChart";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.ageChart.Series.Add(series10);
            this.ageChart.Size = new System.Drawing.Size(396, 291);
            this.ageChart.TabIndex = 11;
            this.ageChart.Text = "chart1";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 702);
            this.Controls.Add(this.Home);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserInterface";
            this.Text = "Client predictor";
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.Home.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housingChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maritalChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox filtros;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.TextBox filtrado;
        private System.Windows.Forms.TabControl Home;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart maritalChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart jobChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart housingChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart debtChart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart ageChart;
    }
}

