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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            double[] x = new double[10];
            double[] y = new double[10];

            double a = 0, b = 0, c = 0;

            x[0] = Convert.ToDouble(textBox_NX0.Text);
            x[1] = Convert.ToDouble(textBox_NX1.Text);
            x[2] = Convert.ToDouble(textBox_NX2.Text);
            x[3] = Convert.ToDouble(textBox_NX3.Text);
            x[4] = Convert.ToDouble(textBox_NX4.Text);
            x[5] = Convert.ToDouble(textBox_NX5.Text);
            x[6] = Convert.ToDouble(textBox_NX6.Text);
            x[7] = Convert.ToDouble(textBox_NX7.Text);
            x[8] = Convert.ToDouble(textBox_NX8.Text);
            x[9] = Convert.ToDouble(textBox_NX9.Text);

            y[0] = Convert.ToDouble(textBox_NY0.Text);
            y[1] = Convert.ToDouble(textBox_NY1.Text);
            y[2] = Convert.ToDouble(textBox_NY2.Text);
            y[3] = Convert.ToDouble(textBox_NY3.Text);
            y[4] = Convert.ToDouble(textBox_NY4.Text);
            y[5] = Convert.ToDouble(textBox_NY5.Text);
            y[6] = Convert.ToDouble(textBox_NY6.Text);
            y[7] = Convert.ToDouble(textBox_NY7.Text);
            y[8] = Convert.ToDouble(textBox_NY8.Text);
            y[9] = Convert.ToDouble(textBox_NY9.Text);

            kv_ap(x, y, ref a, ref b, ref c);
            line_ap(x, y, ref a, ref b);

        }

        private void kramer(double[,] a, double[] b, ref double A, ref double B, ref double C)
        {
            double delta, delta1, delta2, delta3;

            delta = a[0, 0] * a[1, 1] * a[2, 2] + a[0, 1] * a[1, 2] * a[2, 0] + a[0, 2] * a[1, 0] * a[2, 1] - a[0, 2] * a[1, 1] * a[2, 0] - a[0, 0] * a[1, 2] * a[2, 1] - a[0, 1] * a[1, 0] * a[2, 2];

            delta1 = b[0] * a[1, 1] * a[2, 2] + a[0, 1] * a[1, 2] * b[2] + a[0, 2] * b[1] * a[2, 1] - a[0, 2] * a[1, 1] * b[2] - b[0] * a[1, 2] * a[2, 1] - a[0, 1] * b[1] * a[2, 2];

            delta2 = a[0, 0] * b[1] * a[2, 2] + b[0] * a[1, 2] * a[2, 0] + a[0, 2] * a[1, 0] * b[2] - a[0, 2] * b[1] * a[2, 0] - a[0, 0] * a[1, 2] * b[2] - b[0] * a[1, 0] * a[2, 2];

            delta3 = a[0, 0] * a[1, 1] * b[2] + a[0, 1] * b[1] * a[2, 0] + b[0] * a[1, 0] * a[2, 1] - b[0] * a[1, 1] * a[2, 0] - a[0, 0] * b[1] * a[2, 1] - a[0, 1] * a[1, 0] * b[2];

            if (delta != 0)
            {
                A = delta1 / delta;
                B = delta2 / delta;
                C = delta3 / delta;
            }
            else
            {
                textBox_fin2.Text = "Розвязку не існує";
            }
        }

        private void kv_ap(double[] x, double[] y, ref double a, ref double b, ref double c) 
        {
            double x4 = 0, x3 = 0, x2 = 0, x1 = 0, n = 10, x2y = 0, xy = 0, yi = 0;

            double[,] mas_a = new double[3, 3];
            double[] mas_b = new double[3];

            for (int i = 0; i < x.Length; i++)
            {
                x4 += Math.Pow(x[i], 4);
                x3 += Math.Pow(x[i], 3);
                x2 += Math.Pow(x[i], 2);
                x1 += x[i];

                x2y += Math.Pow(x[i], 2) * y[i];
                xy += x[i] * y[i];
                yi += y[i];
            }

            mas_a[0, 0] = x4;
            mas_a[0, 1] = x3;
            mas_a[0, 2] = x2;

            mas_a[1, 0] = x4;
            mas_a[1, 1] = x4;
            mas_a[1, 2] = x4;

            mas_a[2, 0] = x2;
            mas_a[2, 1] = x1;
            mas_a[2, 2] = n;

            mas_b[0] = x2y;
            mas_b[1] = xy;
            mas_b[2] = yi;

            textBox_fin2.Text += "система рівнянь:" + Environment.NewLine;
            textBox_fin2.Text += x4 + "*a + (" + x3 + ")*b + (" + x2 + ")c = " + x2y + Environment.NewLine;
            textBox_fin2.Text += x3 + "*a + (" + x2 + ")*b + (" + x1 + ")c = " + xy + Environment.NewLine;
            textBox_fin2.Text += x2 + "*a + (" + x1 + ")*b + (" + n + ")c = " + yi + Environment.NewLine;

            kramer(mas_a, mas_b, ref a, ref b, ref c);

            textBox_fin2.Text += Environment.NewLine + "Розвявши систему рівнянь методом Крамера, ми отримуємо наступне:" + Environment.NewLine;
            textBox_fin2.Text += "a=" + a + Environment.NewLine;
            textBox_fin2.Text += "b=" + b + Environment.NewLine;
            textBox_fin2.Text += "c=" + c + Environment.NewLine;

            textBox_fin2.Text += "Отримуємо наступне рівняння" + Environment.NewLine + " y=" + a + "*x^2 +(" + b + ")*x +(" + c + ")";

            double[] yh = new double[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                yh[i] = a + Math.Pow(x[i], 2) + b * x[i] + c;
                chart1.Series[1].Points.AddXY(x[i], yh[i]);
            }
        }

        public void line_ap(double[] x, double[] y, ref double a, ref double b)
        {
            double X = 0, Y = 0, X2 = 0, XY = 0, n = 10;

            for (int i = 0; i < x.Length; i++)
            {
                X += x[i];
                Y += y[i];

                X2 += Math.Pow(x[i], 2);
                XY += x[i] * y[i];
            }

            textBox_fin1.Text += "Сумма x=" + X + Environment.NewLine;
            textBox_fin1.Text += "Сумма y=" + Y + Environment.NewLine;
            textBox_fin1.Text += "Сумма x^2=" + X2 + Environment.NewLine;
            textBox_fin1.Text += "Сумма x*y=" + XY + Environment.NewLine;
            textBox_fin1.Text += "n=" + n + Environment.NewLine;

            textBox_fin1.Text += "Система рівнянь:" + Environment.NewLine;
            textBox_fin1.Text += X2 + "*a + (" + X + ")*b = " + XY + Environment.NewLine;
            textBox_fin1.Text += X + "*a + (" + n + ")*b = " + Y + Environment.NewLine;

            b = (Y * X2 - X * XY) / (n * X2 - X * X);
            a = (XY - X * b) / X2;

            textBox_fin1.Text += "Розвязавши систему, отримуємо:" + Environment.NewLine;
            textBox_fin1.Text += "a=" + a + Environment.NewLine;
            textBox_fin1.Text += "b=" + b + Environment.NewLine + Environment.NewLine;

            textBox_fin1.Text += "Отримуємо наступне рівняння" + Environment.NewLine + " y=" + a + "*k + (" + b + ")";

            double[] yh = new double[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                yh[i] = a * x[i] + b;
                chart1.Series[0].Points.AddXY(x[i], yh[i]);
            }
        }

    private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                chart1.Series[i].Points.Clear();
            }
            textBox_NX0.Clear();
            textBox_NX1.Clear();
            textBox_NX2.Clear();
            textBox_NX3.Clear();
            textBox_NX4.Clear();
            textBox_NX5.Clear();
            textBox_NX6.Clear();
            textBox_NX7.Clear();
            textBox_NX8.Clear();
            textBox_NX9.Clear();

            textBox_NY0.Clear();
            textBox_NY1.Clear();
            textBox_NY2.Clear();
            textBox_NY3.Clear();
            textBox_NY4.Clear();
            textBox_NY5.Clear();
            textBox_NY6.Clear();
            textBox_NY7.Clear();
            textBox_NY8.Clear();
            textBox_NY9.Clear();
        }
    }
}
