using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    /// <summary>
    /// Class for Prefix Notation p
    /// </summary>
    public class Pi : Function
    {
        public Pi() : base()
        {
        }

        public override double CalculateValue(double value)
        {
            return Math.PI;
        }


        public override Function Derivatives()
        {
            return new NaturalNumber(0);
        }

        public override string GetLabel()
        {
            return "\u03C0";
        }

        public override Function SimplifyFunction()
        {
            return this;
        }

        public override string ToString()
        {
            return "\u03C0";
        }
    }
}
