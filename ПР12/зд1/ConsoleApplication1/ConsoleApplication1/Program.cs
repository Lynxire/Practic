using System;

namespace TemplateM
{
    //Создадим необобщённый класс
    class InfoObject
    {
        //Обобщённый метод использующий также ограничение
        public static string Info<T>(T obj)
        where T : Biblioteka
        {
            return obj.ToString();
        }
    }

    class Biblioteka
    {
    
        public Biblioteka(int reg_nomer, string avtor, string nazvanie, int got_izdania, string izdatelstvo, int kol_str)
        {
            this.reg_nomer = reg_nomer;
            this.avtor = avtor;
            this.nazvanie = nazvanie;
            this.got_izdania= got_izdania;
            this.izdatelstvo=izdatelstvo;
            this.kol_str=kol_str;
        }

        public Biblioteka()
        {
            Console.WriteLine("Введите регестрационный номер: ");
            this.reg_nomer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите автора: ");
            this.avtor = Console.ReadLine();
            Console.WriteLine("Введите название: ");
            this.nazvanie = Console.ReadLine();
            Console.WriteLine("Введите год издания:");
            this.got_izdania = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите издательство:");
            this.izdatelstvo = Console.ReadLine();
            Console.WriteLine("Введите количество страниц:");
            this.kol_str = Convert.ToInt32(Console.ReadLine());

        }
        public int reg_nomer { get; set; }
        public string avtor { get; set; }
        public string nazvanie { get; set; }
        public int got_izdania { get; set; }
        public string izdatelstvo { get; set; }
        public int kol_str { get; set; }

    }

    class BibliotekaIncome : Biblioteka
    {
        public BibliotekaIncome(int reg_nomer, string avtor, string nazvanie, int got_izdania, string izdatelstvo, int kol_str,string Income)
            : base(reg_nomer, avtor, nazvanie, got_izdania,izdatelstvo, kol_str)
        {
            IncomePFM = Income;
        }

        public BibliotekaIncome()
            : base()
        {
            Console.WriteLine("Введите доход студента: ");
            IncomePFM = Console.ReadLine();
        }
        public string IncomePFM { get; set; }
        public override string ToString()
        {
            return String.Format(@"Список студентов :
        ****************************************
        Регестрационный номер: {0}
        Автор: {1}
        Название: {2}
        Год издания: {3}
        Издательство: {4}
        Количество страниц: {5}
        Доход студента: {6}", reg_nomer, avtor, nazvanie, got_izdania, izdatelstvo, kol_str, IncomePFM);
        }
    }

    class Program
    {
        static void Main()
        {
            BibliotekaIncome[] student1 = new BibliotekaIncome[3];
            for (int i = 0; i < 3; i++)
            {
                student1[i] = new BibliotekaIncome();
            }

            //Вызываем обобщённый метод
            string s;
            for (int i = 0; i < 2; i++)
            {
                s = InfoObject.Info<BibliotekaIncome>(student1[i]);
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}