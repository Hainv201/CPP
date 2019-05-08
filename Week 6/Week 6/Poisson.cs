using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Week_6
{
    class Poisson : Distribution
    {
        Random random = new Random();
        public Poisson():base()
        {
        }

        public override void GetVariate(int size, double lamda)
        {
            double sequences = lamda * 20;
            for (int i = 0; i < size; i++)
            {
                int count = 0;
                for(int j = 0; j < sequences; j++)
                {
                    int value = random.Next(0, (int)sequences);
                    if (value < lamda)
                    {
                        count++;
                    }
                }
                Samples.Add(count);
            }
        }
        public override double GetFunction(double x, double lamda)
        {
            double factorial = 1;
            for (int i = 1; i <= x; i++)
            {
                factorial *= i;
            }
            
            return Math.Exp(-lamda) * Math.Pow(lamda, x) / factorial;
        }

        public override void GetGraph(Chart chart, double lamda, int size)
        {
            chart.Series["Chart"].Points.Clear();
            chart.Series["Line"].Points.Clear();
            int maxsize = (int)Samples.Max();
            for (int i = 0; i < maxsize + 1; i++)
            {
                chart.Series["Line"].Points.AddXY(i, size * GetFunction(i, lamda));
            }
            double[] data = new double[maxsize + 1];
            for (int i = 0; i < maxsize + 1; i++)
            {
                data[i] = 0;
            }
            foreach (var item in Samples)
            {
                data[(int)item]++;
            }
            for (int i = 0; i < maxsize + 1; i++)
            {
                chart.Series["Chart"].Points.AddXY(i, data[i]);
            }
        }
    }
}
