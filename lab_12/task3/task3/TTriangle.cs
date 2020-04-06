using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    class TTriangle
    {
        double[] xn;
        double[] yn;
        public TTriangle(double[] xn, double[] yn)
        {
            this.xn = xn;
            this.yn = yn;
        }

        public double a()
        {
            return Math.Round(Math.Sqrt(Math.Pow((xn[1] - xn[0]), 2) + Math.Pow((yn[1] - yn[0]), 2)),2);
        }
        public double b()
        {
            return Math.Round(Math.Sqrt(Math.Pow((xn[2] - xn[1]), 2) + Math.Pow((yn[2] - yn[1]), 2)),2);
        }
        public double c()
        {
            return Math.Round(Math.Sqrt(Math.Pow((xn[2] - xn[0]), 2) + Math.Pow((yn[2] - yn[0]), 2)),2);
        }
        public double A
        {
            get
            {
                return a();
            }

        }
        public double B
        {
            get
            {
                return b();
            }
        }
        public double C
        {
            get
            {
                return c();
            }
        } 
        public double Square()
        {
            double p = (A + B + C) / 2;
            return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)),2);
        }
        public double Perum()
        {
            return Math.Round(A + B + C,2);
        }
    }
}