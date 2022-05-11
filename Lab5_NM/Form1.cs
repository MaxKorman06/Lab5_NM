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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_clear_Click(object sender, EventArgs e)
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

        private void show_answer(double[] x, double[] y, double X)
        {
            double rez = 0;
            double rez_ch = 0;
            double rez_z = 0;

            textBox_fin.Text += "L(x) =";
            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < x.Length; j++)
                {
                    if (j != i) 
                    {
                        textBox_fin.Text += "(x-x)" + j + ")";
                    }
                }
                
                textBox_fin.Text += " / ";
                
                for (int j = 0; j < x.Length; j++)
                {
                    if (j != i)
                    {
                        textBox_fin.Text += "(x" + i + "-x" + j + ")";
                    }
                }
                if (i!=y.Length-1)
                {
                    textBox_fin.Text += "*y" + i + " + " + Environment.NewLine;
                }
                else
                {
                    textBox_fin.Text += "*y" + i + Environment.NewLine;
                }
            }

            textBox_fin.Text += Environment.NewLine + "L(" + X + ")=";
            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < x.Length; j++)
                {
                    if (j!=i)
                    {
                        textBox_fin.Text += "(" + X + "-" + x[j] + ")";
                        rez_ch *= X - x[j];
                    }
                }

                textBox_fin.Text += " / ";

                for (int j = 0; j < x.Length; j++)
                {
                    if (j != i)
                    {
                        textBox_fin.Text += "(" + x[i] + "-" + x[j] + ")";
                        rez_z *= x[i] - x[j];
                    }
                }
                if (i != y.Length - 1)
                {
                    textBox_fin.Text += "*" + y[i] + Environment.NewLine;
                    rez += (rez_ch / rez_z) * y[i];
                    rez_ch = 1;
                    rez_z = 1;
                }
                else
                {
                    rez += (rez_ch / rez_z) * y[i];
                    textBox_fin.Text += "*" + y[i] + Environment.NewLine + " = " + rez + Environment.NewLine;
                }
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_swap_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
        }
    }
}
