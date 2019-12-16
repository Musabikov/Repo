using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расстояние от центра квадрата до вершины");
            double radius = double.Parse(Console.ReadLine());
            double side = (radius + radius) / Math.Sqrt(2);
            double perim = (side * 4);
            double Square = (side * side);
            Console.WriteLine("Периметр квадрата равен: {0}. Площадь равна: {1}", perim, Square);
            Console.ReadKey();
        }
    }
}
