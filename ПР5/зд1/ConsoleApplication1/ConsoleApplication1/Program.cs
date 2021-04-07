using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Try1
{
    class ProductException : Exception
    {
        public ProductException(string message) : base(message) { }
    }
    class Product
    {
        public string ФИО;
        public int Номер_автобуса;
        public int Номер_маршрута;
        public string Марка;
        public int Годначалаэксплуатации;
        public int Пробег;

        public int Srok 
        {
            get { return Номер_маршрута; }
            set
            {
                if (value < 0)
                {
                    throw new ProductException("номер маршрута не может быть отрицательным числом!");
                }
                else if (value > 120)
                {
                    throw new ProductException("Слишком долго");
                }
                else Годначалаэксплуатации = value;
            }
        }
        public int Kol
        {
            get { return Пробег; }
            set
            {
                if (value < 1)
                {
                    throw new ProductException("Пробег не может быть отрицательным или меньше 1!");
                }
                else if (value > 10000)
                {
                    throw new ProductException("Введено слишком большое число.");
                }
                else Пробег = value;
            }


        }
        public void create()
        {
            Console.WriteLine("ФИО: ");
            ФИО = Console.ReadLine();
            Console.WriteLine("Номер автобуса: ");
            Номер_автобуса =Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Номер марштрута: ");
            Номер_маршрута = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Марка: ");
            Марка = Console.ReadLine();
            Console.WriteLine("Год начала эксплуатации ");
            Годначалаэксплуатации = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Пробег ");
            Пробег= Convert.ToInt32(Console.ReadLine());
        }
        public void show()
        {
            Console.WriteLine("ФамилияИО: " + ФИО);
            Console.WriteLine("Номер автобуса: " + Номер_автобуса);
            Console.WriteLine("Номер маршрута: " + Номер_маршрута);
            Console.WriteLine("Год начала эксплуатации: " + Годначалаэксплуатации+ " дней");
            Console.WriteLine("Пробег: " + Пробег + " км");
            Console.WriteLine("Марка: " + Марка );

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Product продукт = new Product();
                Console.WriteLine("Введите ФИО: ");
                продукт.ФИО = Console.ReadLine();
                Console.WriteLine("Введите номер автобуса: ");
                продукт.Номер_автобуса = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите номер маршрута: ");
                продукт.Srok = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите год начала эксплуатации: ");
                продукт.Годначалаэксплуатации = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите пробег : ");
                продукт.Kol = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите марку: ");
                продукт.Марка = Console.ReadLine();
                Console.WriteLine("\nЧтобы получить информацию, нажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
                Console.Write("Информация об автобусе \n ");
                Console.WriteLine();
                продукт.show();
            }
            catch (ProductException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.ReadKey(); 
        }
    }
}
