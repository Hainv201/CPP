using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    /// <summary>
    /// Class for Prefix Notation r
    /// </summary>
    public class RealNumber : Function
    {
        private double realNr;
        public RealNumber(double realNumber) : base(realNumber)
        {
            this.realNr = realNumber;
        }

        public override double CalculateValue(double calvalue)
        {
            return realNr;
        }

        public override Function Derivatives()
        {
            return new NaturalNumber(0);
        }

        public override string GetLabel()
        {
            return $"{realNr.ToString()}";
        }

        public override Function SimplifyFunction()
        {
            return this;
        }

        public override string ToString()
        {
            return $"{realNr.ToString()}";
        }
    }
}
