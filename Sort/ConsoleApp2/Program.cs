using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int a;
            Console.WriteLine("Введите кол-во элементов в массиве");
            int n = int.Parse(Console.ReadLine());
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                a = int.Parse(Console.ReadLine());
                arr[i] = a;
            }
            Sort(arr, 0, arr.Length - 1);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
        static void Sort(int[] arr, int l, int r)
        {
            //i и j нужны для цикла
            int i = l;
            int j = r;
            int x = arr[(l + r) / 2]; //Опорная
            //Цикл сортировка5
            while (i <= j)
            {
                //Деление на меньше и больше опорного
                while (arr[i] < x) i++;
                while (arr[j] > x) j--;
                //Если i<=j:
                if (i <= j)
                {
                    //меняем значение элемонтов
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }
            //Рекурсия
            if (l < j) Sort(arr, l, j);
            if (i < r) Sort(arr, i, r);
        }
    }
}
