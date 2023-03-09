using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Foo
{
    /// <summary>
    /// Test to run for TDD.  All referrences to this will be removed once I have a fully operational program.
    /// </summary>
    internal class Test
    {
    
        public static float Test1()
        {
            string D = "10";
            double C;

            C = Circle.Circumference(D);
            Write("Circumference of circle with radius of 10mm: {C} ");
            
            return (float)C;
        }
        public static float Test2()
        {
            string D = "10";
            double A = Circle.Area(D);
            Write("Area of a circle with radius of 10mm: {A}");
            return (float)A;
        }
    }
}
