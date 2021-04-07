using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klass
{
    class Organiz
    {
        public string Nazv { get; set; }
        public int Kol_Chl 
        { 
             get { return Kol_Chl; } 
             set
            {
                if (value < 0)
                {
                    Console.WriteLine("Процент не может быть отрицательным числом!");
                }
                if (value > 120)
                {
                    Console.WriteLine("Слишком долго");
                }
                
            }
        }

        public Organiz(string nazv, int kol_chl)
        {
            Nazv = nazv;
            Kol_Chl = kol_chl;
        }
        public Organiz()
        {
            Nazv = "";
            Kol_Chl = 0;
        }

        public virtual void ShowInfo() //объявление виртуального метода
        {
            Console.WriteLine("Радиоволны\nНазвание: " + Nazv + "\n" + "Процент: " + Kol_Chl + "\n");
        }
        public virtual void SetInfo() //объявление виртуального метода
        {
            Console.WriteLine("Радиоволны: ");
            Nazv = Console.ReadLine();
            Console.WriteLine("Процент: ");
            Kol_Chl = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Strah_Com : Organiz
    {
        public int Kol_Yslyg { get; set; }

        public Strah_Com(string nazv, int kol_chl, int kol_ysl)
            : base(nazv, kol_chl)
        {
            Kol_Yslyg = kol_ysl;
        }
        public Strah_Com()
            : base()
        {
            Kol_Yslyg = 0;
        }
        public override void ShowInfo() //переопределение метода
        {
            Console.WriteLine("электромагнитное излучение\nНазвание: " + Nazv + "\n" + "Процент: " + Kol_Chl + "\n" + "Количество электромагнитного излучения: " + Kol_Yslyg + "\n");
        }
        public override void SetInfo() //переопределение метода
        {
            Console.WriteLine("Название излучения: ");
            Nazv = Console.ReadLine();
            Console.WriteLine("Процент: ");
            Kol_Chl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество электромагнитного излучения: ");
            Kol_Yslyg = Convert.ToInt32(Console.ReadLine());
        }
    }

    class NefGaz_Com : Organiz
    {
        public int Kol_Tovara { get; set; }

        public NefGaz_Com(string nazv, int kol_chl, int kol_tov)
            : base(nazv, kol_chl)
        {
            Kol_Tovara = kol_tov;
        }
        public NefGaz_Com()
            : base()
        {
            Kol_Tovara = 0;
        }
        public override void ShowInfo() //переопределение метода
        {
            Console.WriteLine("ультрафиолет\nНазвание: " + Nazv + "\n" + "Процент: " + Kol_Chl + "\n" + "Количество реализованного ультрафиолета: " + Kol_Tovara + "\n");
        }
        public override void SetInfo() //переопределение метода
        {
            Console.WriteLine("Название ультрафиолета: ");
            Nazv = Console.ReadLine();
            Console.WriteLine("Процент: ");
            Kol_Chl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество реализованного ультрафиолета: ");
            Kol_Tovara = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Zavod : Organiz
    {
        public int Kol_Prodykcii { get; set; }

        public Zavod(string nazv, int kol_chl, int kol_prod)
            : base(nazv, kol_chl)
        {
            Kol_Prodykcii = kol_prod;
        }
        public Zavod()
            : base()
        {
            Kol_Prodykcii = 0;
        }
        public override void ShowInfo() //переопределение метода
        {
            Console.WriteLine("Рентгеновские лучи\nНазвание: " + Nazv + "\n" + "Процент: " + Kol_Chl + "\n" + "Количество лучей: " + Kol_Prodykcii + "\n");
        }
        public override void SetInfo() //переопределение метода
        {
            Console.WriteLine("Название рентгеновских лучей: ");
            Nazv = Console.ReadLine();
            Console.WriteLine("Процент: ");
            Kol_Chl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество лучей: ");
            Kol_Prodykcii = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Organiz[] mas = new Organiz[4];
            mas[0] = new Organiz();
            mas[1] = new Strah_Com();
            mas[2] = new NefGaz_Com();
            mas[3] = new Zavod();

            for (int i = 0; i < 4; i++)
                mas[i].SetInfo();

            for (int i = 0; i < 4; i++)
                mas[i].ShowInfo();

            Console.ReadKey();
        }
    }
}