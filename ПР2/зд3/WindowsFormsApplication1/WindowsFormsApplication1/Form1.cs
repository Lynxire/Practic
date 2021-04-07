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
            Int32 n; String k;
            n = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();
            switch (n)
            {
                case 0: k = "ночь"; listBox1.Items.Add(k); break;
                case 1: k = "ночь"; listBox1.Items.Add(k); break;
                case 2: k = "ночь"; listBox1.Items.Add(k); break;
                case 3: k = "ночь"; listBox1.Items.Add(k); break;
                case 4: k = "ночь"; listBox1.Items.Add(k); break;
                case 5: k = "утро"; listBox1.Items.Add(k); break;
                case 6: k = "утро"; listBox1.Items.Add(k); break;
                case 7: k = "утро"; listBox1.Items.Add(k); break;
                case 8: k = "утро"; listBox1.Items.Add(k); break;
                case 9: k = "утро"; listBox1.Items.Add(k); break;
                case 10: k = "утро"; listBox1.Items.Add(k); break;
                case 11: k = "утро"; listBox1.Items.Add(k); break;
                case 12: k = "день"; listBox1.Items.Add(k); break;
                case 13: k = "день"; listBox1.Items.Add(k); break;
                case 14: k = "день"; listBox1.Items.Add(k); break;
                case 15: k = "день"; listBox1.Items.Add(k); break;
                case 16: k = "день"; listBox1.Items.Add(k); break;
                case 17: k = "день"; listBox1.Items.Add(k); break;
                case 18: k = "вечер"; listBox1.Items.Add(k); break;
                case 19: k = "вечер"; listBox1.Items.Add(k); break;
                case 20: k = "вечер"; listBox1.Items.Add(k); break;
                case 21: k = "вечер"; listBox1.Items.Add(k); break;
                case 22: k = "вечер"; listBox1.Items.Add(k); break;
                case 23: k = "вечер"; listBox1.Items.Add(k); break;



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        
        }
    }

