using System;
using System.Collections.Generic;

namespace Abituruen
{
    class Program
    {

        static void Main(string[] args)
        {
            Abituruen[] Abiturueni = new Abituruen[]
            {
new Abituruen("Сергеев ", "Минск ", 4, 5, 5),
new Abituruen("Белов ", "Москва ", 3, 5, 5),
new Abituruen("Аваков ", "Мариуполь ", 5, 5,5),
new Abituruen("Козлов ", "Минск ", 5, 4, 5),
new Abituruen("Канатов ", "Минск ", 3, 3, 4)
            };
            List<string> st = new List<string>();
            int count = 0;

            for (int i = 0; i < Abiturueni.Length; i++)
                if (Abiturueni[i].SrednBal >= 4.5 && Abiturueni[i].Adr == "Минск ")
                { st.Add(Abiturueni[i].Fio); count++; }

            Console.WriteLine("Количество студентов проживающих в Минске, и прошедшие экзамены = {0}", count);
            Console.WriteLine("Отсортированный список студентов по алфавитному порядку:");

            st.Sort();
            foreach (string q in st)
                Console.WriteLine(q);
            Console.ReadKey();
        }
    }

    class Abituruen
    {
        string FIO;
        string Adress;
        int ocen_mathem;
        int ocen_fiz;
        int ocen_yazik;

        public Abituruen(string FIO, string Adress, int ocen_mathem, int ocen_fiz, int ocen_yazik)
        {
            this.FIO = FIO;
            this.Adress = Adress;
            this.ocen_mathem = ocen_mathem;
            this.ocen_fiz = ocen_fiz;
            this.ocen_yazik = ocen_yazik;
            Console.WriteLine("Фамилия: " + FIO);
            Console.WriteLine("Адрес: " + Adress);
            Console.WriteLine("Оценка по математике: " + ocen_mathem);
            Console.WriteLine("Оценка по физике: " + ocen_fiz);
            Console.WriteLine("Оценка по русскоум: " + ocen_yazik);
            Console.WriteLine("--------------------------------------");
        }
        float Sredn_bal()
        {
            return (float)(ocen_fiz + ocen_mathem + ocen_yazik) / 3;
        }
        public string Adr
        {
            get { return Adress; }
        }
        public float SrednBal
        {
            get { return Sredn_bal(); }
        }
        public string Fio
        {
            get { return FIO; }
        }
    }
}