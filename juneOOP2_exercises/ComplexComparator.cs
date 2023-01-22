using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juneOOP2_exercises
{
    public class ComplexComparator : IComparer<Complex>
    {
        public int Compare(Complex? x, Complex? y)
        {
            if (x.GetImaginary() < y.GetImaginary())
            {
                return -1;
            }

            if (x.GetImaginary() > y.GetImaginary())
            {
                return 1;
            }

            if (x.GetReal() < y.GetReal())
            {
                return -1;
            }

            if (x.GetReal() > y.GetReal())
            {
                return 1;
            }

            return 0;
        }
    }
}
