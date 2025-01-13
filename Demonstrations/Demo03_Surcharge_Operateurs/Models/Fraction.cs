using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03_Surcharge_Operateurs.Models
{
    class Fraction //nominateur denominateur 1/2 3/16
    {
        private int _Numerator;
        private int _Denominator = 1;

        public int Numerator
        {
            get { return _Numerator; }
            set { _Numerator = value; }
        }
        public int Denominator
        {
            get { return _Denominator; }
            set
            {
                if (value < 0) return;
                _Denominator = value;
            }
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int denominator = f1.Denominator * f2.Denominator;
            int numerator = f1.Numerator * f2.Denominator + f1.Denominator * f2.Numerator;

            return new Fraction
            {
                Denominator = denominator,
                Numerator = numerator
            };

        }
    }
}
