using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    internal class trapezoidCalculation
    {
       public double calaArea(float a, float b, float h)
        {
            // A = ½ (a + b) h
            var res= (0.5*(a + b)*h);
            return res;
        }
    }
}
