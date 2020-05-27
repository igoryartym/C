using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace модульна_робота_2_сем__6
{
    class ArraySort : Interface1
    {
        public double[] getArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > getAverage(arr))
                    arr[i] = 0;
            }
            return arr;
        }

        public double getAverage(double[] arr)
        {
            double rez = 0;
            foreach (var item in arr)
            {
                rez += item;
            }
            return rez / arr.Length;
        }
    }
}
