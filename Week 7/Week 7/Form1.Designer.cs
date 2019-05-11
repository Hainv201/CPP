namespace Week_7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simulate = new System.Windows.Forms.Button();
            this.txbisconnected = new System.Windows.Forms.TextBox();
            this.txbprobability = new System.Windows.Forms.TextBox();
            this.txbnrofvertices = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btGraph = new System.Windows.Forms.Button();
            this.txbexperiments = new System.Windows.Forms.TextBox();
            this.txbverticesB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simulate);
            this.groupBox1.Controls.Add(this.txbisconnected);
            this.groupBox1.Controls.Add(this.txbprobability);
            this.groupBox1.Controls.Add(this.txbnrofvertices);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Part A";
            // 
            // simulate
            // 
            this.simulate.Location = new System.Drawing.Point(79, 95);
            this.simulate.Name = "simulate";
            this.simulate.Size = new System.Drawing.Size(75, 23);
            this.simulate.TabIndex = 6;
            this.simulate.Text = "Simulate";
            this.simulate.UseVisualStyleBackColor = true;
            this.simulate.Click += new System.EventHandler(this.simulate_Click);
            // 
            // txbisconnected
            // 
            this.txbisconnected.ForeColor = System.Drawing.Color.White;
            this.txbisconnected.Location = new System.Drawing.Point(112, 69);
            this.txbisconnected.Name = "txbisconnected";
            this.txbisconnected.ReadOnly = true;
            this.txbisconnected.Size = new System.Drawing.Size(124, 20);
            this.txbisconnected.TabIndex = 5;
            // 
            // txbprobability
            // 
            this.txbprobability.Location = new System.Drawing.Point(112, 43);
            this.txbprobability.Name = "txbprobability";
            this.txbprobability.Size = new System.Drawing.Size(124, 20);
            this.txbprobability.TabIndex = 4;
            // 
            // txbnrofvertices
            // 
            this.txbnrofvertices.Location = new System.Drawing.Point(112, 17);
            this.txbnrofvertices.Name = "txbnrofvertices";
            this.txbnrofvertices.Size = new System.Drawing.Size(124, 20);
            this.txbnrofvertices.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Is Connected?:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Probability:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of vertices:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btGraph);
            this.groupBox2.Controls.Add(this.txbexperiments);
            this.groupBox2.Controls.Add(this.txbverticesB);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(272, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 128);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Part B";
            // 
            // btGraph
            // 
            this.btGraph.Location = new System.Drawing.Point(75, 82);
            this.btGraph.Name = "btGraph";
            this.btGraph.Size = new System.Drawing.Size(75, 23);
            this.btGraph.TabIndex = 9;
            this.btGraph.Text = "Graph";
            this.btGraph.UseVisualStyleBackColor = true;
            this.btGraph.Click += new System.EventHandler(this.btGraph_Click);
            // 
            // txbexperiments
            // 
            this.txbexperiments.Location = new System.Drawing.Point(111, 43);
            this.txbexperiments.Name = "txbexperiments";
            this.txbexperiments.Size = new System.Drawing.Size(124, 20);
            this.txbexperiments.TabIndex = 8;
            // 
            // txbverticesB
            // 
            this.txbverticesB.Location = new System.Drawing.Point(111, 17);
            this.txbverticesB.Name = "txbverticesB";
            this.txbverticesB.Size = new System.Drawing.Size(124, 20);
            this.txbverticesB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Experiments:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Number of vertices:";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(538, 52);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(50, 50);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(13, 160);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "AVG";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "ln(n)/n";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(586, 300);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 487);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Clear);
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

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button simulate;
        private System.Windows.Forms.TextBox txbisconnected;
        private System.Windows.Forms.TextBox txbprobability;
        private System.Windows.Forms.TextBox txbnrofvertices;
        private System.Windows.Forms.Button btGraph;
        private System.Windows.Forms.TextBox txbexperiments;
        private System.Windows.Forms.TextBox txbverticesB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

