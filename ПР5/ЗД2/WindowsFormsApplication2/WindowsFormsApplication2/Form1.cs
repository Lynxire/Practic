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
             int s;
            int rass; 
            double percent; 
            double profit;
            try
            {
                s = Convert.ToInt32(textBox1.Text);
                rass = Convert.ToInt16(textBox2.Text);
                if ((s>10000)|(s<100))
                {
                    throw new IndexOutOfRangeException("Ошибка, платеж не может быть меньше 100 рублей или отрицательным и большим чем 10000.");
                }
                if ((rass < 1)|(rass>3))
                {
                    throw new IndexOutOfRangeException("Ошибка, проценты не могут быть меньше 1 или отрицательным и большим чем 3.");
                }
                if (rass == 1) percent = 1;
                else if (rass == 2) percent = 2;
                else percent = 3;
                profit = s * percent  ;
                label3.Text = "Цена - "+s + " %: " + rass.ToString()+" руб."
                    + "\n" + "Сумма: " + profit.ToString();
            }
            catch (IndexOutOfRangeException ex ) 
            { 
                MessageBox.Show(ex.Message, "Платеж", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            catch (FormatException ) 
            { 
                if ((textBox1.Text.Length == 0) || (textBox2.Text.Length == 0))              
                    MessageBox.Show("Оба поля должны быть заполнены.", 
                        "Платеж", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                else MessageBox.Show("Ошибка в исходных данных." + 
                    " В поле платеж и проценты надо ввести целое число.",
                    "Платеж", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        }
    }
