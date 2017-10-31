namespace AlphaCut
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPilih = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxTitikA = new System.Windows.Forms.TextBox();
            this.textboxTitikB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxTitikC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxTitikD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPlot = new System.Windows.Forms.Button();
            this.textboxAlphaCut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxHasilAlphaCut = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCut = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menghitung Membership Function";
            // 
            // comboBoxPilih
            // 
            this.comboBoxPilih.FormattingEnabled = true;
            this.comboBoxPilih.Items.AddRange(new object[] {
            "Trapesium",
            "Segitiga"});
            this.comboBoxPilih.Location = new System.Drawing.Point(25, 79);
            this.comboBoxPilih.Name = "comboBoxPilih";
            this.comboBoxPilih.Size = new System.Drawing.Size(141, 21);
            this.comboBoxPilih.TabIndex = 1;
            this.comboBoxPilih.Text = "Pilih Gambar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titik A";
            // 
            // textboxTitikA
            // 
            this.textboxTitikA.Location = new System.Drawing.Point(108, 106);
            this.textboxTitikA.Name = "textboxTitikA";
            this.textboxTitikA.Size = new System.Drawing.Size(58, 20);
            this.textboxTitikA.TabIndex = 3;
            // 
            // textboxTitikB
            // 
            this.textboxTitikB.Location = new System.Drawing.Point(108, 132);
            this.textboxTitikB.Name = "textboxTitikB";
            this.textboxTitikB.Size = new System.Drawing.Size(58, 20);
            this.textboxTitikB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Titik B";
            // 
            // textboxTitikC
            // 
            this.textboxTitikC.Location = new System.Drawing.Point(108, 158);
            this.textboxTitikC.Name = "textboxTitikC";
            this.textboxTitikC.Size = new System.Drawing.Size(58, 20);
            this.textboxTitikC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Titik C";
            // 
            // textboxTitikD
            // 
            this.textboxTitikD.Location = new System.Drawing.Point(108, 184);
            this.textboxTitikD.Name = "textboxTitikD";
            this.textboxTitikD.Size = new System.Drawing.Size(58, 20);
            this.textboxTitikD.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Titik D";
            // 
            // buttonPlot
            // 
            this.buttonPlot.Location = new System.Drawing.Point(108, 210);
            this.buttonPlot.Name = "buttonPlot";
            this.buttonPlot.Size = new System.Drawing.Size(58, 23);
            this.buttonPlot.TabIndex = 10;
            this.buttonPlot.Text = "Plot";
            this.buttonPlot.UseVisualStyleBackColor = true;
            this.buttonPlot.Click += new System.EventHandler(this.buttonPlot_Click);
            // 
            // textboxAlphaCut
            // 
            this.textboxAlphaCut.Location = new System.Drawing.Point(108, 255);
            this.textboxAlphaCut.Name = "textboxAlphaCut";
            this.textboxAlphaCut.Size = new System.Drawing.Size(58, 20);
            this.textboxAlphaCut.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alpha";
            // 
            // textboxHasilAlphaCut
            // 
            this.textboxHasilAlphaCut.Location = new System.Drawing.Point(108, 327);
            this.textboxHasilAlphaCut.Name = "textboxHasilAlphaCut";
            this.textboxHasilAlphaCut.Size = new System.Drawing.Size(58, 20);
            this.textboxHasilAlphaCut.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hasil Alpha Cut";
            // 
            // buttonCut
            // 
            this.buttonCut.Location = new System.Drawing.Point(108, 281);
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(58, 23);
            this.buttonCut.TabIndex = 15;
            this.buttonCut.Text = "Cut";
            this.buttonCut.UseVisualStyleBackColor = true;
            this.buttonCut.Click += new System.EventHandler(this.buttonCut_Click);
            // 
            // chart1
            // 
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(183, 79);
            this.chart1.Name = "chart1";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.Name = "Gambar";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Gold;
            series6.Legend = "Legend1";
            series6.Name = "Potong";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.LimeGreen;
            series7.Legend = "Legend1";
            series7.Name = "X1";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.LimeGreen;
            series8.Legend = "Legend1";
            series8.Name = "X2";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(427, 312);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(70, 368);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(58, 23);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 403);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonCut);
            this.Controls.Add(this.textboxHasilAlphaCut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textboxAlphaCut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonPlot);
            this.Controls.Add(this.textboxTitikD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textboxTitikC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxTitikB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxTitikA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPilih);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Menghitung Membership Function";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPilih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxTitikA;
        private System.Windows.Forms.TextBox textboxTitikB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxTitikC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxTitikD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPlot;
        private System.Windows.Forms.TextBox textboxAlphaCut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxHasilAlphaCut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCut;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonReset;
    }
}

