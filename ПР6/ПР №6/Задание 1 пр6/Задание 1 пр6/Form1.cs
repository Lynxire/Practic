using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1_пр6
{
    public partial class Form1 : Form
    {
        
 int[] Sum = new int[14]; //объявление массива
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
Random rand = new Random();
 textBox1.Text = "";
 for (int i = 0; i < 14; i++)
 {
 Sum[i] = rand.Next(-50, 50);
 textBox1.Text += "Sum[" + Convert.ToString(i) + "] = "
 + Convert.ToString(Sum[i]) + Environment.NewLine;

        }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        textBox2.Text = "";
        int S = 0;
 for (int i = 0; i < 14; i++)
 {


     if (Math.Abs(Sum[i])<(i+1)*(i+1))
         S += Sum[i];}
 textBox2.Text += "Сумма ="  + Convert.ToString(S) + Environment.NewLine;
        
        
    }
}
}
