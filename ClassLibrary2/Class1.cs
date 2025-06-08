using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public static class Functions
    {
        public static double IdentityFunction(double x)
        {
            return x;
        }

        public static double SquareFunction(double x)
        {
            return x * x;
        }

        public static double ExponentialFunction(double x)
        {
            return Math.Pow(Math.E, x);
        }

        public static double SineFunction(double x)
        {
            return Math.Sin(x);
        }

        public static double CosineFunction(double x)
        {
            return Math.Cos(x);
        }

        public static double TangentFunction(double x)
        {
            return Math.Tan(x);
        }
    }
}
