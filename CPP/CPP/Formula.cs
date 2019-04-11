using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    /// <summary>
    /// Main class for all features;
    /// </summary>
    public class Formula
    {
        public Function RootFunction { get; set; }
        List<string> listNotations;
        public Formula(Function derivativeRoot)
        {
            RootFunction = derivativeRoot;
            Simplify();
        }
        public Formula(string inputtedfunction)
        {
            Parsing(inputtedfunction);
            RootFunction = CreateTree();
            Simplify();
        }
        private void Parsing(string inputtedfunction)
        {
            listNotations = new List<string>();
            inputtedfunction = inputtedfunction.Replace(" ", "");
            for (int i = 0; i < inputtedfunction.Length; i++)
            {
                string token = "";
                while (inputtedfunction[i] != '(' && inputtedfunction[i] != ')' && inputtedfunction[i] != ',')
                {
                    token += inputtedfunction[i];
                    i++;
                }
                if (token != "")
                {
                    listNotations.Add(token);
                }
            }
        }
        private Function CreateTree()
        {
            Function currentNode = null;
            string token = listNotations.First();
            switch (token)
            {
                case "c":
                    currentNode = new Cosine();
                    listNotations.Remove(token);
                    currentNode.Left = CreateTree();
                    break;
                case "/":
                    currentNode = new Divide();
                    listNotations.Remove(token);
                    currentNode.Left = CreateTree();
                    currentNode.Right = CreateTree();
                    break;
                case "e":
                    currentNode = new Exp();
                    listNotations.Remove(token);
                    currentNode.Left = CreateTree();
                    break;
                case "!":
                    currentNode = new Factorial();
                    listNotations.Remove(token);
                    currentNode.Left = CreateTree();
                    break;
                case "*":
                    currentNode = new Multiply();
                    listNotations.Remove(token);
                    currentNode.Left = CreateTree();
                    currentNode.Right = CreateTree();
                    break;
                case "l":
                    currentNode = new NaturalLogarithm();
                    listNotations.Remove(token);
                    currentNode.Left = CreateTree();
                    break;
                case "n":
                    listNotations.Remove(token);
                    string valueN = listNotations.First();
                    currentNode = new NaturalNumber(Convert.ToInt32(valueN));
                    listNotations.Remove(valueN);
                    break;
                case "x":
                    currentNode = new ParameterX();
                    listNotations.Remove(token);
                    break;
                case "p":
                    currentNode = new Pi();
                    listNotations.Remove(token);
                    break;
                case "+":
                    currentNode = new Plus();
                    listNotations.Remove(token);
                    currentNode.Left = CreateTree();
                    currentNode.Right = CreateTree();
                    break;
                case "^":
                    currentNode = new Power();
                    listNotations.Remove(token);
                    currentNode.Left = CreateTree();
                    currentNode.Right = CreateTree();
                    break;
                case "r":
                    listNotations.Remove(token);
                    string valueR = listNotations.First().Replace('.',',');
                    currentNode = new RealNumber(Convert.ToDouble(valueR));
                    listNotations.Remove(listNotations.First());
                    break;
                case "s":
                    currentNode = new Sine();
                    listNotations.Remove(token);
                    currentNode.Left = CreateTree();
                    break;
                case "-":
                    currentNode = new Substract();
                    listNotations.Remove(token);
                    currentNode.Left = CreateTree();
                    currentNode.Right = CreateTree();
                    break;
                default:
                    currentNode = new NaturalNumber(Convert.ToInt32(token));
                    listNotations.Remove(token);
                    break;
            }
            return currentNode;
        }
        public FunctionSeries GetFunctionSeries()
        {
            FunctionSeries functionSeries = new FunctionSeries();
            double threshold = 1000;
            for (double i = -60; i <= 60; i += 0.01)
            {
                double y = RootFunction.CalculateValue(i);

                if (Math.Abs(y) > threshold)
                {
                    functionSeries.Points.Add(DataPoint.Undefined);
                }
                else
                {
                    functionSeries.Points.Add(new DataPoint(i, y));
                }
            }
            return functionSeries;
        }
        public FunctionSeries NewtonSeries(Formula formula)
        {
            FunctionSeries functionSeries = new FunctionSeries();
            double threshold = 1000;
            for (double i = -60; i <= 60; i += 0.01)
            {
                double y = formula.NewtonCaculate(i, 0.001);
                if (Math.Abs(y) > threshold)
                {
                    functionSeries.Points.Add(DataPoint.Undefined);
                }
                else
                {
                    functionSeries.Points.Add(new DataPoint(i, y));
                }
            }
            return functionSeries;
        }
        private double NewtonCaculate(double valueX, double delta)
        {
            return (RootFunction.CalculateValue(valueX + delta) - RootFunction.CalculateValue(valueX)) / delta;
        }

        private void Simplify()
        {
            RootFunction = RootFunction.SimplifyFunction();
        }
        public double CalculateRiemannIntegral(double lower, double upper)
        {
            double result = 0;
            double nrofstrip = 200;
            double stripwidth = (upper - lower) / nrofstrip;
            for (double point = lower + stripwidth; point < upper; point += stripwidth)
            {
                result += Math.Abs(RootFunction.CalculateValue(point));
            }
            return result * stripwidth;
        }
        public FunctionSeries GetMacLaurinSeries(int order)
        {
            return MacLaurinSeries(DerivateSeriesCoefficient(order));
        }
        // calculate the derivate in Coeffient
        private List<double> DerivateSeriesCoefficient(int order)
        {
            List<double> derivateSeriesCoefficient = new List<double>();
            Function derivativeFunction = RootFunction.Derivatives();
            derivateSeriesCoefficient.Add(RootFunction.CalculateValue(0));
            derivateSeriesCoefficient.Add(derivativeFunction.CalculateValue(0));
            for (int i = 2; i < order; i++)
            {
                derivativeFunction = derivativeFunction.Derivatives();
                derivateSeriesCoefficient.Add(derivativeFunction.CalculateValue(0));
            }
            return derivateSeriesCoefficient;
        }
        private FunctionSeries MacLaurinSeries(List<double> derivateSeriesCoefficient)
        {
            FunctionSeries series = new FunctionSeries();
            double threshold = 1000;
            for (double i = -60; i <= 60; i += 0.01)
            {
                double y = RootFunction.CalculateValue(0);
                for (int nr = 1; nr < derivateSeriesCoefficient.Count; nr++)
                {
                    double factorial = 1;
                    for (int j = 1; j <= nr; j++)
                    {
                        factorial *= j;
                    }
                    y += (derivateSeriesCoefficient.ElementAt(nr) * Math.Pow(i, nr)) / factorial;
                }
                if (Math.Abs(y) > threshold)
                {
                    series.Points.Add(DataPoint.Undefined);
                }
                else
                {
                    series.Points.Add(new DataPoint(i, y));
                }
            }
            return series;
        }
    }
}
