using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad2_2
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
            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
                }

            dataGridView2.RowCount = 5;
            //Указываем количество строк
            dataGridView2.ColumnCount = 5;
            //Указываем количество столбцов
           
            //Заполняем матрицу случайными числами
            
           
             for (j = 0; j < 5; j++)
             {
                 for (i = 0; i < 5; i++)
                 {
                     if (a[i, j] < 0)
                     {
                         a[i, j] = 0;
                     }
                     if (a[i, j] != 0)
                     {
                         int nenol = 0;
                         nenol = a[i, j];
                         int[][] ar1 = new int[5][];
                         ar1[0] = new int[1] {nenol};
                         ar1[1] = new int[1] {nenol};
                         ar1[2] = new int[1] { nenol };
                         ar1[3] = new int[1] { nenol };
                         ar1[4] = new int[1] { nenol };
                             textBox1.Text += Convert.ToString(nenol + ".\n");
                         int indx = 0;
                         indx = j;

                             int[][] ar2 = new int[5][];
                             ar2[0] = new int[1] { indx };
                             ar2[1] = new int[1] { indx };
                             ar2[2] = new int[1] { indx };
                             ar2[3] = new int[1] { indx };
                             ar2[4] = new int[1] { indx };
                             textBox2.Text += Convert.ToString(indx + ".\n");
                     }
                 }
             }
            //Выводим матрицу в dataGridView1
           
                
                   
                        
                
            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                {
                    if (a[i, j] != (i + j)) 
                    dataGridView2.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
                }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
