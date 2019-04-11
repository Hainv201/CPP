using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPP
{
    public partial class Form1 : Form
    {
        Formula infixFormula, derivativeFormula;
        LinearAxis xAxis, yAxis;
        Matrix matrix;
        public Form1()
        {
            InitializeComponent();
            matrix = new Matrix();
            yAxis = new LinearAxis()
            {
                Position = AxisPosition.Left,
                Minimum = -10,
                Maximum = 10,
                MinimumRange = -30,
                MaximumRange = 30,
                PositionAtZeroCrossing = true,
                ExtraGridlines = new double[] { 0 },
                ExtraGridlineThickness = 1,
                ExtraGridlineColor = OxyColors.Black,
            };

            xAxis = new LinearAxis()
            {
                Position = AxisPosition.Bottom,
                Minimum = -10,
                Maximum = 10,
                MinimumRange = -30,
                MaximumRange = 30,
                PositionAtZeroCrossing = true,
                ExtraGridlines = new double[] { 0 },
                ExtraGridlineThickness = 1,
                ExtraGridlineColor = OxyColors.Black,
            };
            plotView.Name = "Plot View";
            plotView.Model = new PlotModel();
            plotView.Model.PlotType = PlotType.XY;
            plotView.Model.Axes.Add(xAxis);
            plotView.Model.Axes.Add(yAxis);
        }

        private void parse_Click(object sender, EventArgs e)
        {
            if (prefixfunction.Text == "")
            {
                MessageBox.Show("Please input prefix first");
            }
            else
            {
                try
                {
                    infixFormula = new Formula(prefixfunction.Text);
                    infix.Items.Clear();
                    infix.Items.Add(infixFormula.RootFunction.ToString());
                    // Show Tree
                    int index = 1;
                    string str = "graph caculus { \r\nnode [] " + infixFormula.RootFunction.CreateGraph(ref index) + "\r\n}";
                    ShowTree(str, "binarytree");
                    //Plot Graph
                    plotView.Model.Series.Clear();
                    PlotGraph(infixFormula.GetFunctionSeries());
                    //Change Enable of button
                    derivative.Enabled = true;
                    newton.Enabled = true;
                    riemann.Enabled = true;
                    maclaurin.Enabled = true;
                    getPoints.Enabled = false;
                    //Print TESTED Formula
                    PrintFormula(prefixfunction.Text);
                    Console.WriteLine(infixFormula.RootFunction.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Warning!");
                }
            }
        }

        private void derivative_Click(object sender, EventArgs e)
        {
            derivativeFormula = new Formula(infixFormula.RootFunction.Derivatives());
            derivativeresult.Items.Clear();
            derivativeresult.Items.Add(derivativeFormula.RootFunction.ToString());
            //Show Tree
            int index = 1;
            string str = "graph caculus { \r\nnode [] " + derivativeFormula.RootFunction.CreateGraph(ref index) + "\r\n}";
            ShowTree(str, "derivativetree");
            //Plot Graph
            PlotGraph(derivativeFormula.GetFunctionSeries());
        }
        private void ShowTree(string str, string name)
        {
            File.WriteAllText($@"{name}.dot", str);

            Process dot = new Process();
            dot.StartInfo.FileName = @"dot.exe";
            dot.StartInfo.Arguments = $"-Tpng -o{name}.png {name}.dot";
            dot.Start();
            dot.WaitForExit();

            Process.Start($@"{name}.png");
        }

        private void clear_Click(object sender, EventArgs e)
        {
            // change button enable
            derivative.Enabled = false;
            newton.Enabled = false;
            riemann.Enabled = false;
            maclaurin.Enabled = false;
            getPoints.Enabled = true;
            polyGraph.Enabled = false;
            parse.Enabled = true;
            // clear textbox, listbox
            prefixfunction.Clear();
            infix.Items.Clear();
            derivativeresult.Items.Clear();
            upperboundary.Clear();
            lowerboundary.Clear();
            numericUpDown1.Value = 1;
            resultriemann.Text = "";
            //clear graph
            plotView.Model.Series.Clear();
            plotView.Model.InvalidatePlot(true);
        }

        private void riemann_Click(object sender, EventArgs e)
        {
            try
            {
                double lower = Convert.ToDouble(lowerboundary.Text);
                double upper = Convert.ToDouble(upperboundary.Text);
                AreaSeries areaSeries = new AreaSeries();
                for (double i = lower; i <= upper; i += 0.01)
                {
                    areaSeries.Points.Add(new DataPoint(i, infixFormula.RootFunction.CalculateValue(i)));

                }
                PlotGraph(areaSeries);
                resultriemann.Text = infixFormula.CalculateRiemannIntegral(lower, upper).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void maclaurin_Click(object sender, EventArgs e)
        {
            PlotGraph(infixFormula.GetMacLaurinSeries(Convert.ToInt32(numericUpDown1.Text)));
        }

        private void newton_Click(object sender, EventArgs e)
        {
            PlotGraph(infixFormula.NewtonSeries(infixFormula));
        }

        private void getPoints_Click(object sender, EventArgs e)
        {
            infix.Items.Clear();
            plotView.Model.Series.Clear();
            plotView.Model.InvalidatePlot(true);
            plotView.Model.MouseDown += plotView_MouseDown;
            polyGraph.Enabled = true;
            parse.Enabled = false;
        }

        private void polyGraph_Click(object sender, EventArgs e)
        {
            if (matrix.NrofPoint() == 0)
            {
                MessageBox.Show("Please get point first!");
                polyGraph.Enabled = false;
            }
            else
            {
                plotView.Model.MouseDown -= plotView_MouseDown;
                PlotGraph(matrix.GetPolynomialSeries());
                infix.Items.Add(matrix.GetFunction());
                matrix.EmptyDataPoints();
            }
        }

        private void plotView_MouseDown(object sender, OxyMouseDownEventArgs e)
        {
            ElementCollection<Axis> axisList = plotView.Model.Axes;
            Axis X_Axis = null;
            Axis Y_Axis = null;
            foreach (Axis axis in axisList)
            {
                if (axis.Position == AxisPosition.Bottom)
                    X_Axis = axis;
                else if (axis.Position == AxisPosition.Left)
                    Y_Axis = axis;
            }

            DataPoint datapoint = Axis.InverseTransform(e.Position, X_Axis, Y_Axis);
            matrix.AddPoint(datapoint);
            LineSeries lineSeries = new LineSeries();
            lineSeries.Color = OxyColors.LightBlue;
            lineSeries.MarkerFill = OxyColors.Blue;
            lineSeries.MarkerType = MarkerType.Circle;
            lineSeries.LineStyle = LineStyle.None;
            lineSeries.Points.Add(datapoint);
            lineSeries.Points.Add(new DataPoint());
            PlotGraph(lineSeries);
        }

        private void PlotGraph(Series series)
        {
            plotView.Model.Series.Add(series);
            plotView.Model.InvalidatePlot(true);
        }
        private void PrintFormula(string content)
        {
            string path = @"C:\Users\Hai Nguyen\Desktop\CPP\CPP\TestedFormula.txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("------- Tested Formula -------"+ Environment.NewLine);
                }
            }
            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"{content}" + Environment.NewLine);
            }
        }

    }
}
