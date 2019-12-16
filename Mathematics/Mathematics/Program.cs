using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение х");
            double x = double.Parse(Console.ReadLine());
            double y = ((Math.Abs(x + 1)) - (Math.Abs(x - 1))) / (Math.Abs(x));
            Console.WriteLine("F(x) = {0}", y);
            Console.ReadLine();
        }
    }
}
