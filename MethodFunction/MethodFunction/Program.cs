using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFunction
{
    class Program
    {
        static void Main()
        {
            var x = F(1 + F(2 + F(3 + F(4))));
            Console.WriteLine("x={0:F3}", x);
            Console.ReadKey();
        }
        static double F(double x)
        {
            return Math.Sin(x);

        }
    }
}
