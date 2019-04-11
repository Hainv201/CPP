using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    /// <summary>
    /// Class for Prefix Notation +
    /// </summary>
    public class Plus : Function
    {
        public Plus() : base()
        {
        }

        public override double CalculateValue(double calvalue)
        {
            return Left.CalculateValue(calvalue) + Right.CalculateValue(calvalue);
        }


        public override Function Derivatives()
        {
            Function DerivativeNode = new Plus();
            DerivativeNode.Left = Left.Derivatives();
            DerivativeNode.Right = Right.Derivatives();
            return DerivativeNode;
        }

        public override string GetLabel()
        {
            return "+";
        }

        public override Function SimplifyFunction()
        {
            Left = Left.SimplifyFunction();
            Right = Right.SimplifyFunction();
            if (Left.IsConstant() && Right.IsConstant())
            {
                return new RealNumber(CalculateValue(0));
            }
            if (Left.ToString() == "0")
            {
                return Right;
            }
            if (Right.ToString() == "0")
            {
                return Left;
            }
            if (Left is Plus && Right.IsConstant())
            {
                if (Left.Left.IsConstant())
                {
                    Function function = new Plus();
                    function.Left = Left.Right;
                    function.Right = new RealNumber(Right.CalculateValue(0) + Left.Left.CalculateValue(0));
                    return function.SimplifyFunction();
                }
                if (Left.Right.IsConstant())
                {
                    Function function = new Plus();
                    function.Left = Left.Left;
                    function.Right = new RealNumber(Left.Right.CalculateValue(0) + Right.CalculateValue(0));
                    return function.SimplifyFunction();
                }
            }
            if (Right is Plus && Left.IsConstant())
            {
                if (Right.Left.IsConstant())
                {
                    Function function = new Plus();
                    function.Left = Right.Right;
                    function.Right = new RealNumber(Right.Left.CalculateValue(0) + Left.CalculateValue(0));
                    return function.SimplifyFunction();
                }
                if (Right.Right.IsConstant())
                {
                    Function function = new Plus();
                    function.Left = Right.Left;
                    function.Right = new RealNumber(Right.Right.CalculateValue(0) + Left.CalculateValue(0));
                    return function.SimplifyFunction();
                }
            }
            if (Left is Substract && Right.IsConstant())
            {
                if (Left.Left.IsConstant())
                {
                    Function function = new Substract();
                    function.Right = Left.Right;
                    function.Left = new RealNumber(Left.Left.CalculateValue(0) + Right.CalculateValue(0));
                    return function.SimplifyFunction();
                }
                if (Left.Right.IsConstant())
                {
                    Function function = new Plus();
                    function.Left = Left.Left;
                    function.Right = new RealNumber(Right.CalculateValue(0) - Left.Right.CalculateValue(0));
                    return function.SimplifyFunction();
                }
            }
            if (Right is Substract && Left.IsConstant())
            {
                if (Right.Left.IsConstant())
                {
                    Function function = new Substract();
                    function.Left = new RealNumber(Right.Left.CalculateValue(0) + Left.CalculateValue(0));
                    function.Right = Right.Right;
                    return function.SimplifyFunction();
                }
                if (Right.Right.IsConstant())
                {
                    Function function = new Plus();
                    function.Left = Right.Left;
                    function.Right = new RealNumber(Left.CalculateValue(0) - Right.Right.CalculateValue(0));
                    return function.SimplifyFunction();
                }
            }
            if (Left is NaturalLogarithm && Right is NaturalLogarithm)
            {
                if (Left.Left.IsConstant() && Right.Left.IsConstant())
                {
                    Function function = new NaturalLogarithm();
                    function.Left = new RealNumber(Left.Left.CalculateValue(0) * Right.Left.CalculateValue(0));
                    return function.SimplifyFunction();
                }
            }
            return this;
        }

        public override string ToString()
        {
            return $"({Left.ToString()}+{Right.ToString()})";
        }
    }
}
