using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        public double fact(double i)
        {
            if (i == 0) return (i + 3);
            else { i = i * fact(i - 1); return (i); }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Введите n: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("n=" + n);
            Program d = new Program();
            Console.WriteLine("Формула: f({0})= (1) / ({0}+3)!", n);
            Console.WriteLine("Результат:{0}", (d.fact(1) / d.fact(n + 3)));
            Console.ReadKey();
        }
    }
}