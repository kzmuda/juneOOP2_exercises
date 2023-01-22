namespace juneOOP2_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}