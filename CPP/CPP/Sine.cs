using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    /// <summary>
    /// Class for Prefix Notation s
    /// </summary>
    public class Sine : Function
    {
        public Sine() : base()
        {
        }

        public override double CalculateValue(double calvalue)
        {
            return Math.Sin(Left.CalculateValue(calvalue));
        }


        public override Function Derivatives()
        {
            Function DerivativeNode = new Multiply();
            DerivativeNode.Left = Left.Derivatives();
            DerivativeNode.Right = new Cosine();
            DerivativeNode.Right.Left = Left;
            return DerivativeNode;
        }

        public override string GetLabel()
        {
            return "sin";
        }

        public override Function SimplifyFunction()
        {
            Left = Left.SimplifyFunction();
            //if (this.IsConstant())
            //{
            //    return new RealNumber(CalculateValue(0));
            //}
            return this;
        }

        public override string ToString()
        {
            return $"sin({Left.ToString()})";
        }
    }
}
