using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prackt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 15;
            dataGridView1.ColumnCount = 15;
            int[,] a = new int[15, 15];
            int[][] mass = new int[5][];
            mass[0] = new int[1];
            mass[1] = new int[2];
            mass[2] = new int[3];
            mass[3] = new int[4];
            mass[4] = new int[5];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < 15; i++)
                for (j = 0; j < 15; j++)
                    a[i, j] = rand.Next(-100, 100);
            for (i = 0; i < 15; i++)
                for (j = 0; j < 15; j++)
                 dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
            int min = 0;
            textBox1.Text = "";
            for (i = 0; i < 15; i++)
            {

                for (j = 0; j < 15; j++)
                    if (a[i, j] > min) min = a[i,j];
                {
                    textBox1.Text = min.ToString();
                }
            }
            
               // textBox1.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(min) + Environment.NewLine;
                //
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
