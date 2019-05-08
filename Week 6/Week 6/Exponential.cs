using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Week_6
{
    class Exponential : Distribution
    {
        Random random = new Random();
        public Exponential() : base()
        {
        }

        public override void GetVariate(int size, double lamda)
        {
            for (int i = 0; i < size; i++)
            {
                double uniform = random.NextDouble();
                double variate = -Math.Log(1 - uniform) / lamda;
                Samples.Add(variate);
            }
        }

        public override double GetFunction(double x, double lamda)
        {
            return lamda * Math.Exp(-lamda * x);
        }

        public override void GetGraph(Chart chart, double lamda, int size)
        {
            chart.Series["Chart"].Points.Clear();
            chart.Series["Line"].Points.Clear();
            int maxsize = (int)Samples.Max() + 1;
            double[] data = new double[maxsize];
            for (int i = 0; i < maxsize; i++)
            {
                data[i] = 0;
            }
            foreach (var item in Samples)
            {
                int value = (int)item;
                data[value]++;
            }
            for (int i = 0; i < maxsize; i++)
            {
                chart.Series["Chart"].Points.AddXY(i, data[i]);
            }
            for (int i = 0; i < maxsize; i++)
            {
                chart.Series["Line"].Points.AddXY(i, GetFunction(i, lamda) * size);
            }
        }

        // Part B

        public List<double> GetSimulationSamples(int interval)
        {
            List<double> SimulationSamples = new List<double>();
            double totaltime = 0; 
            int nrofevents = 0;
            foreach (double variatie in Samples)
            {
                totaltime += variatie * interval;
                nrofevents++;
                if (totaltime >= interval)
                {
                    SimulationSamples.Add(nrofevents);
                    totaltime -= interval;
                    nrofevents = 0;
                }
            }
            return SimulationSamples;
        }
    }
}
