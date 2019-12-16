using System;

namespace Homework2._1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите ваш адрес электронной почты");
            string str = Console.ReadLine();
            string a1;
            string a2;
            int k;
            k = str.IndexOf('@');
            a1 = str.Substring(0, k);
            a2 = str.Substring(k + 1);
            Console.WriteLine("Ваш почтовый ящик {0} находится на домене {1}", a1, a2);
            Console.ReadKey();

        }
    }
}
