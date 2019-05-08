using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_6
{
    public partial class Form1 : Form
    {
        Distribution distribution;
        double lamda;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (poisson.Checked)
                {
                    distribution = new Poisson();
                }
                else if (exponential.Checked)
                {
                    distribution = new Exponential();
                }
                lamda = Convert.ToDouble(lamdaA.Text);
                int sizes = Convert.ToInt32(size.Text);
                distribution.GetVariate(sizes, lamda);
                mean.Text = distribution.GetMean(distribution.Samples).ToString();
                variance.Text = distribution.GetVariance(distribution.Samples).ToString();
                sdeviation.Text = distribution.GetStandardDeviation().ToString();
                distribution.GetGraph(chart1, lamda,sizes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            size.Clear();
            lamdaA.Clear();
            lamdaB.Clear();
            mean.Clear();
            variance.Clear();
            sdeviation.Clear();
            poisson.Checked = false;
            exponential.Checked = false;
            events.Clear();
            interval.Clear();
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }

        private void prove_Click(object sender, EventArgs e)
        {
            double Blamda = Convert.ToDouble(lamdaB.Text);
            int nrofevents = Convert.ToInt32(events.Text);
            int Binterval = Convert.ToInt32(interval.Text);
            Exponential expo = new Exponential();
            expo.GetVariate(nrofevents, Blamda);
            List<double> SimulationSamples = expo.GetSimulationSamples(Binterval);
            mean.Text = expo.GetMean(SimulationSamples).ToString();
            variance.Text = expo.GetVariance(SimulationSamples).ToString();
            sdeviation.Text = expo.GetStandardDeviation().ToString();
            Poisson poisson = new Poisson();
            poisson.Samples = SimulationSamples;
            poisson.GetGraph(chart1, Blamda, SimulationSamples.Count);
        }
    }
}
