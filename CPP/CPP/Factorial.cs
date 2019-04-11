using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    /// <summary>
    ///  Class for Prefix Notation !
    /// </summary>
    public class Factorial : Function
    {
        public Factorial() : base()
        {
        }

        public override double CalculateValue(double calvalue)
        {
            double factorial = Left.CalculateValue(calvalue);
            double result = 1;
            for (int i = 1; i <= factorial; i++)
            {
                result *= i;
            }
            return result;
        }

        public override Function Derivatives()
        {
            return new NaturalNumber(0);
        }

        public override string GetLabel()
        {
            return "!";
        }

        public override Function SimplifyFunction()
        {
            //if (this.IsConstant())
            //{
            //    return new RealNumber(CalculateValue(0));
            //}
            return this;
        }

        public override string ToString()
        {
            return $"{Left.ToString()}!";
        }
    }
}
