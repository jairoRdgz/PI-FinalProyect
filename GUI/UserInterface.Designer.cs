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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.filtros = new System.Windows.Forms.ComboBox();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.filtrado = new System.Windows.Forms.TextBox();
            this.Home = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.edades = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.Home.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edades)).BeginInit();
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
            this.tablaDatos.Size = new System.Drawing.Size(1653, 548);
            this.tablaDatos.TabIndex = 25;
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
            this.Home.Size = new System.Drawing.Size(1684, 683);
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
            this.tabPage1.Size = new System.Drawing.Size(1676, 654);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.edades);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1676, 654);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graphics";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // edades
            // 
            chartArea3.Name = "ChartArea1";
            this.edades.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.edades.Legends.Add(legend3);
            this.edades.Location = new System.Drawing.Point(61, 26);
            this.edades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edades.Name = "edades";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Edades";
            this.edades.Series.Add(series3);
            this.edades.Size = new System.Drawing.Size(725, 454);
            this.edades.TabIndex = 0;
            this.edades.Text = "Edades";
            title3.Name = "Grupos de edades";
            this.edades.Titles.Add(title3);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 702);
            this.Controls.Add(this.Home);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserInterface";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.Home.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edades)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart edades;
    }
}

