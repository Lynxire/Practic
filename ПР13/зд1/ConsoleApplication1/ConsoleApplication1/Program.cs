using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FikeKlass
{

    class Abityrient
    {
        public string Фамилия; //переменная 
        public string Имя;
        public string Отчество; //переменная  
        public string Адрес;
        public int Оценка;



        public void create()
        {
            Console.WriteLine("Фамилия: ");
            Фамилия = Console.ReadLine();
            Console.WriteLine("Введите имя: ");
            Имя = Console.ReadLine();
            Console.WriteLine("Введите отчество: ");
            Отчество = Console.ReadLine();
            Console.WriteLine("Введите адрес: ");
            Адрес = Console.ReadLine();
            Console.WriteLine("Введите оценку: ");
            Оценка = Convert.ToInt32(Console.ReadLine());

        }
        public void show()
        {
            Console.WriteLine("Фамилия " + Фамилия);
            Console.WriteLine("Имя " + Имя);
            Console.WriteLine("Отчество " + Отчество);
            Console.WriteLine("Адрес " + Адрес);
            Console.WriteLine("Оценка " + Оценка);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            Abityrient[] c = new Abityrient[n];
            for (int i = 0; i < n; i++)
            {
                c[i] = new Abityrient();
                c[i].create();
            }
            StreamWriter Write = new StreamWriter("File.Txt");

            Console.WriteLine("\nЧтобы получить информацию, нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Информация о абитуриентах");
            for (int i = 0;i < n;i++)
            {
                Console.Write("\n Абитуриент" + 1 + "-ый\n ");
                c[i].show();
            }
            string p = "Svitov";
            int v = 6;
            
            Write.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (c[i].Оценка < 4)
                {
                    Write.Write("Фамилия " + c[i].Фамилия + "\tИмя " + c[i].Имя + "\tОтчество " + c[i].Отчество + "\tАдрес  " + c[i].Адрес +
                        "\tОценка  " + c[i].Оценка); 
                    Write.WriteLine();
                }
                if (c[i].Фамилия == p && c[i].Оценка > v)
                {
                    Write.Write("Фамилия " + c[i].Фамилия + "\tИмя " + c[i].Имя + "\tОтчество" + c[i].Отчество + "\tАдрес  " + c[i].Адрес +
                        "\tОценка  " + c[i].Оценка); 
                    Write.WriteLine();
                    {
                        if (c[i].Оценка == c[i].Оценка)

                            Write.Write("Фамилия " + c[i].Фамилия + "\tИмя " + c[i].Имя + "\tОтчество " + c[i].Отчество + "\tАдрес  " + c[i].Адрес +
                                "\tОценка  ");
                        Console.WriteLine();
                       
                    }

                }
            }
            
            Write.Close();
            Console.ReadKey();
        }
    }
}
                
