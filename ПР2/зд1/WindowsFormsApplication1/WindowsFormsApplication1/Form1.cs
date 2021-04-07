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
             double x, y, z, b;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            z = Convert.ToDouble(textBox3.Text);
            b = Math.Pow(y, Math.Pow(3,Math.Sqrt(Math.Abs(x)))) + (Math.Pow(3, (Math.Cos(y))) * (Math.Abs(x - y)) * ((1 + Math.Pow(2, (Math.Sin(z))) / Math.Sqrt(x + y)) / Math.Exp(Math.Abs(x - y)) + x / 2));
            listBox1.Items.Add("При x=" + x);
            listBox1.Items.Add("  y=" + y);
            listBox1.Items.Add("  z=" + z);
            listBox1.Items.Add("  b=" + b);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        }
    }

