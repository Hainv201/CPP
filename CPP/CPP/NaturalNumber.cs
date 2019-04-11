using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    /// <summary>
    /// Class for Prefix Notation n
    /// </summary>
    public class NaturalNumber : Function
    {
        private int naturalNr;
        public NaturalNumber(int naturalNumber) : base(naturalNumber)
        {
            this.naturalNr = naturalNumber;
        }

        public override double CalculateValue(double calvalue)
        {
            return naturalNr;
        }


        public override Function Derivatives()
        {
            return new NaturalNumber(0);
        }

        public override string GetLabel()
        {
            return $"{naturalNr.ToString()}";
        }

        public override Function SimplifyFunction()
        {
            return this;
        }

        public override string ToString()
        {
            return $"{naturalNr.ToString()}";
        }
    }
}
