using System;
using System.Collections;

namespace Edinstvennoe_slovo
{
    class Program
    {
        static void Main(string[] args)
        { int i = 0;
            Hashtable openWith = new Hashtable();
            string s; string[] str;
            Console.WriteLine("Введите строку");
            s = Console.ReadLine();
            str = s.Split(' ', ',', ';','.','!', '?');
            while(i< str.Length)
            {
                try
                {
                    openWith.Add(str[i], 1);
                }
                catch
                {
                    openWith[str[i]] = 0;
                }
                i++;
            }
            for (i = 0; i < openWith.Count; i++)
                if (openWith[str[i]].Equals(1))
                    Console.WriteLine("{0}", str[i]);
        }
    }
}
