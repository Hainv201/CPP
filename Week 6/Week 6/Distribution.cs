using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Week_6
{
    abstract class Distribution
    {
        public List<double> Samples { get; set; }
        double mean, variance;
        public Distribution()
        {
            Samples = new List<double>();
        }
        public double GetMean(List<double> samples)
        {
            double sum = 0;
            for (int i = 0; i < samples.Count; i++)
            {
                sum += samples[i];
            }
            mean = sum / samples.Count;
            return mean;
        }
        public double GetVariance(List<double> samples)
        {
            double total = 0;
            for (int i = 0; i < samples.Count; i++)
            {
                total += Math.Pow(samples[i] - mean, 2);
            }
            variance = total / samples.Count;
            return variance;
        }
        public double GetStandardDeviation()
        {
            return Math.Sqrt(variance);
        }
        public abstract void GetVariate(int size, double lamda);
        public abstract double GetFunction(double x, double lamda);
        public abstract void GetGraph(Chart chart, double lamda, int sizeS);
    }
}
