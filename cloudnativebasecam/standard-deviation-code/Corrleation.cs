using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace standard_deviation_code
{
    internal class Corrleation
    {
        public void calculate()
        {
            Console.WriteLine("Enter Array lenght:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter First Array");
            double sumX, sumY;
            double powerX, powerY = 0;
            List<double> x = readArray(n, out sumX, out powerX);

            Console.WriteLine("Enter Second Array");
            List<double> y = readArray(n, out sumY, out powerY);
            double sum = sumArrays(x, y);
            var numerator = (n * sum) - (sumX * sumY);

            var denominator = (Math.Sqrt((n * powerX) - Math.Pow(sumX,2))) *
                            Math.Sqrt((n * powerY) -Math.Pow( sumY,2));

            var res = numerator / denominator;
            Console.WriteLine("Corrleartion is {0}", res);
        }

        List<double> readArray(int n, out double sum, out double power)
        {
            int i = 0;
            sum = 0;
            power = 0;
            List<double> x = new List<double>();
            do
            {
                Console.WriteLine("Enter x[{0}]:", i);
                x.Add(double.Parse(Console.ReadLine()));
                power += Math.Pow(x[i], 2);
                sum += x[i];
                i++;
            } while (i < n);
            return x;
        }
        private double sumArrays(List<double> x, List<double> y)
        {
            double sum = 0;
            for (int i = 0; i < x.Count; i++)
            {
                sum += x[i]* y[i];
            }
            return sum;
        }
    }
}
