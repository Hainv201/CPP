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

namespace Week_7
{
    public partial class Form1 : Form
    {
        Network network;
        Random randseed;
        public Form1()
        {
            InitializeComponent();
            randseed = new Random();
        }

        private void simulate_Click(object sender, EventArgs e)
        {
            try
            {
                int nrvertices = Convert.ToInt32(txbnrofvertices.Text);
                double p = Convert.ToDouble(txbprobability.Text);
                network = new Network(randseed, nrvertices);
                network.AddEdges(p);
                string str = "graph {\r\n" + network.PrintGraph() + "\r\n}";
                ShowGraph(str);
                if (network.IsConnected())
                {
                    txbisconnected.Text = "True";
                    txbisconnected.BackColor = Color.LimeGreen;
                }
                else
                {
                    txbisconnected.Text = "False";
                    txbisconnected.BackColor = Color.Red;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void ShowGraph(string str)
        {
            File.WriteAllText($@"Week7.dot", str);
            Process dot = new Process();
            dot.StartInfo.FileName = @"dot.exe";
            dot.StartInfo.Arguments = $"-Tpng -oWeek7.png Week7.dot";
            dot.Start();
            dot.WaitForExit();
            Process.Start($@"Week7.png");
        }

        private void btGraph_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(txbverticesB.Text);
                int experiments = Convert.ToInt32(txbexperiments.Text);
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                double[] data = GetAVG(experiments, n);
                for (double i = 0; i <= 1; i += 0.01)
                {
                    chart1.Series[1].Points.AddXY(i, Math.Log(n) / n);
                    chart1.Series[0].Points.AddXY(i, data[(int)(i * 100)]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private double[] GetAVG(int ex, int n)
        {
            double[] data = new double[101];

           
            for (double i = 0; i <=1; i+=0.01)
            {
                double connectedtimes = 0;
                for (int j = 0; j < ex; j++)
                {
                    network = new Network(randseed, n);
                    network.AddEdges(i);
                    if (network.IsConnected())
                    {
                        connectedtimes++;
                    }
                }
                data[(int)(i * 100)] = connectedtimes /ex;
            }
            return data;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txbexperiments.Clear();
            txbisconnected.Clear();
            txbnrofvertices.Clear();
            txbprobability.Clear();
            txbverticesB.Clear();
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            txbisconnected.BackColor = Color.LightGray;
        }
    }
}
