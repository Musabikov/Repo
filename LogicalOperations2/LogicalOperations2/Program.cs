using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperations2
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Input(" x");
            var y = Input(" y");
            Console.WriteLine("Значение выражения: " + F(x, y));
            Console.ReadKey();
        }
        static double Input(string Name)
        {
            Console.WriteLine("Введите значение выражения" + Name);
            return double.Parse(Console.ReadLine());
        }
        static bool F(double x, double y)
        {
            var xmean = (x > 2);
            var ymean = ((y < 1.5) && (y > 0.5));
            return (xmean && ymean);
        }
    }
}
