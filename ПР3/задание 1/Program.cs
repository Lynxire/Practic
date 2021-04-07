using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;

namespace Phone
{
    class Телефон
    {
        public string Фамилия;
        public string Имя;
        public string Отчество;
        public string Адрес;
        public long Номер;
        public int Время_внутригородских_разговоров;
        public int Время_междугородних_разговоров;


        public void create()
        {
            Console.WriteLine("Введите Фамилию: ");
            Фамилия = Console.ReadLine();
            Console.WriteLine("Введите Имя: ");
            Имя = Console.ReadLine();
            Console.WriteLine("Введите Отчество: ");
            Отчество = Console.ReadLine();
            Console.WriteLine("Введите Адрес: ");
            Адрес = Console.ReadLine();
            Console.WriteLine("Введите Номер: ");
            Номер = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Время внутригородских разговоров: ");
            Время_внутригородских_разговоров = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Время междугородних разговоров: ");
            Время_междугородних_разговоров = Convert.ToInt32(Console.ReadLine());

        }
        public void show()
        {
            Console.WriteLine("Фамилия: " + Фамилия);
            Console.WriteLine("Имя: " + Имя);
            Console.WriteLine("Отчество: " + Отчество);
            Console.WriteLine("Адрес: " + Адрес);
            Console.WriteLine("Номер: " + Номер);
            Console.WriteLine("Время внутригородских разговоров: " + Время_внутригородских_разговоров);
            Console.WriteLine("Время междугородних разговоров: " + Время_междугородних_разговоров);


        }

        class Program
        {
            static void Main (string[] args)
            {
                Телефон[] телефон = new Телефон[4];
                for (int i = 0; i < 2; i++)
                {
                    телефон[i] = new Телефон();
                    телефон[i].create();
                }
                Console.WriteLine("\nЧтобы получить информацию, нажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Введите время внутригородских разговоров :");
                long rk = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Информация о телефонах :");
                for (int i = 0; i < 2; i++)
                {
                    if (телефон[i].Время_внутригородских_разговоров >= rk)
                    {
                        Console.Write("\n Телефон " + (i + 1) + "-ая\n ");
                        телефон[i].show();
                    }

                }
                Console.WriteLine("Введите телефоны, воспользовавшихся междугородней связью :");
                long vs = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Информация о телефонах :");
                for (int i = 0; i < 2; i++)
                {
                    if (телефон[i].Время_междугородних_разговоров >= vs)
                    {
                        Console.Write("\n Телефон " + (i + 1) + "-ая\n ");
                        телефон[i].show();
                    }

                }
                Console.WriteLine("Введите телефоны :");
                string kr = Console.ReadLine();
                Console.WriteLine("Информация о телефонах :");
                for (int i = 0; i < 2; i++)
                {
                    if (телефон[i].Фамилия != kr)
                    {
                        Console.Write("\n Телефон " + (i + 1) + "-ая\n ");
                        телефон[i].show();
                    }

                }
                Console.ReadKey();
            }
        }
    }
}