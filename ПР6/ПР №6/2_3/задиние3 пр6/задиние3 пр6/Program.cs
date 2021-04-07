using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Рекурсия
{
    class Program
    {
        public int fact(int i)
        {
            if (i == 0) return (i + 1);
            else { i = i * fact(i - 1); return (i); }
        }


        public double f(int n)
        {
            
             return (fact(n-1))/(double)(fact(n-2)); 
        }
        static void Main(string[] args)
        {  
            int a;
            Console.WriteLine("Введите а: ");
            a =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a=" + a);
            Program d = new Program();
            Console.WriteLine("f(n)=(" + a + "-1)! / (" + a + "-2)!=" + d.f(a));
            Console.ReadKey();
        }
    }
}
