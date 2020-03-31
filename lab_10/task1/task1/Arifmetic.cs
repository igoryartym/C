using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Arifmetic
    {
        public double Progress(double a,double b,int c)
        {
            return a + b * (c - 1); 
        }
        public double Sumprogres(double a, double b, int c)
        {
            return ((2 * a + b * (c - 1)) / 2) * c;
        }
    }
}
