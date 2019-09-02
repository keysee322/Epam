using System;

namespace Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int a;
            int target;
            Console.WriteLine("Введите кол-во элементов в массиве");
            int n = int.Parse(Console.ReadLine());
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                a = int.Parse(Console.ReadLine());
                arr[i] = a;
            }
            Console.WriteLine("Введите число для поиска");
            target = int.Parse(Console.ReadLine());
            Search(arr, 0, arr.Length - 1, target);
        }
        static void Search(int[] arr, int l, int r, int target)
        {
            
            int ix = r / 2;
            int n = r;
            //Цикл сортировка5
            while (arr[ix] != target && n!=0)
            {
                if (target < arr[ix])
                {
                    ix /= 2;
                    r /= 2;
                }
                else
                {   if (r - ix == 1)
                        ix++;
                    ix += (r - ix)/ 2;
                }
                n /= 2;
            }
            if (target == arr[ix])
                Console.WriteLine("Есть");
            else Console.WriteLine("Нет");
        }
    }
}
