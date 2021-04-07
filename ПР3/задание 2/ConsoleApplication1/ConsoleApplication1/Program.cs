using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    [Serializable]
    abstract class Здание
    {
        protected string Наименование { get; set; }
        protected int Стоимость { get; set; }


        public Здание(string наименование, int стоимость)
        {
            Наименование = наименование;
            Стоимость = стоимость;
        }

    }
    [Serializable]
    sealed class Балансовая_стоимость : Здание
    {
        public int _стоимость{ get; set; }

        public Балансовая_стоимость(string наименование, int стоимость)
            : base(наименование, стоимость)
        {
            _стоимость = 350;
        }
        public void monitoring()
        {
            Console.WriteLine("Наименование: " + Наименование  + ";" + "\nСтоимость: " + (_стоимость) + " руб.");
        }
    }
    [Serializable]
    sealed class Без_бл : Здание
    {
        public int бл { get; set; }

        public Без_бл(string наименование, int стоимость)
            : base(наименование, стоимость) { }

        public void monitoring()
        {
            Console.WriteLine("Наименование: " + Наименование + ";" + "\nСтоимость: " + (Стоимость) + " руб.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Балансовая_стоимость[] a = new Балансовая_стоимость[3];
            a[0] = new Балансовая_стоимость("Агроусадьба", 1500);
            a[1] = new Балансовая_стоимость("Школа", 1350);
            a[2] = new Балансовая_стоимость("Колледж", 1200);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nСтоимость " + (i + 1) + " балансовая_стоимость");
                a[i].monitoring();
            }

            Без_бл[] b = new Без_бл[3];
            b[0] = new Без_бл("Агроусадьба", 1500);
            b[1] = new Без_бл("Школа", 1350);
            b[2] = new Без_бл("Колледж", 1200);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nСтоимость " + (i + 1) + " подключение к сетям коммуникации");
                b[i].monitoring();
            }
            Console.ReadKey();
        }
    }
}