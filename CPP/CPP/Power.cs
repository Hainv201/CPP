using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    /// <summary>
    /// Class for Prefix Notation ^
    /// </summary>
    public class Power : Function
    {
        public Power() : base()
        {
        }

        public override double CalculateValue(double calvalue)
        {
            return Math.Pow(Left.CalculateValue(calvalue), Right.CalculateValue(calvalue));
        }

        public override Function Derivatives()
        {
            Function DerivativeNode = new Multiply();
            Function LeftDerivative = new Multiply();
            DerivativeNode.Left = LeftDerivative;
            LeftDerivative.Left = Right;
            LeftDerivative.Right = new Power();
            LeftDerivative.Right.Left = Left;
            LeftDerivative.Right.Right = new Substract();
            LeftDerivative.Right.Right.Left = Right;
            LeftDerivative.Right.Right.Right = new NaturalNumber(1);
            DerivativeNode.Right = Left.Derivatives();
            return DerivativeNode;
        }

        public override string GetLabel()
        {
            return "^";
        }

        public override Function SimplifyFunction()
        {
            Left = Left.SimplifyFunction();
            Right = Right.SimplifyFunction();
            if (Left.IsConstant() && Right.IsConstant())
            {
                return new RealNumber(CalculateValue(0));
            }
            if (Left is Power && Right.IsConstant())
            {
                if (Left.Right.IsConstant())
                {
                    Function function = new Power();
                    function.Left = Left.Left;
                    function.Right = new RealNumber(Left.Right.CalculateValue(0) * Right.CalculateValue(0));
                    return function.SimplifyFunction();
                }
            }
            if (Left is Exp && Right.IsConstant())
            {
                Function function = new Exp();
                function.Left = new RealNumber(Left.Left.CalculateValue(0) * Right.CalculateValue(0));
                return function.SimplifyFunction();
            }
            if (Right.ToString() == "1")
            {
                return Left;
            }
            if (Left.ToString() == "0"|| Left.ToString() == "1")
            {
                return Left;
            }
            return this;
        }

        public override string ToString()
        {
            return $"({Left.ToString()}^{Right.ToString()})";
        }
    }
}
