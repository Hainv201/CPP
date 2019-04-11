using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    public class Matrix
    {
        List<DataPoint> dataPoints;
        double[,] matrix;
        int order, nrofRow;
        public Matrix()
        {
            dataPoints = new List<DataPoint>();
        }
        public void AddPoint(DataPoint p)
        {
            dataPoints.Add(p);
        }
        public void EmptyDataPoints()
        {
            dataPoints.Clear();
        }
        public int NrofPoint()
        {
            return dataPoints.Count();
        }
        private void GetMatrix()
        {
            order = dataPoints.Count - 1;
            nrofRow = dataPoints.Count;
            matrix = new double[nrofRow, nrofRow + 1];
            for (int i = 0; i < nrofRow; i++)
            {
                double degree = order;
                for (int j = 0; j < nrofRow; j++)
                {
                    matrix[i, j] = Math.Pow(dataPoints[i].X, degree);
                    degree--;
                }
                matrix[i, nrofRow] = dataPoints[i].Y;
            }
        }
        public double[] CalculateCoefficients()
        {
            double[] coefficients = new double[nrofRow];
            //Reduced row echelon form of an matrix
            for (int i = 0; i < nrofRow; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    double reduction = matrix[i, j] / matrix[j, j];
                    for (int k = 0; k < nrofRow+1; k++)
                    {
                        matrix[i, k] = matrix[i, k] - (reduction * matrix[j, k]);
                    }
                }
            }
            // Calculate Coefficients
            coefficients[nrofRow - 1] = matrix[nrofRow - 1, nrofRow] / matrix[nrofRow - 1, nrofRow - 1];

            for (int i = nrofRow - 2; i >= 0; i--)
            {
                double r = 0;
                for (int j = i + 1; j < nrofRow; j++)
                {
                    r = r + matrix[i, j] * coefficients[j];
                }

                coefficients[i] = (matrix[i, nrofRow] - r) / matrix[i, i];
            }
            return coefficients;
        }
        public FunctionSeries GetPolynomialSeries()
        {
            FunctionSeries functionSeries = new FunctionSeries();
            GetMatrix();
            double[] coefficients = CalculateCoefficients();
            double threshold = 1000;
            for (double x = -60; x <= 60; x += 0.01)
            {
                double y = 0;
                for (int i = 0; i < coefficients.Length; i++)
                {
                    y += coefficients[i] * Math.Pow(x, coefficients.Length - 1 - i);
                }
                if (Math.Abs(y) > threshold)
                {
                    functionSeries.Points.Add(DataPoint.Undefined);
                }
                else
                {
                    functionSeries.Points.Add(new DataPoint(x, y));
                }
            }
            return functionSeries;
        }
        public string GetFunction()
        {
            string func = "";
            double[] coefficients = CalculateCoefficients();
            for (int i = 0; i < coefficients.Length; i++)
            {
                if (i < coefficients.Length - 2)
                {
                    func += coefficients[i].ToString() + "*x^" + (coefficients.Length - 1 - i) + " + ";
                }
                else if (coefficients.Length - 1 - i == 1)
                {
                    func += coefficients[i].ToString() + "*x" + " + ";
                }
                else
                {
                    func += coefficients[i].ToString();
                }
            }
            return func;
        }
    }
}
