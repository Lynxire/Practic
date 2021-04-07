using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Получаем номер выделенной строки
            int index = listBox1.SelectedIndex;
            //Считываем строку в переменную str
            string str = (string)listBox1.Items[index]; 
            //Узнаём количество символов в строке
            int len = str.Length;
            //Считаем, что количество пробелов равно 0
            int count = 0;
            //Устанавливаем счётчик символов в 0
            int coun = 0;
            int sum = 0;
            for (int i = 0; i < len; i++)
            {
                if (str[i] == '1' || str[i] == '2' || str[i] == '3' || str[i] == '4' || str[i] == '5' || str[i] == '6' || str[i] == '7' || str[i] == '8' || str[i] == '9')
                    count++;
            }

            sum = count - coun;
            MessageBox.Show(sum.ToString(), "Ответ");
            //файлы находятся в папке bin/debug данного проекта
            StreamWriter sw = new StreamWriter("out.txt");
            //запись в файл
            sw.Write("Количество цифр = " + sum.ToString());
            sw.WriteLine();
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("in.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
            }
            sr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

