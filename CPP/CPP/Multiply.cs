using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    /// <summary>
    /// Class for Prefix Notation *
    /// </summary>
    public class Multiply : Function
    {
        public Multiply() : base()
        {
        }

        public override double CalculateValue(double calvalue)
        {
            return Left.CalculateValue(calvalue) * Right.CalculateValue(calvalue);
        }

        public override Function Derivatives()
        {
            Function DerivativeNode = new Plus();
            Function LeftDerivative = new Multiply();
            Function RightDerivative = new Multiply();
            DerivativeNode.Left = LeftDerivative;
            DerivativeNode.Right = RightDerivative;
            LeftDerivative.Left = Left.Derivatives();
            LeftDerivative.Right = Right;
            RightDerivative.Left = Left;
            RightDerivative.Right = Right.Derivatives();
            return DerivativeNode;
        }

        public override string GetLabel()
        {
            return "*";
        }

        public override Function SimplifyFunction()
        {
            Left = Left.SimplifyFunction();
            Right = Right.SimplifyFunction();
            if (Left.IsConstant() && Right.IsConstant())
            {
                return new RealNumber(CalculateValue(0));
            }
            if (Left is Multiply && Right.IsConstant())
            {
                if (Left.Left.IsConstant())
                {
                    Function function = new Multiply();
                    function.Left = new RealNumber(Left.Left.CalculateValue(0) * Right.CalculateValue(0));
                    function.Right = Left.Right;
                    return function.SimplifyFunction();
                }
                if (Left.Right.IsConstant())
                {
                    Function function = new Multiply();
                    function.Left = new RealNumber(Left.Right.CalculateValue(0) * Right.CalculateValue(0));
                    function.Right = Left.Left;
                    return function.SimplifyFunction();
                }
            }
            if (Right is Multiply && Left.IsConstant())
            {
                if (Right.Left.IsConstant())
                {
                    Function function = new Multiply();
                    function.Left = new RealNumber(Left.CalculateValue(0) * Right.Left.CalculateValue(0));
                    function.Right = Right.Right;
                    return function.SimplifyFunction();
                }
                if (Right.Right.IsConstant())
                {
                    Function function = new Multiply();
                    function.Left = new RealNumber(Left.CalculateValue(0) * Right.Right.CalculateValue(0));
                    function.Right = Right.Left;
                    return function.SimplifyFunction();
                }
            }
            if (Left is Divide && Right.IsConstant())
            {
                if (Left.Left.IsConstant())
                {
                    Function function = new Divide();
                    function.Left = new RealNumber(Left.Left.CalculateValue(0) * Right.CalculateValue(0));
                    function.Right = Left.Right;
                    return function.SimplifyFunction();
                }
                if (Left.Right.IsConstant())
                {
                    Function function = new Multiply();
                    function.Left = Left.Left;
                    function.Right = new RealNumber(Right.CalculateValue(0) / Left.Right.CalculateValue(0));
                    return function.SimplifyFunction();
                }
            }
            if (Right is Divide && Left.IsConstant())
            {
                if (Right.Left.IsConstant())
                {
                    Function function = new Divide();
                    function.Left = new RealNumber(Right.Left.CalculateValue(0) * Left.CalculateValue(0));
                    function.Right = Right.Right;
                    return function.SimplifyFunction();
                }
                if (Right.Right.IsConstant())
                {
                    Function function = new Multiply();
                    function.Left = Right.Left;
                    function.Right = new RealNumber(Left.CalculateValue(0) / Right.Right.CalculateValue(0));
                    return function.SimplifyFunction();
                }
            }
            if (Left.ToString() == "0" || Right.ToString() == "0")
            {
                return new NaturalNumber(0);
            }
            if (Left.ToString() == "1")
            {
                return Right;
            }
            if (Right.ToString() == "1")
            {
                return Left;
            }
            if (Left is Exp && Right is Exp)
            {
                if (Left.Left.IsConstant() && Right.Left.IsConstant())
                {
                    Function function = new Exp();
                    function.Left = new RealNumber(Left.Left.CalculateValue(0) + Right.Left.CalculateValue(0));
                    return function.SimplifyFunction();
                }
            }
            return this;
        }

        public override string ToString()
        {
            return $"({Left.ToString()}*{Right.ToString()})";
        }
    }
}
