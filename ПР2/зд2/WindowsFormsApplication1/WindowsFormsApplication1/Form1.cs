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
            double x, y, z, f;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            z = Convert.ToDouble(textBox3.Text);

            f = (Math.Max(y, z) / Math.Min(x, y) + 5);

            listBox1.Items.Add("При x=" + x);
            listBox1.Items.Add("   y=" + y);
            listBox1.Items.Add("   z=" + z);
            listBox1.Items.Add("   f=" + f);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        }

       
        }
    

