using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    /// <summary>
    /// Class for Prefix Notation e
    /// </summary>
    public class Exp : Function
    {
        public Exp() : base()
        {
        }

        public override double CalculateValue(double calvalue)
        {
            return Math.Exp(Left.CalculateValue(calvalue));
        }

        public override Function Derivatives()
        {
            Function DerivativeNode = new Multiply();
            DerivativeNode.Left = Left.Derivatives();
            DerivativeNode.Right = this;
            return DerivativeNode;
        }

        public override string GetLabel()
        {
            return "e";
        }

        public override Function SimplifyFunction()
        {
            Left = Left.SimplifyFunction();
            if (Left.ToString() == "0")
            {
                return new NaturalNumber(1);
            }
            if (Left is NaturalLogarithm)
            {
                return Left.Left;
            }
            //if (this.IsConstant())
            //{
            //    return new RealNumber(CalculateValue(0));
            //}
            return this;
        }

        public override string ToString()
        {
            return $"e({Left.ToString()})";
        }
    }
}
