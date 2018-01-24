using System;

namespace Calculator
{
    public class Lommeregner
    {
        public delegate double DgOperation(double p1, double p2);

        public double Calculate(double p1, double p2, DgOperation DG)
        {
            return DG(p1, p2);
        }
    }
}