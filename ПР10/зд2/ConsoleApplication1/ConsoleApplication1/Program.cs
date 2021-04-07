using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Del_kl
{
    class Patient
    {
        public string Фамилия_Имя_Отчество;
        public string Адрес;
        public int Номер_медицинской_карты;
        public string Диагноз;

        public void create()
        {
            Console.WriteLine("Введите фамилию , имя, отчество: ");
            Фамилия_Имя_Отчество= Console.ReadLine();
            Console.WriteLine("Введите Адрес: ");
            Адрес = Console.ReadLine();
            Console.WriteLine("Введите номер медицинской карты: ");
            Номер_медицинской_карты= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Диагноз: ");
            Диагноз= Console.ReadLine();
        }
        public void show()
        {
            Console.WriteLine("Фамилия,имя,отчество: " + Фамилия_Имя_Отчество);
            Console.WriteLine("Адрес: " + Адрес);
            Console.WriteLine("Номер медицинской карты:  " + Номер_медицинской_карты);
            Console.WriteLine("Диагноз: " + Диагноз);
        }
    }
    class Program
    {
        delegate void My1();
        delegate void My2();
        static void Main(string[] args)
        {
            Patient[] a = new Patient[4];
            for (int i = 0; i < 2; i++)
            {
                a[i] = new Patient();
                My1 dl1 = new My1(a[i].create);
                dl1();
            }
            Console.WriteLine("\nЧтобы получить информацию, нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Информация о пациентах:");
            for (int i = 1; i < 2; i++)
            {
                Console.Write("\n Пациент  " + i + "-й\n ");
                My2 dl2 = new My2(a[i].show);
                dl2();
            }
            Console.ReadKey();
        }
    }
}