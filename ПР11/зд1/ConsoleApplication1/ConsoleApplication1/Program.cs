using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace potok
{
    class Program
    {
        public double TriangleP(int a) //функция 1
        {
            return 3 * a;
        }
        public double TriangleP(int a, int b)
        {
            return a * 2 + b;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a, b;
            Program d = new Program();
            //создаём основной поток
            Thread Myth = new Thread(new ThreadStart(Count));
            Myth.Start(); //запускаем поток
            for (int i = 1; i < 9; i++)
            {
                a = rnd.Next(10);
                b = rnd.Next(10);
                Console.WriteLine("Главный поток:");
                Console.WriteLine("a = " + a + " b = " + b);
                Console.WriteLine("Вызов 1 функции:");
                Console.WriteLine("P = " + d.TriangleP(a));
                Thread.Sleep(300);
            }
        }
        public static void Count()
        {
            Random rnd = new Random();
            int a, b;
            Program d = new Program();
            for (int i = 1; i < 9; i++)
            {
                a = rnd.Next(10);
                b = rnd.Next(10);
                Console.WriteLine("Второй поток:");
                Console.WriteLine("a = " + a + " b = " + b);
                Console.WriteLine("Вызов 2 функции:");
                Console.WriteLine("P = " + d.TriangleP(a, b));
                Thread.Sleep(400);
            }
            Console.ReadKey();
        }
    }
}
