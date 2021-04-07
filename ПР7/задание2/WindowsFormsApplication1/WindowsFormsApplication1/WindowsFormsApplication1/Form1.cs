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
            listBox1.Items.Add(textBox1.Text);
        }
       
        private void button2_Click_1(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            //считываем строку в переменную str
            string str = (string)listBox1.Items[index];
            //узнаем количество символов в строке 
            var result = str.Select(x => x == 'j' ? 'i' : (x == 'i' ? 'j' : x)).ToArray();
            str = new String(result);
            label2.Text = str;
        }
    }
}