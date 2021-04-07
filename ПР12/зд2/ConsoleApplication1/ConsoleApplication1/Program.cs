using System;

namespace TemplateK
{
    class PhoneInfo
    {
        public PhoneInfo(string ФИО, string адрес, int номер ,int время_внутр_разговоров)
        {
            this.ФИО = ФИО;
            this.адрес = адрес;
            this.номер = номер;
            this.время_внутр_разговоров = время_внутр_разговоров;
            
        }
        public PhoneInfo()
        {
            Console.WriteLine("Введите ФИО");
            this.ФИО = Console.ReadLine();
            Console.WriteLine("Введите адрес");
            this.адрес = Console.ReadLine();
            Console.WriteLine("Введите номер");
            this.номер = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите время внутригородских разговоров");
            this.время_внутр_разговоров = Convert.ToInt32(Console.ReadLine());
            
        }
        public string ФИО { get; set; }
        public string адрес { get; set; }
        public int номер { get; set; }
        public int время_внутр_разговоров{ get; set; }
       
    }
    //Создадим класс, унаследованный от UserInfo
    class AllInfoPhone : PhoneInfo
    {
        public AllInfoPhone(string ФИО  ,string адрес, int номер  , int время_внутр_разговоров, int время_между_разговоров)
            : base(ФИО, адрес, номер, время_внутр_разговоров)
        {
            this.время_между_разговоров = время_между_разговоров;
        }
        public AllInfoPhone()
            : base()
        {
            Console.WriteLine("Введите время междугородских разговоров ");
            this. время_между_разговоров = Convert.ToInt32(Console.ReadLine());
        }
        public int время_между_разговоров { get; set; }
        public override string ToString()
        {
            string s = String.Format("Информация о телефоне: \n{0} {1} {2} {3} {4}\n",
                this.ФИО, this.адрес, this.номер, this.время_внутр_разговоров, время_между_разговоров);
            return s;
        }
    }
    //Обобщённый класс, использующий ограничение на базовый класс
    class Info<T> where T : PhoneInfo
    {
        T[] PhoneList;
        int i;
        public Info()
        {
            PhoneList = new T[2];
            i = 0;
        }

        public void Add(T obj)
        {
            if (i == 2) return;
            PhoneList[i] = obj;
            i++;
            return;
        }

        public void ReWrite()
        {
            foreach (T t in PhoneList)
                Console.WriteLine(t.ToString());
        }
    }

    class Program
    {
        static void Main()
        {
            Info<AllInfoPhone> database1 = new Info<AllInfoPhone>();
            Console.WriteLine("Используя ограничение цикла for ");
            for (int i = 0; i < 2; i++)
                database1.Add(new AllInfoPhone());
            database1.ReWrite();
            Info<AllInfoPhone> database2 = new Info<AllInfoPhone>();
            Console.WriteLine("Используя ограничение обобщённого класса ");
            database2.Add(new AllInfoPhone(ФИО: "Фалевич Алексей Викторович", адрес: "Жупраны", номер:6358963, время_внутр_разговоров: 8, время_между_разговоров: 9));
            database2.Add(new AllInfoPhone(ФИО: "Еваровский Андрей Ромуальдович", адрес: "Ошмяны", номер: 6897512, время_внутр_разговоров: 6, время_между_разговоров: 10));
            //Ограничение обобщённого класса не даст внести больше обхектов, чем нужно
            database2.Add(new AllInfoPhone(ФИО: "Авгуль Владислав Павлович", адрес: "Жупраны", номер:5631233, время_внутр_разговоров: 2, время_между_разговоров: 13));
            database2.ReWrite();

            Console.ReadLine();
        }
    }
}