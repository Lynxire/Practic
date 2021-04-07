using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double[] Mas = new double[25];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox1.Text = "";
            for (int i = 0; i < 25; i++)
            {
                Mas[i] = Math.Round(rand.NextDouble()*50-20,3);
                textBox1.Text += "Mas[" + Convert.ToString(i) + "] = "
                + Convert.ToString(Mas[i]) + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            double h = 0;
            for (int i = 0; i < 25; i++)
            {

                {

                    if (Mas[i] < 0) h+= Mas[i];
                    if (Mas[i] > 1 && Mas[i] < 2) h += 1;
                    else { Mas[i] = Mas[i]; }
                    textBox2.Text += "Mas[" + Convert.ToString(i) + "] = "
               + Convert.ToString(Mas[i]) + Environment.NewLine;
                }
            }
            MessageBox.Show(Convert.ToString(h),"summa");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}