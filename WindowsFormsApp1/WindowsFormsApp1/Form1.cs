using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Создание объекта для генерации чисел
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = CalculateInteg().ToString();
            DrawFunc();
        }

        double CalculateInteg()
        {
            int n = Convert.ToInt32(textBox1.Text);
            double a = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);
           
            

            double S = 0;
            double h = (double)(b - a) / (double)n;

            for (int i = 0; i < n ; i++)
            {
                double x = rnd.NextDouble() * (b - a) + a;
                double y = f(x);
                S += y;             
            }

            return S * h;
        }

        void DrawFunc()
        {
            chart1.Series[0].Points.Clear();

            int n = Convert.ToInt32(textBox1.Text);
            double a = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);

            for (int i = 0; i < n; i++)
            {
                double x = ((double)i / (double)n) * (b - a) + a;
                double y = f(x);

                chart1.Series[0].Points.AddXY(x, y);
            }
        }

        double f(double x)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: return x;

                case 1: return x * x;

                case 2: return Math.Pow(Math.E, x);

                case 3: return Math.Sin(x);

                case 4: return Math.Cos(x);

                case 5: return Math.Tan(x);

                default: return 0;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
