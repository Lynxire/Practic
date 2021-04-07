using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary12;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Person12[] человек = new Person12[4];
            for (int i = 0; i < 4; i++)
            {
                человек[i] = new Person12();
                человек[i].create();
            }
            Console.WriteLine("\nЧтобы получить информацию, нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Введите возраст :");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nИнформация о возрасте:");
            for (int i = 0; i < 4; i++)
            {
                if (человек[i].Возраст > v)
                {
                    Console.Write("\n Человек " + (i + 1) + "-й\n ");
                    человек[i].show();
                }
            }
            int ob = 1960;
            Console.WriteLine("\nИнформация об годе рождения:");
            for (int i = 0; i < 4; i++)
            {
                if (человек[i].Год_рождения > ob)
                {
                    Console.Write("\n Человек " + (i + 1) + "-й\n ");
                    человек[i].show();
                }
            }
           
            Console.ReadKey();
        }
    }
}
