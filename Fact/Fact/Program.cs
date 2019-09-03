using System;

namespace Fact
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите число");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Факториал числа = {0}", Factorial(a));
        }
        static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}
