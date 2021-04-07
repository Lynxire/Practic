using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace перевод
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num = 0;
            char[] str = new char[16];
            char[] str1 = new char[16];
            Console.WriteLine("Введите число в восьмиричной системе счисления");
            str = Console.ReadLine().ToCharArray();
            for (i = 0; i < str.Length; i++)
            {
                num += str[i] - 48;
                if (i + 1 != str.Length) num *= 8;
            }

            for (i = 0; num > 0; i++)
            {
                //Запись в строку разряда числа 
                str1[i] = Convert.ToChar(num % 2 + 48);
                //Деление числа на основание системы исчисления 
                num /= 2;
            }

            for (int j = 0; j < i / 2; j++)
            {
                char ch = str1[j];     //Обратное отражение строки через 
                str1[j] = str1[i - j - 1];  //дополнительную переменную 
                str1[i - j - 1] = ch;
            }
            Console.WriteLine("Результат в двоичной системе счисления ");
            Console.WriteLine(str1);        //Вывод результата на экран 
            Console.ReadKey();
        }
    }
}
