using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Del_kl
{
    public delegate void MYdelev(); // объявляем делегат для события создания 
    public delegate void MYdelevS(); // объявляем делегат для события просмотр 
    class House   //источник события 
    {
        public string Фамилия_имя_отчество; 
        public string Адрес;
        public int Оценка;

        public event MYdelev MyEv; // объявляем событие создание 
        public event MYdelevS MyEvS;// объявляем событие просмотр 

        public void create() // событие создание дома 
        {
            Console.WriteLine("Введите фамилию,имя,отчество: ");
            Фамилия_имя_отчество = Console.ReadLine();
            Console.WriteLine("Введите Адрес: ");
            Адрес = Console.ReadLine();
            Console.WriteLine("Введите оценку: ");
            Оценка = Convert.ToInt32(Console.ReadLine());
            
            if (MyEv != null) MyEv();
        }

        public void show()// событие просмотр дома
        {

            Console.WriteLine("Фамилия,имя,отчество: " + Фамилия_имя_отчество);
            Console.WriteLine("Адрес: " + Адрес);
            Console.WriteLine("Оценка: = " + Оценка);
            
            if (MyEvS != null) MyEvS();
        }
    }
    class Owner1// наблюдатель события создания до
    {
        public void Do_Event()
        {
            Console.WriteLine("Вижу, что получил  оценку.");
        }
    }
    class Owner2// наблюдатель события просмотра дома 
    {
        public void Do_Event()
        {
            Console.WriteLine("Вижу, что оценка хорошая .");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            House[] a = new House[2];
            Owner1 mama = new Owner1();
            Owner2 brat = new Owner2();
            for (int i = 0; i < 2; i++)
            {
                a[i] = new House();
                a[i].MyEv += new MYdelev(mama.Do_Event);
                a[i].create();

            }

            Console.WriteLine("\nЧтобы получить информацию, нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Информация об абитуриентах:");
            for (int i = 1; i < 2; i++)
            {
                Console.Write("\n Абитуриент " + i + "-й\n ");
                a[i].MyEvS += new MYdelevS(brat.Do_Event);
                a[i].show();
            }
            Console.ReadKey();
        }
    }
}

