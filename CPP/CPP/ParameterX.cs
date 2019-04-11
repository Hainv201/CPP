using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    /// <summary>
    /// Class for Prefix Notation x
    /// </summary>
    public class ParameterX : Function
    {
        public ParameterX() : base()
        {
        }

        public override double CalculateValue(double value)
        {
            return value;
        }

        public override Function Derivatives()
        {
            return new NaturalNumber(1);
        }

        public override string GetLabel()
        {
            return "x";
        }

        public override Function SimplifyFunction()
        {
            return this;
        }

        public override string ToString()
        {
            return "x";
        }
    }
}
