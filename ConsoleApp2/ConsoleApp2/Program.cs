using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 10;
            int sum = 0;
            double[] array = new double[n];
            for (int i = 0; i < n; i++) { array[i] = rnd.Next(0, 100); }
            int larg = int.MinValue;
            int sec = int.MinValue;
            foreach (int i in array)
            {
                if (i > larg)
                {
                    sec = larg;
                    larg = i;
                }
                else if (i > sec)
                    sec = i;

                if (i % 2 == 0) // проверка на четность
                    sum += i;
            }

             
            int index = Array.IndexOf(array, sec);
            Console.WriteLine("Исходный массив");
            Print(array);
            Console.WriteLine("{0}-элемент, является вторым по величине = {1}", index + 1, sec);
            BubbleSort(array);
            Console.WriteLine("Отсортированный массив");
            Print(array);

          
            Console.WriteLine("sum:"+ sum);      
            Console.ReadKey();
        }

        static void Print(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + @" ");
            Console.WriteLine();
        }
        public static void BubbleSort(double[] a)
        // Сортировка пузырьком
        {
            for (int i = 1; i <= a.Length - 1; ++i)
                for (int j = 0; j < a.Length - i; ++j)
                    if (a[j] < a[j + 1])
                        Swap(ref a[j], ref a[j + 1]);
        }



        public static void Swap(ref double x, ref double y)
        {
            double temp = x;
            x = y;
            y = temp;
        }
    }
}
