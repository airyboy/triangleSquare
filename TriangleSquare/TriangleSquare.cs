using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalc
{
    public class TriangleSquare
    {
        public class IncorrectSideLengthException : Exception
        {
            public IncorrectSideLengthException() { }
        }

        public class ImpossibleTriangleException : Exception
        {
            public ImpossibleTriangleException() { }
        }

        public static double CalcSquare(double a, double b, double c)
        {
            //checking for non-zero and negative values
            if (a <= 0 | b <= 0 | c <= 0)
            {
                throw new IncorrectSideLengthException();
            }

            //checking triangle inequality as well
            if (a + b < c | a + c < b | b + c < a)
            {
                throw new ImpossibleTriangleException();
            }

            // Heron's formula
            var semiPerimeter = (a + b + c) / 2;
            var s = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
            return s; 
        }
    }
}
