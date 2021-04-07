using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    
    class Program
    {
        
        // Метод, изменяющий свой аргумент
        static void myCh(ref char c)
        {
            c = 'A';
        }
        static void myCj(ref char t)
        {
            t = 'C';
        }
        static void Swap(ref char x, ref char y, ref char o, ref char l)
        {
            char c;
            c = x;
            x = y;
            y = c;
            char t;
            t = o;
            o = l;
            l = t;
        }
        // Метод меняющий местами аргументы
        static void Swap(ref char o, ref char l)
        {
            char t;
            t = o;
            o = l;
            l = t;
        }
        delegate void swapd(ref char ch);
        static void Main()
        {

            swapd sw;
            sw = myCh;
           
            char ch = 'B', A = '2', B = '4';
            Console.WriteLine("Переменная ch до вызова метода myCh: {0}", ch);
            sw(ref ch);
            Console.WriteLine("Переменная ch после вызова метода myCh: {0}", ch);

            Console.WriteLine("\nПеременная A = {0}, переменная B = {1}", A, B);
             Swap(ref A, ref B);
            Console.WriteLine("Теперь A = {0}, B = {1}", A, B);

            Console.ReadLine();
        }
    }
}