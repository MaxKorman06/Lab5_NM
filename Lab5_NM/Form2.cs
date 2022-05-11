using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_NM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void show_answer(double[] x, double[] y, double X)
        {
            double[,] mas = new double[5, 6];
            double c, q, h, rez = 1;

            h = Math.Round(x[1] - x[0], 1);
            for (int i = 0; i < 5; i++)
            {
                mas[i, 0] = x[i];
                mas[i, 1] = y[i];
            }
            for (int i = 2; i < 6; i++)
            {
                for (int j = 5-i; j >= 0; j--)
                {
                    mas[j, i] = Math.Round(mas[j + 1, i - 1] - mas[j, i - 1], 2);
                }
            }
            
            textBox_fin.Text += " x/ty/tΔy1/tΔy2/tΔy3/tΔy4" + Environment.NewLine;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    textBox_fin.Text += mas[i, j] + "/t";
                }
                textBox_fin.Text += Environment.NewLine;
            }

            q = (X - x[x.Length - 1] / h);
            c = mas[4, 1];

            int ii = 3, jj = 2;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    rez *= q + i;
                }
                c += (rez * mas[ii, jj] / Factorial(i + 1));
                ii--;
                jj++;
                rez = 1;
            }

            textBox_fin.Text += Environment.NewLine + "Результат при прямому ході С=" + c + Environment.NewLine;
            q = (X - x[0]) / h;
            c = mas[0, 1];
            ii = 0;
            jj = 2;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    rez *= q - j;
                }
                c += (rez * mas[ii, jj]) / Factorial(i + 1);
                jj++;
                rez = 1;
            }
            textBox_fin.Text += "Результат при зворотньому ході С=" + c + Environment.NewLine;
        }

        private double Factorial(double num)
        {
            int fact = 1;
            for (int x = 1; x <= num; x++)
            {
                fact *= x;
            }
            return fact;
        }

        private void button_swap_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
        }

        private void button_clear_Click_1(object sender, EventArgs e)
        {
            textBox_LX0.Clear();
            textBox_LX1.Clear();
            textBox_LX2.Clear();
            textBox_LX3.Clear();
            textBox_LX4.Clear();
            textBox_LY0.Clear();
            textBox_LY1.Clear();
            textBox_LY2.Clear();
            textBox_LY3.Clear();
            textBox_LY4.Clear();

            textBox_fin.Clear();
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            double[] x = new double[5];
            double[] y = new double[5];

            double X;

            x[0] = Convert.ToDouble(textBox_LX0.Text);
            x[1] = Convert.ToDouble(textBox_LX1.Text);
            x[2] = Convert.ToDouble(textBox_LX2.Text);
            x[3] = Convert.ToDouble(textBox_LX3.Text);
            x[4] = Convert.ToDouble(textBox_LX4.Text);

            y[0] = Convert.ToDouble(textBox_LY0.Text);
            y[1] = Convert.ToDouble(textBox_LY1.Text);
            y[2] = Convert.ToDouble(textBox_LY2.Text);
            y[3] = Convert.ToDouble(textBox_LY3.Text);
            y[4] = Convert.ToDouble(textBox_LY4.Text);

            X = Convert.ToDouble(textBox_X.Text);

            textBox_fin.Text += "Інтерполяція" + Environment.NewLine;

            show_answer(x, y, X);
        }
    }
}
