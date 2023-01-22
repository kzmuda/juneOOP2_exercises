namespace juneOOP2_exercises
{
    internal class Program
    {
        static void PrintArray(int[] arr)
        {
            ///
            foreach (var element in arr)
            {
                Console.Out.WriteLine(element);
            }
        }

        static void PrintArray(char[] arr)
        {
            ///
            foreach (var element in arr)
            {
                Console.Out.WriteLine(element);
            }
        }

        static void PrintArray<T>(T b)
        {
            T a;
        }

        static void Main(string[] args)
        {
            // DataStore<int> ds = new DataStore<int>();
            // ds.Data = 10;
            // //ds.Data = "aaaa";
            //
            // DataStore<string> ds1 = new DataStore<string>();
            // //ds1.Data = 10;
            // ds1.Data = "aaa";



            // int[] intArray = { 1,2,3,4 };
            // PrintArray(intArray);
            //
            // char[] charArray = { 'a', 'b' };
            // PrintArray(charArray);
            //
            // PrintArray<int>(5);
            // PrintArray<string>("aaaa");


            // List<int> a;
            // List<string> b;
            // List<Complex> c;

            /*
            // Task 1
            Complex mycomplex = new Complex(2, 0);
            //Console.WriteLine(mycomplex);
            Complex mycomplex2 = new Complex(2, 4);
            //Console.WriteLine(Complex.AddTwo(mycomplex, mycomplex2));
            mycomplex.IncreaseReal(2);
            Console.WriteLine(mycomplex);
            mycomplex.AddComplex(mycomplex2);
            Console.WriteLine(mycomplex); // 6 + 4i
            */

            // Task 2
            /*
            Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine("Show area of rectangle");
            Console.WriteLine(rectangle.GetArea());

            Console.WriteLine("Show GetWidth method");
            Console.WriteLine(rectangle.GetWidth());

            List<IFigure> walls = new List<IFigure>();

            walls.Add(rectangle);
            walls.Add(new Rectangle(4, 8));
            walls.Add(new Circle(11));

            int summaryArea = 0;
            foreach (IFigure wall in walls)
            {
                summaryArea += wall.GetArea();
            }
            Console.WriteLine(summaryArea);
            
            Circle circle = new Circle(9);
            Console.WriteLine(circle.GetArea());

            Console.ReadLine();
            */

            // Task 3
            /*
            List<Complex> complex = new List<Complex>()
            {
                new Complex(5, 3),
                new Complex(1, 5),
                new Complex(5),
                new Complex(2, 2),
                new Complex(1, 2)
            };

            complex.Sort();

            foreach (Complex c in complex)
            {
                Console.Out.WriteLine(c);
            }
            */
        }
    }
}