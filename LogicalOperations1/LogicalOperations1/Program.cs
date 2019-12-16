using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperations1
{
    class Program
    {
        static void Main()
        {
            var n = Input("n");
            var k = Input("k");
            var m = Input("m");
            Console.WriteLine("Значение выражения " + F(n, k, m));
            Console.ReadKey();

        }
        static bool F(double n, double k, double m)
        {
            return ((n > 0) && (k > 0) && (m > 0)) && ((n % 2 == 0) | (k % 2 == 0) | (m % 2 == 0));

        }
        static double Input(string Name)
        {
            Console.WriteLine("Введите число " + Name);
            return double.Parse(Console.ReadLine());
        }
    
    }
}
