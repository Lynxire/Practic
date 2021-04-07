using System;

namespace TemplateI
{
    //Используем обобщённый интерфейс IComparable
    class Abityrient  : IComparable<object>
    {
        public string Фамилия;
        public string Имя;
        public string Отчество;
        public string Адрес;
        public int Оценка;
        byte sort;//Переменная, принимающая возможные значения типа сортировки

        public Abityrient(string Фамилия, string Имя, string Отчество, string Адрес, int Оценка)
        {
            this.Фамилия = Фамилия;
            this.Имя = Имя;
            this.Отчество = Отчество;
            this.Адрес = Адрес;
            this.Оценка = Оценка;
        }
        public Abityrient()
        {
            Console.WriteLine("Введите фамилию: ");
            this.Фамилия = Console.ReadLine();
            Console.WriteLine("Введите имя: ");
            this.Имя = Console.ReadLine();
            Console.WriteLine("Введите отчество: ");
            this.Отчество = Console.ReadLine();
            Console.WriteLine("Введите адрес: ");
            this.Адрес = Console.ReadLine();
            Console.WriteLine("Введите оценку: ");
            this.Оценка = Convert.ToInt32(Console.ReadLine());
        }
        public Abityrient (int d)
        {
            this.Фамилия = "";
            this.Имя = "";
            this.Отчество = "";
            this.Адрес = "";
            this.Оценка = 0;
        }

        //Реализуем интерфейс IComparable<T>
        public int CompareTo(object other)
        {
            //Проверим тип объекта obj
             Abityrient db = other as Abityrient;
            if (db != null)
            {
                switch (db.sort)
                {
                    case 1:
                        {
                            if (String.Compare(this.Фамилия, db.Фамилия) > 0)
                                return 1;
                            if (String.Compare(this.Фамилия, db.Фамилия) < 0)
                                return -1;
                            else
                                return 0;
                        }
                    case 2:
                        {
                            if (String.Compare(this.Имя, db.Имя) > 0)
                                return 1;
                            if (String.Compare(this.Имя, db.Имя) < 0)
                                return -1;
                            else
                                return 0;
                        }
                    case 3:
                        {
                            if (String.Compare(this.Отчество, db.Отчество) > 0)
                                return 1;
                            if (String.Compare(this.Отчество, db.Отчество) < 0)
                                return -1;
                            else
                                return 0;
                        }
                    case 4:
                        {
                            if (String.Compare(this.Адрес, db.Адрес) > 0)
                                return 1;
                            if (String.Compare(this.Адрес, db.Адрес) < 0)
                                return -1;
                            else
                                return 0;
                        }
                    
                    case 5:
                        {
                            if (this.Оценка> db.Оценка)
                                return 1;
                            if (this.Оценка < db.Оценка)
                                return -1;
                            else
                                return 0;
                        }
                    default:
                        throw new FormatException("Такой сортировки не существует.");
                }
            }
            else
                throw new FormatException("Данный параметр не относится к базе данных.");
        }

        //Метод, реализующий сортировку
        public void Sort(ref Abityrient[] db_object)
        {
            try
            {
                Array.Sort(db_object);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (Abityrient d in db_object)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", d.Фамилия, d.Имя, d.Отчество, d.Адрес,d.Оценка);
        }

        public void NumberSort(byte j, ref Abityrient[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i].sort = j;
        }
    }

    class Program
    {
        static void Main()
        {
            Abityrient[] db_arr = new Abityrient[3];

            for (int i = 0; i < 3; i++)
            {
                db_arr[i] = new Abityrient();
            }

            Console.WriteLine("Исходная таблица: \n-----------------\n\n" +
                "Фамилия\tИмя\tОтчество\t Адрес\tОценка\n");
            foreach (Abityrient d in db_arr)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", d.Фамилия, d.Имя, d.Отчество, d.Адрес,  d.Оценка);

            Console.WriteLine("\nОтсортированная таблица БД по фамилии: " +
                "\n----------------------------------------------------------------------------------------------------\n" +
                "Фамилия\tИмя\tОтчество\tАдрес\tОценка\n");
            Abityrient sr1 = new Abityrient(0);
            sr1.NumberSort(1, ref db_arr);
            sr1.Sort(ref db_arr);

            Console.WriteLine("\nОтсортированная таблица БД по имени: " +
                "\n----------------------------------------------------------------------------------------------------\n" +
                "Фамилия\tИмя\tОтчество\tАдрес\tОценка\n");
            sr1.NumberSort(2, ref db_arr);
            sr1.Sort(ref db_arr);

            Console.WriteLine("\nОтсортированная таблица БД по отчеству: " +
                "\n----------------------------------------------------------------------------------------------------\n" +
                "Фамилия\tИмя\tОтчество\tАдрес\tОценка\n");
            sr1.NumberSort(3, ref db_arr);
            sr1.Sort(ref db_arr);

            Console.WriteLine("\nОтсортированная таблица БД по адресу: " +
                "\n----------------------------------------------------------------------------------------------------\n" +
                "Фамилия\tИмя\tОтчество\tАдрес\tОценка\n");
            sr1.NumberSort(4, ref db_arr);
            sr1.Sort(ref db_arr);

            Console.WriteLine("\nОтсортированная таблица БД по оценкам: " +
                "\n----------------------------------------------------------------------------------------------------\n" +
                "Фамилия\tИмя\tОтчество\tАдрес\tОценка\n");
            sr1.NumberSort(5, ref db_arr);
            sr1.Sort(ref db_arr);

            Console.ReadLine();
        }
    }
}
