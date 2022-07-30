namespace AlgoritmoScan
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_SCAN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_arreglo = new System.Windows.Forms.TextBox();
            this.txt_arreglo_ordenado = new System.Windows.Forms.TextBox();
            this.txt_recorrido_SCAN = new System.Windows.Forms.TextBox();
            this.txt_operaciones_scan = new System.Windows.Forms.TextBox();
            this.txt_numero_base = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_operaciones_sstf = new System.Windows.Forms.TextBox();
            this.btn_sstf = new System.Windows.Forms.Button();
            this.txt_recorrido_SSTF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_numero_base)).BeginInit();
            this.SuspendLayout();
            // 
            // chrt
            // 
            this.chrt.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chrt.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrt.Legends.Add(legend1);
            this.chrt.Location = new System.Drawing.Point(75, 94);
            this.chrt.Name = "chrt";
            this.chrt.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Arreglo";
            series1.ShadowColor = System.Drawing.Color.Black;
            series1.YValuesPerPoint = 6;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Arreglo_punto";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Arreglo Ordenado";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "ArregloOrdenado_punto";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.Legend = "Legend1";
            series5.Name = "Recorrido Scan";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "RecorridoScan_punto";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Recorrido SSTF";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend1";
            series8.Name = "RecorridoSSTF_punto";
            this.chrt.Series.Add(series1);
            this.chrt.Series.Add(series2);
            this.chrt.Series.Add(series3);
            this.chrt.Series.Add(series4);
            this.chrt.Series.Add(series5);
            this.chrt.Series.Add(series6);
            this.chrt.Series.Add(series7);
            this.chrt.Series.Add(series8);
            this.chrt.Size = new System.Drawing.Size(1006, 353);
            this.chrt.TabIndex = 0;
            this.chrt.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(933, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Crear Arreglo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_SCAN
            // 
            this.btn_SCAN.Enabled = false;
            this.btn_SCAN.Location = new System.Drawing.Point(415, 19);
            this.btn_SCAN.Name = "btn_SCAN";
            this.btn_SCAN.Size = new System.Drawing.Size(75, 23);
            this.btn_SCAN.TabIndex = 3;
            this.btn_SCAN.Text = "SCAN";
            this.btn_SCAN.UseVisualStyleBackColor = true;
            this.btn_SCAN.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número Base:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Arreglo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arreglo ordenado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Recorrido SCAN";
            // 
            // txt_arreglo
            // 
            this.txt_arreglo.Enabled = false;
            this.txt_arreglo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_arreglo.Location = new System.Drawing.Point(193, 462);
            this.txt_arreglo.Name = "txt_arreglo";
            this.txt_arreglo.Size = new System.Drawing.Size(888, 26);
            this.txt_arreglo.TabIndex = 8;
            // 
            // txt_arreglo_ordenado
            // 
            this.txt_arreglo_ordenado.Enabled = false;
            this.txt_arreglo_ordenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_arreglo_ordenado.Location = new System.Drawing.Point(193, 496);
            this.txt_arreglo_ordenado.Name = "txt_arreglo_ordenado";
            this.txt_arreglo_ordenado.Size = new System.Drawing.Size(888, 26);
            this.txt_arreglo_ordenado.TabIndex = 9;
            // 
            // txt_recorrido_SCAN
            // 
            this.txt_recorrido_SCAN.Enabled = false;
            this.txt_recorrido_SCAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_recorrido_SCAN.Location = new System.Drawing.Point(193, 531);
            this.txt_recorrido_SCAN.Name = "txt_recorrido_SCAN";
            this.txt_recorrido_SCAN.Size = new System.Drawing.Size(888, 26);
            this.txt_recorrido_SCAN.TabIndex = 10;
            // 
            // txt_operaciones_scan
            // 
            this.txt_operaciones_scan.Enabled = false;
            this.txt_operaciones_scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_operaciones_scan.Location = new System.Drawing.Point(396, 48);
            this.txt_operaciones_scan.Name = "txt_operaciones_scan";
            this.txt_operaciones_scan.Size = new System.Drawing.Size(111, 29);
            this.txt_operaciones_scan.TabIndex = 11;
            // 
            // txt_numero_base
            // 
            this.txt_numero_base.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero_base.Location = new System.Drawing.Point(176, 24);
            this.txt_numero_base.Name = "txt_numero_base";
            this.txt_numero_base.Size = new System.Drawing.Size(120, 26);
            this.txt_numero_base.TabIndex = 12;
            this.txt_numero_base.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Numero Operaciones: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Numero Operaciones: ";
            // 
            // txt_operaciones_sstf
            // 
            this.txt_operaciones_sstf.Enabled = false;
            this.txt_operaciones_sstf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_operaciones_sstf.Location = new System.Drawing.Point(712, 48);
            this.txt_operaciones_sstf.Name = "txt_operaciones_sstf";
            this.txt_operaciones_sstf.Size = new System.Drawing.Size(111, 29);
            this.txt_operaciones_sstf.TabIndex = 15;
            // 
            // btn_sstf
            // 
            this.btn_sstf.Enabled = false;
            this.btn_sstf.Location = new System.Drawing.Point(731, 19);
            this.btn_sstf.Name = "btn_sstf";
            this.btn_sstf.Size = new System.Drawing.Size(75, 23);
            this.btn_sstf.TabIndex = 14;
            this.btn_sstf.Text = "SSTF";
            this.btn_sstf.UseVisualStyleBackColor = true;
            this.btn_sstf.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txt_recorrido_SSTF
            // 
            this.txt_recorrido_SSTF.Enabled = false;
            this.txt_recorrido_SSTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_recorrido_SSTF.Location = new System.Drawing.Point(193, 571);
            this.txt_recorrido_SSTF.Name = "txt_recorrido_SSTF";
            this.txt_recorrido_SSTF.Size = new System.Drawing.Size(888, 26);
            this.txt_recorrido_SSTF.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 579);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Recorrido SSTF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 614);
            this.Controls.Add(this.txt_recorrido_SSTF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_operaciones_sstf);
            this.Controls.Add(this.btn_sstf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_numero_base);
            this.Controls.Add(this.txt_operaciones_scan);
            this.Controls.Add(this.txt_recorrido_SCAN);
            this.Controls.Add(this.txt_arreglo_ordenado);
            this.Controls.Add(this.txt_arreglo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SCAN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chrt);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chrt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_numero_base)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_SCAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_arreglo;
        private System.Windows.Forms.TextBox txt_arreglo_ordenado;
        private System.Windows.Forms.TextBox txt_recorrido_SCAN;
        private System.Windows.Forms.TextBox txt_operaciones_scan;
        private System.Windows.Forms.NumericUpDown txt_numero_base;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_operaciones_sstf;
        private System.Windows.Forms.Button btn_sstf;
        private System.Windows.Forms.TextBox txt_recorrido_SSTF;
        private System.Windows.Forms.Label label7;
    }
}

