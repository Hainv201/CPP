using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    /// <summary>
    /// Class for Prefix Notation l
    /// </summary>
    public class NaturalLogarithm : Function
    {
        public NaturalLogarithm() : base()
        {
        }

        public override double CalculateValue(double calvalue)
        {
            return Math.Log(Left.CalculateValue(calvalue));
        }

        public override Function Derivatives()
        {
            Function DerivativeNode = new Divide();
            DerivativeNode.Left = Left.Derivatives();
            DerivativeNode.Right = Left;
            return DerivativeNode;
        }

        public override string GetLabel()
        {
            return "ln";
        }

        public override Function SimplifyFunction()
        {
            Left = Left.SimplifyFunction();
            if (Left.ToString() == "1")
            {
                return new NaturalNumber(0);
            }
            if (Left is Exp)
            {
                return Left.Left;
            }
            if (Left is Power)
            {
                Function function = new Multiply();
                function.Left = Left.Right;
                function.Right = new NaturalLogarithm();
                function.Right.Left = Left.Left;
                return function.SimplifyFunction();
            }
            //if (this.IsConstant())
            //{
            //    return new RealNumber(CalculateValue(0));
            //}
            return this;
        }

        public override string ToString()
        {
            return $"ln({Left.ToString()})";
        }
    }
}
