using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2_3
{
    class Matrix
    {         // элементы матрицы    
        double[,] a;
        // конструктор матрицы заданных размеров    
        public Matrix(int rows, int cols)
        { a = new double[rows, cols]; }
        // метод заполнения матрицы случайными числами   
        public void InputMatrix()
        {
            Random r = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = (double)r.Next(10);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------");
        }
        public override string ToString()
        {
            string s = null; for (int i = 0; i < a.GetLength(0); i++, s += "\n")
                for (int j = 0; j < a.GetLength(1); j++) s += a[i, j] + " ";
            return s;
        }

        public void show()
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------");
        }

        static public Matrix operator ++(Matrix m)
        {
            Matrix newM = new Matrix(m.a.GetLength(1), m.a.GetLength(0));
            double[,] arr = new double[m.a.GetLength(0), m.a.GetLength(0)];
            double[] massiv = new double[m.a.GetLength(1) * m.a.GetLength(1)];
            int e = 0;
            for (int i = 0; i < m.a.GetLength(0); i++)
            {
                for (int j = 0; j < m.a.GetLength(0); j++)
                {
                    massiv[e] = m.a[i, j];
                    e++;
                }
            }
            Array.Sort(massiv);
            e = 0;
            for (int i = 0; i < m.a.GetLength(0); i++)
            {
                for (int j = 0; j < m.a.GetLength(0); j++)
                {
                    newM.a[i, j] = massiv[e];
                    e++;
                }
            }
            return newM;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix x, z;
            x = new Matrix(4, 4);
            z = new Matrix(4, 4);
            x.InputMatrix();
            z = ++x;
            z.show();// траспонирование матрицы            
            Console.ReadKey();
        }
    }
}


