using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
   /// <summary>
   /// Class for Node of Tree
   /// </summary>
    public abstract class Function
    {
        public Function Left { get; set; }
        public Function Right { get; set; }
        public Function()
        {
            this.Left = null;
            this.Right = null;
        }
        public Function(int naturalNumber)
        {
            this.Left = null;
            this.Right = null;
        }
        public Function(double realNumber)
        {
            this.Left = null;
            this.Right = null;
        }
        public string CreateGraph(ref int index, int preIndex = 0)
        {
            string graph = String.Format($"\nnode{index} [ label = \"{GetLabel()}\" ]");
            if (preIndex != 0)
            {
                graph += String.Format($"\nnode{preIndex} -- node{index}");
            }
            if (this is Divide || this is Multiply || this is Plus|| this is Power || this is Substract)
            {               
                int pre = index;
                index++;
                graph += Left.CreateGraph(ref index, pre);
                graph += Right.CreateGraph(ref index, pre);
                return graph;
            }
            else if (this is Cosine|| this is Exp || this is Factorial
                || this is NaturalLogarithm|| this is Sine)
            {
                int pre = index;
                index++;
                graph += Left.CreateGraph(ref index, pre);
                return graph;
            }
            else
            {
                index++;
                return graph;
            }
        }
        public  abstract string GetLabel();
        public abstract Function SimplifyFunction();
        public abstract Function Derivatives();

        public abstract double CalculateValue(double calvalue);
        public bool IsConstant()
        {
            if (this is NaturalNumber/* || this is Pi*/ || this is RealNumber)
            {
                return true;
            }
            //if (this is Cosine || this is Exp || this is Factorial || this is NaturalLogarithm
            //    || this is Sine)
            //{
            //    if (this.Left is NaturalNumber || this.Left is Pi || this.Left is RealNumber)
            //    {
            //        return true;
            //    }
            //}
            return false;
        }
    }
}