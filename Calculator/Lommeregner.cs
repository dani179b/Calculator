using System;

namespace Calculator
{
    public class Lommeregner
    {
        public delegate double Dg_Operation(double p1, double p2);
        public double Calculate(double p1, double p2, Dg_Operation)
        {
            return 0.0;
        }
    }
}