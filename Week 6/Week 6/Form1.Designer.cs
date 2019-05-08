namespace Week_6
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calculate = new System.Windows.Forms.Button();
            this.exponential = new System.Windows.Forms.RadioButton();
            this.poisson = new System.Windows.Forms.RadioButton();
            this.lamdaA = new System.Windows.Forms.TextBox();
            this.size = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.prove = new System.Windows.Forms.Button();
            this.interval = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.events = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lamdaB = new System.Windows.Forms.TextBox();
            this.lblamda = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sdeviation = new System.Windows.Forms.TextBox();
            this.mean = new System.Windows.Forms.TextBox();
            this.variance = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calculate);
            this.groupBox1.Controls.Add(this.exponential);
            this.groupBox1.Controls.Add(this.poisson);
            this.groupBox1.Controls.Add(this.lamdaA);
            this.groupBox1.Controls.Add(this.size);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Week 6 A";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(54, 109);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 6;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // exponential
            // 
            this.exponential.AutoSize = true;
            this.exponential.Location = new System.Drawing.Point(100, 77);
            this.exponential.Name = "exponential";
            this.exponential.Size = new System.Drawing.Size(80, 17);
            this.exponential.TabIndex = 5;
            this.exponential.TabStop = true;
            this.exponential.Text = "Exponential";
            this.exponential.UseVisualStyleBackColor = true;
            // 
            // poisson
            // 
            this.poisson.AutoSize = true;
            this.poisson.Location = new System.Drawing.Point(9, 77);
            this.poisson.Name = "poisson";
            this.poisson.Size = new System.Drawing.Size(62, 17);
            this.poisson.TabIndex = 4;
            this.poisson.TabStop = true;
            this.poisson.Text = "Poisson";
            this.poisson.UseVisualStyleBackColor = true;
            // 
            // lamdaA
            // 
            this.lamdaA.Location = new System.Drawing.Point(68, 39);
            this.lamdaA.Name = "lamdaA";
            this.lamdaA.Size = new System.Drawing.Size(126, 20);
            this.lamdaA.TabIndex = 3;
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(68, 13);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(126, 20);
            this.size.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lamda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.prove);
            this.groupBox2.Controls.Add(this.interval);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.events);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lamdaB);
            this.groupBox2.Controls.Add(this.lblamda);
            this.groupBox2.Location = new System.Drawing.Point(219, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 151);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Week 6 B";
            // 
            // prove
            // 
            this.prove.Location = new System.Drawing.Point(78, 109);
            this.prove.Name = "prove";
            this.prove.Size = new System.Drawing.Size(75, 23);
            this.prove.TabIndex = 6;
            this.prove.Text = "Prove";
            this.prove.UseVisualStyleBackColor = true;
            this.prove.Click += new System.EventHandler(this.prove_Click);
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(110, 65);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(120, 20);
            this.interval.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Interval:";
            // 
            // events
            // 
            this.events.Location = new System.Drawing.Point(110, 39);
            this.events.Name = "events";
            this.events.Size = new System.Drawing.Size(120, 20);
            this.events.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of events:";
            // 
            // lamdaB
            // 
            this.lamdaB.Location = new System.Drawing.Point(110, 13);
            this.lamdaB.Name = "lamdaB";
            this.lamdaB.Size = new System.Drawing.Size(120, 20);
            this.lamdaB.TabIndex = 1;
            // 
            // lblamda
            // 
            this.lblamda.AutoSize = true;
            this.lblamda.Location = new System.Drawing.Point(6, 16);
            this.lblamda.Name = "lblamda";
            this.lblamda.Size = new System.Drawing.Size(42, 13);
            this.lblamda.TabIndex = 0;
            this.lblamda.Text = "Lamda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mean:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Standard Deviation:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Variance:";
            // 
            // sdeviation
            // 
            this.sdeviation.Location = new System.Drawing.Point(577, 78);
            this.sdeviation.Name = "sdeviation";
            this.sdeviation.ReadOnly = true;
            this.sdeviation.Size = new System.Drawing.Size(120, 20);
            this.sdeviation.TabIndex = 7;
            // 
            // mean
            // 
            this.mean.Location = new System.Drawing.Point(577, 26);
            this.mean.Name = "mean";
            this.mean.ReadOnly = true;
            this.mean.Size = new System.Drawing.Size(120, 20);
            this.mean.TabIndex = 8;
            // 
            // variance
            // 
            this.variance.Location = new System.Drawing.Point(577, 52);
            this.variance.Name = "variance";
            this.variance.ReadOnly = true;
            this.variance.Size = new System.Drawing.Size(120, 20);
            this.variance.TabIndex = 9;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(557, 122);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(13, 170);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Chart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Line";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(684, 351);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 539);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.variance);
            this.Controls.Add(this.mean);
            this.Controls.Add(this.sdeviation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.RadioButton exponential;
        private System.Windows.Forms.RadioButton poisson;
        private System.Windows.Forms.TextBox lamdaA;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button prove;
        private System.Windows.Forms.TextBox interval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox events;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lamdaB;
        private System.Windows.Forms.Label lblamda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sdeviation;
        private System.Windows.Forms.TextBox mean;
        private System.Windows.Forms.TextBox variance;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

