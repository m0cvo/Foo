using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foo
{
    internal class Square
    {
        /// <summary>
        /// Standard mathematical formulae for calculating area and perimeter of a square.
        /// </summary>
        /// <param name="side"></param>
        /// <returns>"a" "p"</returns>
        public static float Perimeter(string side)
        {
            double S = double.Parse(side);
            float p = (float)(S * 4);
            return p;
        }

        public static float Area(string side) 
        { 
            double S = double.Parse((string)side);
            float a = (float)(S * S);
            return a;
        }
    }
}
