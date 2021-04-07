using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_3
{
    class Program
    {
        public double fact(double i)
        {
            if (i == 0) return (i + 1);
            else { i = i * fact(i - 1); return (i); }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите n: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Program d = new Program();
            Console.WriteLine("Формула: f({0})=({0}-1)!/{0}!", n);
            Console.WriteLine("Результат: {0}", (d.fact(n-1)/d.fact(n)));
            Console.ReadKey();
        }
    }
}
