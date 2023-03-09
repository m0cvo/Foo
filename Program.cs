using static System.Console;

namespace Foo
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            //ClassTest();

            WriteLine("Shape calculator by N.Booth 2023 for Mogpie \n");
            WriteLine("Please enter choice: ");
            WriteLine("(1) Circle ");
            WriteLine("(2) Square ");
            WriteLine("(3) Triangle ");
            Write(": ");
            
            string selection = ReadLine();

            switch (selection)
            {
                case "1":
                    CirCalc();
                    break;

                case "2":
                    SquareCalc();
                    break;

                case "3":
                    TriCalc();
                    break;

                default:
                    Console.WriteLine("Please enter a selection. ");
                    break;
            }
        } 

        static void ClassTest()
        {
            WriteLine("Test: ");
            float x = Test.Test1();
            WriteLine(x);
            float y = Test.Test2();
            WriteLine(y);
        }
                
        static void CirCalc()
        {
            WriteLine("(1) Circumference of circle ");
            WriteLine("(2) Area of circle ");
            Write(": ");

            string choice = ReadLine();
            double A, C = 0;

            switch (choice)
            {
                case "1":
                    Write("Please enter the radius in mm: ");
                    C = Circle.Circumference(ReadLine() ?? "0");
                    WriteLine("Circumference of circle is: {0:F2}mm", C);
                    break;

                case "2":
                    Write("Please enter the radius in mm: ");
                    A = Circle.Area(ReadLine() ?? "0");
                    WriteLine("Area of the circle is: {0:F2}mm", A);
                    break;

                default:
                    WriteLine("Please enter a choice.");
                    break;
            }

            // Keep the console window open whilst in debug mode.
            WriteLine("Press any key to exit.");
            ReadKey();
        }

        static void SquareCalc() 
        {
            WriteLine("(1) Perimeter of a square ");
            WriteLine("(2) Area of a square ");
            Write(": ");

            string choice = ReadLine();
            double A, P = 0;

            switch (choice)
            {
                case "1":
                    Write("Please enter the sidelength in mm: ");
                    P = Square.Perimeter(ReadLine() ?? "0");
                    WriteLine("Perimeter of square is: {0:F2}mm", P);
                    break;

                case "2":
                    Write("Please enter the radius in mm: ");
                    A = Square.Area(ReadLine() ?? "0");
                    WriteLine("Area of the circle is: {0:F2}mm", A);
                    break;

                default:
                    WriteLine("Please enter a choice.");
                    break;
            }

            // Keep the console window open whilst in debug mode.
            WriteLine("Press any key to exit.");
            ReadKey();
        }

        static void TriCalc()
        {
            WriteLine("(1) Perimeter of an equilateral triangle ");
            WriteLine("(2) Area of a triangle ");
            Write(": ");

            string choice = ReadLine();
            double A, P = 0;

            switch (choice)
            {
                case "1":
                    Write("Please enter the side length in mm: ");
                    P = Triangle.Perimeter(ReadLine() ?? "0");
                    WriteLine("Perimeter of triangle is: {0:F2}mm", P);
                    break;

                case "2":
                    Write("Please enter the base length in mm: ");
                    string bLength = ReadLine();
                    Write("Please enter the height in mm: ");
                    string height = ReadLine();
                    A = Triangle.Area(bLength ?? "0", height ?? "0");
                    WriteLine("Area of the triangle is: {0:F2}mm", A);
                    break;

                default:
                    WriteLine("Please enter a choice.");
                    break;
            }

            // Keep the console window open whilst in debug mode.
            WriteLine("Press any key to exit.");
            ReadKey();
        }
    }
}