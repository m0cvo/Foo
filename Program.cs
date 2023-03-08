using static System.Console;

namespace Circle
{
    internal class Program
    {
        
        static void Main(string[] args)
        { 
            WriteLine("Circle calculator by N.Booth 2023 for Mogpie \n");
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
    }
}