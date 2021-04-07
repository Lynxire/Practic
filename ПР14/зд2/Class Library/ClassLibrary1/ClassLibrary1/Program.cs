using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary12
{
    public class Person12
    {
        public string Фамилия;
        public string Имя;
        public string Отчество;
        public int Возраст;
        public string Адрес;//переменная
        public string Телефон;
        public string Номер_Карты;
        public int Год_рождения;
        public void create()
        {
            Console.WriteLine("Введите фамилию: ");
            Фамилия = Console.ReadLine();
            Console.WriteLine("Введите имя: ");
            Имя = Console.ReadLine();
            Console.WriteLine("Введите отчество: ");
            Отчество = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            Возраст = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите адрес: ");
            Адрес = Console.ReadLine();
            Console.WriteLine("Введите Телефон: ");
            Телефон = Console.ReadLine();
            Console.WriteLine("Введите Номер_Карты: ");
            Номер_Карты = Console.ReadLine();
            Console.WriteLine("Введите год рождения: ");
            Год_рождения = Convert.ToInt32(Console.ReadLine());
        }
        public void show()
        {
            Console.WriteLine("Фамилия: " + Фамилия);
            Console.WriteLine("Имя: " + Имя);
            Console.WriteLine("Отчество: " + Отчество);
            Console.WriteLine("Возраст: " + Возраст);
            Console.WriteLine("Адрес: " + Адрес);
            Console.WriteLine("Телефон: " + Телефон);
            Console.WriteLine("Номер_Карты: " + Номер_Карты);
            Console.WriteLine("Год рождения: " + Год_рождения);
        }
    }
}
