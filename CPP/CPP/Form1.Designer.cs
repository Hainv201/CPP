namespace CPP
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
            this.parse = new System.Windows.Forms.Button();
            this.prefixfunction = new System.Windows.Forms.TextBox();
            this.infix = new System.Windows.Forms.ListBox();
            this.derivative = new System.Windows.Forms.Button();
            this.plotView = new OxyPlot.WindowsForms.PlotView();
            this.derivativeresult = new System.Windows.Forms.ListBox();
            this.newton = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultriemann = new System.Windows.Forms.TextBox();
            this.riemann = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.upperboundary = new System.Windows.Forms.TextBox();
            this.lowerboundary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maclaurin = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.polyGraph = new System.Windows.Forms.Button();
            this.getPoints = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // parse
            // 
            this.parse.Location = new System.Drawing.Point(39, 13);
            this.parse.Name = "parse";
            this.parse.Size = new System.Drawing.Size(75, 23);
            this.parse.TabIndex = 0;
            this.parse.Text = "Parse";
            this.parse.UseVisualStyleBackColor = true;
            this.parse.Click += new System.EventHandler(this.parse_Click);
            // 
            // prefixfunction
            // 
            this.prefixfunction.Location = new System.Drawing.Point(156, 13);
            this.prefixfunction.Name = "prefixfunction";
            this.prefixfunction.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.prefixfunction.Size = new System.Drawing.Size(450, 20);
            this.prefixfunction.TabIndex = 1;
            // 
            // infix
            // 
            this.infix.FormattingEnabled = true;
            this.infix.HorizontalScrollbar = true;
            this.infix.Location = new System.Drawing.Point(156, 39);
            this.infix.Name = "infix";
            this.infix.Size = new System.Drawing.Size(450, 43);
            this.infix.TabIndex = 2;
            // 
            // derivative
            // 
            this.derivative.Enabled = false;
            this.derivative.Location = new System.Drawing.Point(39, 42);
            this.derivative.Name = "derivative";
            this.derivative.Size = new System.Drawing.Size(75, 23);
            this.derivative.TabIndex = 5;
            this.derivative.Text = "Derivative";
            this.derivative.UseVisualStyleBackColor = true;
            this.derivative.Click += new System.EventHandler(this.derivative_Click);
            // 
            // plotView
            // 
            this.plotView.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.plotView.Location = new System.Drawing.Point(156, 135);
            this.plotView.Margin = new System.Windows.Forms.Padding(1);
            this.plotView.Name = "plotView";
            this.plotView.PanCursor = System.Windows.Forms.Cursors.Cross;
            this.plotView.Size = new System.Drawing.Size(450, 450);
            this.plotView.TabIndex = 12;
            this.plotView.Text = "plotView";
            this.plotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.Cross;
            this.plotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.Cross;
            this.plotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.Cross;
            // 
            // derivativeresult
            // 
            this.derivativeresult.FormattingEnabled = true;
            this.derivativeresult.HorizontalScrollbar = true;
            this.derivativeresult.Location = new System.Drawing.Point(156, 88);
            this.derivativeresult.Name = "derivativeresult";
            this.derivativeresult.Size = new System.Drawing.Size(450, 43);
            this.derivativeresult.TabIndex = 7;
            // 
            // newton
            // 
            this.newton.Enabled = false;
            this.newton.Location = new System.Drawing.Point(39, 71);
            this.newton.Name = "newton";
            this.newton.Size = new System.Drawing.Size(75, 23);
            this.newton.TabIndex = 8;
            this.newton.Text = "Newton";
            this.newton.UseVisualStyleBackColor = true;
            this.newton.Click += new System.EventHandler(this.newton_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(39, 100);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 13;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resultriemann);
            this.groupBox1.Controls.Add(this.riemann);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.upperboundary);
            this.groupBox1.Controls.Add(this.lowerboundary);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 169);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Riemann integral";
            // 
            // resultriemann
            // 
            this.resultriemann.Enabled = false;
            this.resultriemann.Location = new System.Drawing.Point(7, 135);
            this.resultriemann.Name = "resultriemann";
            this.resultriemann.Size = new System.Drawing.Size(115, 20);
            this.resultriemann.TabIndex = 5;
            // 
            // riemann
            // 
            this.riemann.Enabled = false;
            this.riemann.Location = new System.Drawing.Point(27, 106);
            this.riemann.Name = "riemann";
            this.riemann.Size = new System.Drawing.Size(75, 23);
            this.riemann.TabIndex = 4;
            this.riemann.Text = "Calculate";
            this.riemann.UseVisualStyleBackColor = true;
            this.riemann.Click += new System.EventHandler(this.riemann_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Upper Boundary";
            // 
            // upperboundary
            // 
            this.upperboundary.Location = new System.Drawing.Point(6, 80);
            this.upperboundary.Name = "upperboundary";
            this.upperboundary.Size = new System.Drawing.Size(116, 20);
            this.upperboundary.TabIndex = 2;
            // 
            // lowerboundary
            // 
            this.lowerboundary.Location = new System.Drawing.Point(7, 37);
            this.lowerboundary.Name = "lowerboundary";
            this.lowerboundary.Size = new System.Drawing.Size(115, 20);
            this.lowerboundary.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lower Boundary";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maclaurin);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Location = new System.Drawing.Point(12, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 77);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Maclaurin Series";
            // 
            // maclaurin
            // 
            this.maclaurin.Enabled = false;
            this.maclaurin.Location = new System.Drawing.Point(27, 46);
            this.maclaurin.Name = "maclaurin";
            this.maclaurin.Size = new System.Drawing.Size(75, 23);
            this.maclaurin.TabIndex = 6;
            this.maclaurin.Text = "Calculate";
            this.maclaurin.UseVisualStyleBackColor = true;
            this.maclaurin.Click += new System.EventHandler(this.maclaurin_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(7, 20);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(115, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.polyGraph);
            this.groupBox3.Controls.Add(this.getPoints);
            this.groupBox3.Location = new System.Drawing.Point(12, 389);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 81);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Polynomial";
            // 
            // polyGraph
            // 
            this.polyGraph.Enabled = false;
            this.polyGraph.Location = new System.Drawing.Point(0, 49);
            this.polyGraph.Name = "polyGraph";
            this.polyGraph.Size = new System.Drawing.Size(128, 23);
            this.polyGraph.TabIndex = 1;
            this.polyGraph.Text = "Graph and Results";
            this.polyGraph.UseVisualStyleBackColor = true;
            this.polyGraph.Click += new System.EventHandler(this.polyGraph_Click);
            // 
            // getPoints
            // 
            this.getPoints.Location = new System.Drawing.Point(0, 20);
            this.getPoints.Name = "getPoints";
            this.getPoints.Size = new System.Drawing.Size(128, 23);
            this.getPoints.TabIndex = 0;
            this.getPoints.Text = "Get Points";
            this.getPoints.UseVisualStyleBackColor = true;
            this.getPoints.Click += new System.EventHandler(this.getPoints_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 601);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.newton);
            this.Controls.Add(this.derivativeresult);
            this.Controls.Add(this.plotView);
            this.Controls.Add(this.derivative);
            this.Controls.Add(this.infix);
            this.Controls.Add(this.prefixfunction);
            this.Controls.Add(this.parse);
            this.Name = "Form1";
            this.Text = "Viet Hai Nguyen-CPP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button parse;
        private System.Windows.Forms.TextBox prefixfunction;
        private System.Windows.Forms.ListBox infix;
        private System.Windows.Forms.Button derivative;
        private OxyPlot.WindowsForms.PlotView plotView;
        private System.Windows.Forms.ListBox derivativeresult;
        private System.Windows.Forms.Button newton;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button riemann;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox upperboundary;
        private System.Windows.Forms.TextBox lowerboundary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultriemann;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button maclaurin;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button polyGraph;
        private System.Windows.Forms.Button getPoints;
    }
}

