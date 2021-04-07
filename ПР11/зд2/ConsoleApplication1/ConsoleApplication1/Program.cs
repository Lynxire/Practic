using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace thread_array
{
    class Program
    {
        static int[] AArray;
        static void Min()
        {
            Thread.Sleep(100);
            int minValue = AArray.Min();
            Console.WriteLine("Минимальное значение: " + minValue);
        }
        static void Max()
        {
            Thread.Sleep(100);
            int MaxValue = AArray.Max();
            Console.WriteLine("Максимальное значение: " + MaxValue);
        }
        static int[] Brray()
        {
            Random rand = new Random();
            AArray = new int[100];
            for (int i = 0; i < 100; i++)
            {
                AArray[i] = rand.Next(-50, 50);
                Console.Write("{0} элемент:{1}", i, AArray[i]);
                Console.Write("\t");
                if (i + 1 % 3 == 1 && i > 0) Console.WriteLine();
            }
            return AArray;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("100 элементов массива:");
            Brray();
            Thread thread1 = new Thread(() =>
                {
                    Thread.Sleep(100);
                    int minValue = AArray.Min();
                    Console.WriteLine("Минимальное значение: " + minValue);
                });
            Thread thread2 = new Thread(() =>
                {
                    Thread.Sleep(100);
                    int maxValue = AArray.Max();
                    Console.WriteLine("Максимальное значение: " + maxValue);
                });
            thread1.Start();
            Console.WriteLine("Работа потока 1 завершена");
            thread2.Start();
            Console.WriteLine("Работа потока 2 завершена");
            Console.ReadLine();
        }
    }
}

