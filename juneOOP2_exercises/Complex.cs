using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juneOOP2_exercises
{
    public class Complex : IComparable<Complex>
    {
        private int real;
        private int imaginary;

        public Complex(int realNumber, int imaginaryNumber) {
            this.real = realNumber;
            this.imaginary = imaginaryNumber;
        }

        public Complex(int realNumber)
        {
            this.real = realNumber;
            this.imaginary = 0;
        }

        public int GetReal()
        {
            return this.real;
        }

        public int GetImaginary()
        {
            return this.imaginary;
        }

        public int CompareTo(Complex? other)
        {
            if (this.real < other.real)
            {
                return -1;
            }

            if (this.real > other.real)
            {
                return 1;
            }

            if (this.imaginary < other.imaginary)
            {
                return -1;
            }

            if (this.imaginary > other.imaginary)
            {
                return 1;
            }

            return 0;
        }

        public override string ToString()
        {
            if (imaginary == 0)
            {
                return real.ToString();
            }
            else
            {
                return real + "+" + imaginary + "i";
            }
        }

        public static Complex AddTwo(Complex a, Complex b)
        {
            int sumReal = a.real + b.real;
            int sumImaginary = a.imaginary + b.imaginary;
            Complex newComplex = new Complex(sumReal, sumImaginary);
            return newComplex;
        }

        public void IncreaseReal(int increase)
        {
            this.real += increase;
            //return this;
        }

        public void AddComplex(Complex a)
        {
            this.real += a.real;
            this.imaginary += a.imaginary;
        }
    }
}
