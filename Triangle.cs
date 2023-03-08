using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foo
{
    internal class Triangle
    {
        /// <summary>
        /// Standard mathematical formulae for calculating area and perimeter of a triangle.
        /// </summary>
        /// <param name="side"></param>
        /// <returns>"a" "p"</returns>
        public static float Perimeter(string side)
        {
            double S = double.Parse(side);
            float p = (float)(S * 3);
            return p;
        }

        public static float Area(string bottom, string height)
        {
            double B = double.Parse((string)bottom);
            double H = double.Parse((string)height);
            float a = (float)((B*H)/2);
            return a;
        }
    }
}
