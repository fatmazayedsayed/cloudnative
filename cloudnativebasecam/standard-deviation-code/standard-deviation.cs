using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace standard_deviation_code
{
    internal class standard_deviation
    {
          public void cal()
        {
            Console.WriteLine("standard-deviation-code");
            int n, i = 0;
            double a = 0, ave = 0, b = 0, sd = 0;
            List<int> x = new List<int>();
            Console.WriteLine("Enter Array lenght:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Array Data:");
            do
            {
                Console.WriteLine("Enter x[{0}]:", i);
                x.Add(int.Parse(Console.ReadLine()));
                ave += x[i];
                i++;
            } while (i < n);
            ave = ave / n;
            Console.WriteLine("Ave is : {0}", ave);

            foreach (var item in x)
            {
                a += Math.Pow((item - ave), 2);
            }
            Console.WriteLine("a : {0}", a);
            b = a / n;
            sd = Math.Sqrt(b);
            Console.WriteLine("standard deviation : {0}", sd);
        }
    }
}
