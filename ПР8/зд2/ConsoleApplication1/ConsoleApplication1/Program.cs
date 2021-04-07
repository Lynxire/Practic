using System;

namespace ConsoleApplication1
{
    class DataBase : IComparable<object>
    {
        public string FIO, Adres;
        public int Nomer, Vrema_vnytrennix_razgovorov;
        public int Vrema_mezdynarodnyh_razgovorov;
        byte sort;
        public DataBase() { }

        public DataBase(string FIO, string Adres, int Nomer, int Vrema_vnytrennix_razgovorov1, int Vrema_mezdynarodnyh_razgovorov1)
        {
            this.FIO = FIO;
            this.Adres = Adres;
            this.Nomer = Nomer;
            this.Vrema_vnytrennix_razgovorov = Vrema_vnytrennix_razgovorov1;
            this.Vrema_mezdynarodnyh_razgovorov = Vrema_mezdynarodnyh_razgovorov1;
        }
        public int CompareTo(object other)
        {
            DataBase db = other as DataBase;
            if (db != null)
            {
                switch (db.sort)
                {
                    case 1:
                        {
                            if (String.Compare(this.Adres, db.Adres) > 0)
                                return 1;
                            if (String.Compare(this.Adres, db.Adres) < 0)
                                return -1;
                            else
                                return 0;
                        }
                    case 2:
                        {
                            if (String.Compare(this.FIO, db.FIO) > 0)
                                return 1;
                            if (String.Compare(this.FIO, db.FIO) < 0)
                                return -1;
                            else
                                return 0;
                        }
                    case 3:
                        {
                            if (String.Compare(Convert.ToString(this.Nomer), Convert.ToString(db.Nomer)) > 0)
                                return 1;
                            if (String.Compare(Convert.ToString(this.Nomer), Convert.ToString(db.Nomer)) < 0)
                                return -1;
                            else
                                return 0;
                        }
                    case 4:
                        {
                            if (String.Compare(Convert.ToString(this.Vrema_vnytrennix_razgovorov), Convert.ToString(db.Vrema_vnytrennix_razgovorov)) > 0)
                                return 1;
                            if (String.Compare(Convert.ToString(this.Vrema_vnytrennix_razgovorov), Convert.ToString(db.Vrema_vnytrennix_razgovorov)) > 0)
                                return -1;
                            else
                                return 0;
                        }
                    default: throw new FormatException("Такой сортировки не существует");
                }
            }
            else
                throw new ArgumentException("Данный параметр не относится к базе данных");
        }
        public void Sort(ref DataBase[] db_object)
        {
            try
            {
                Array.Sort(db_object);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (DataBase d in db_object)
                Console.WriteLine("{0}\t{1}\t{2} \t{3} \t{4}", d.FIO, d.Adres, d.Nomer, d.Vrema_vnytrennix_razgovorov, d.Vrema_mezdynarodnyh_razgovorov);
        }
        public void NumberSort(byte j, ref DataBase[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i].sort = j;
        }
    }

    class Program
    {
        static void Main()
        {
            DataBase[] db_arr = new DataBase[5];
            db_arr[0] = new DataBase("Фалевич ", "д.жупраны ", 655666, 3, 6);
            db_arr[1] = new DataBase("Еваровский ", "ст.ошмяны ", 655666, 3, 8);
            db_arr[2] = new DataBase("Савицкий ", "ошмяны ", 655888, 1, 10);
            db_arr[3] = new DataBase("Богданович ", "ст.ошмяны ", 5353532, 5, 11);
            db_arr[4] = new DataBase("Шиманский ", "ст.ошмяны ", 8989565, 16, 19);


            Console.WriteLine("Исходная таблица: \n-------------------------------------------------------------------------------------------------------\n\n" +
            "ФИО \tАдрес \tНомер \t Время внутренних разговоров \t Время междугородних разговоров\n");
            foreach (DataBase d in db_arr)
                Console.WriteLine("{0}\t{1}\t{2} \t{3} \t{4}", d.FIO, d.Adres, d.Nomer, d.Vrema_vnytrennix_razgovorov, d.Vrema_mezdynarodnyh_razgovorov);
            Console.WriteLine("\nОтсортированная таблица БД по ФИО: " +
            "\n-------------------------------------------------------------------------------------------------------\n" +
            "ФИО \tАдрес \tНомер \t Время внутренних разговоров \t Время междугородних разговоров\n");
            DataBase sr1 = new DataBase();
            sr1.NumberSort(1, ref db_arr);
            sr1.Sort(ref db_arr);
            Console.WriteLine("\nОтсортированная таблица БД по Адрему : " +
            "\n-------------------------------------------------------------------------------------------------------\n" +
            "ФИО \tАдрес \tНомер \t Время внутренних разговоров \t Время междугородних разговоров\n");
            sr1.NumberSort(2, ref db_arr);
            sr1.Sort(ref db_arr);
            Console.WriteLine("\nОтсортированная таблица БД по Номеру: " +
            "\n-------------------------------------------------------------------------------------------------------\n" +
            "ФИО \tАдрес \tНомер \t Время внутренних разговоров \t Время междугородних разговоров\n");
            sr1.NumberSort(3, ref db_arr);
            sr1.Sort(ref db_arr);
           
        Console.WriteLine("\nОтсортированная таблица БД по времени внутригородских разговоров: " +
        "\n-------------------------------------------------------------------------------------------------------\n" +
        "ФИО \tАдрес \tНомер \t Время внутренних разговоров \t Время междугородних разговоров\n");
            sr1.NumberSort(4, ref db_arr);
            sr1.Sort(ref db_arr);
            Console.ReadLine();
        }
    }
}