using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            dataGridView1.RowCount = 5;
            //Указываем количество строк         
            dataGridView1.ColumnCount = 5;
            //Указываем количество столбцов             
            int[,] a = new int[5, 5];
            //Инициализируем массив             
            int i, j;
            //Заполняем матрицу случайными числами             
            Random rand = new Random();
            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                    a[i, j] = rand.Next(-100, 100);
            //Выводим матрицу в dataGridView1             
            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
            //производим поиск максимального элемента на дополнительной диагонали             
            int m = int.MinValue;
            for (i = 0; i < 5; i++)
                if (a[i, 4 - i] > m) m = a[i, 4 - i];
            // выводим результат             
            textBox1.Text = Convert.ToString(m);
        }

    }
}
 
