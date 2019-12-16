using System;
using System.Text;

namespace Homework2._2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите символ");
            string x = Console.ReadLine();
            byte[] bytes = Encoding.UTF8.GetBytes(x);
            foreach (byte b in bytes)
                Console.Write("0x{0}, 0x{1}", b + " ", b + 1);
            Console.ReadKey();

        }
    }
}
