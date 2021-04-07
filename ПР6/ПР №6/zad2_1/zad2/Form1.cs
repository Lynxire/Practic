using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad2
{
    public partial class Form1 : Form
    {
        int[] Mas = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox1.Text = "";
            for (int i = 0; i < 10; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                textBox1.Text += "Mas[" + Convert.ToString(i) + "] = "
                + Convert.ToString(Mas[i]) + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int proiz = 1;
            int minelem = 0;
            int mini = 0;
            textBox2.Text = "";
            for (int i = 0; i < 9; i++)
            {
                if (mini > Mas[i])
                {
                    mini = Mas[i];
                    minelem = i;
                }
                textBox2.Text += "Mas[" + Convert.ToString(i) + "] = "
                + Convert.ToString(Mas[i]) + Environment.NewLine;
            }
            for (int p = 0; p < minelem; p++)
            {
                proiz = proiz * Mas[p];
            }
            textBox2.Text += "Минимальный: " + mini + ".\n";
            textBox2.Text += "Произведение до минимального: " + proiz + ".";
        }
    }
}
