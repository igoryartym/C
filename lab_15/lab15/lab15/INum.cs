using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace lab15
{
    interface INum
    {
        Complex Sum(Complex A, Complex B);
        Complex Diference(Complex A, Complex B);
    }
}
