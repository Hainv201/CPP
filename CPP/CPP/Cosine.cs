using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    /// <summary>
    /// Class for Prefix Notation c
    /// </summary>
    public class Cosine : Function
    {
        public Cosine():base()
        {

        }

        public override double CalculateValue(double calvalue)
        {
            return Math.Cos(Left.CalculateValue(calvalue));
        }

        public override Function Derivatives()
        {
            Function DerivativeNode = new Multiply();
            DerivativeNode.Left = new Multiply();
            DerivativeNode.Left.Left = new RealNumber(-1);
            DerivativeNode.Left.Right = Left.Derivatives();
            DerivativeNode.Right = new Sine();
            DerivativeNode.Right.Left = Left;
            return DerivativeNode;
        }

        public override string GetLabel()
        {
            return "cos";
        }

        public override Function SimplifyFunction()
        {
            Left = Left.SimplifyFunction();
            // More simplify
            //if (this.IsConstant())
            //{
            //    return new RealNumber(CalculateValue(0));
            //}
            return this;
        }
        public override string ToString()
        {
            return $"cos({Left.ToString()})";
        }
    }
}
