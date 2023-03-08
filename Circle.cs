using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foo
{
    internal class Circle
    {
        /// <summary>
        /// Standard mathematical formulae for calculating area and circumference of a circle object.
        /// </summary>
        /// <param name="rad"></param>
        /// <returns></returns>

        public static float Circumference(string rad)
        {
            double R = Double.Parse(rad);
            float c = (float)(R * R);
            return c;
        }

        public static float Area(string rad)
        {
            double R = Double.Parse(rad);
            float A = (float)(Math.PI * R);
            return A;
        }
    }
}
