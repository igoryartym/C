using System;
using System.Collections.Generic;
using System.Text;

namespace lab14
{
    class TQuadrangle
    {
        public virtual double Area(double a, double b)
        {
            return a * b;            
        }
        public virtual double Perum(double a, double b)
        {
            return 2 * (a + b);
        }
    }
}
