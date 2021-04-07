using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число :");
            int K = Convert.ToInt32(Console.ReadLine());
            int D = 9;
            int D1 = 4;
            int D2 = 1;
            AddRightDigit(ref K, D);
            AddRightDigit(ref K, D1, D2);
           

            Console.ReadKey();
        }
        public static void AddRightDigit(ref int K, int D)
        {

            K = K * 10 + D;

            Console.WriteLine(K);


        }public static void AddRightDigit(ref int K, int D1, int D2)
        {

            K = K * 10 + D1;
            K = K * 10 + D2;

            Console.WriteLine(K);


        }

    }
}
