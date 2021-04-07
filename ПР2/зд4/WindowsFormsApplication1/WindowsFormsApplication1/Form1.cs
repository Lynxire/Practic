using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            double a, b, x,n,y;
            a = Convert.ToDouble(textBox2.Text);
            b = Convert.ToDouble(textBox4.Text);
            n = Convert.ToDouble(textBox1.Text);
            x = -4;
            while (x >= n)
            {
                y = x + Math.Sqrt(Math.Abs(x * x * x + a - Math.Pow(b, x)));
                listBox1.Items.Add("x=" + x + " y=" + y);
                x += -0.2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
        }
    

