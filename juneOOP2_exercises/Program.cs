namespace juneOOP2_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex mycomplex = new Complex(2, 0);
            //Console.WriteLine(mycomplex);
            Complex mycomplex2 = new Complex(2, 4);
            //Console.WriteLine(Complex.AddTwo(mycomplex, mycomplex2));
            mycomplex.IncreaseReal(2);
            Console.WriteLine(mycomplex);
            mycomplex.AddComplex(mycomplex2);
            Console.WriteLine(mycomplex); // 6 + 4i
        }
    }
}