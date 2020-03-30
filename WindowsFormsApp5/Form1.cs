using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            float true_wynik = 1000000 / 3;

            double n = int.Parse(k_box.Text);
            n = Math.Pow(10, n);
            List<int> wartosci = new List<int>();

            
            Random rnd = new Random();
            int d = 10;
            int l = 100000;
            double f = 0.0F;
            int o = 0;
            WindowsFormsApp.SingleCount single = new SingleCount();
            single.X1 = 0;
            single.X2 = 100;
            double f2 = 0.0F;
            for (int j = -10; j < 10; j++)
            {
                for (int j2 =-10; j2 < 10;j2++) {
                    single.X1 = j;
                    single.X2 = j2;
                    f = 0.0F;
                    f2 = 0.0F;
                    int licz = 0;
                    double old_i = 0;

                    for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                    {

                        licz += 1;
                        f += (i * i) * (i - old_i);

                        old_i = i;
                    };
                    for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                    {

                        licz += 1;
                        f2 += (i * i * i) * (i - old_i);

                        old_i = i;
                    };

                    if (f == f2) 
                    {
                        string wynik = " prostokaty   x1 = " + single.X1.ToString()+ " x2 = "+ single.X2.ToString();
                        wynik_box.Text += wynik;
                    }

                    f = 0.0F;
                    f2 = 0.0F;
                    old_i = 0;
                    for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                    {

                        licz += 1;
                        f += (((i * i) + (old_i * old_i)) / 2) * (i - old_i);

                        old_i = i;
                    };
                    for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                    {

                        licz += 1;
                        f2 += (((i * i* i) + (old_i * old_i * old_i)) / 2) * (i - old_i);

                        old_i = i;
                    };
                    if (Math.Floor(f) == Math.Floor(f2))
                    {
                        string wynik = " trapezy   x1 = " + single.X1.ToString() + " x2 = " + single.X2.ToString();
                        wynik_box.Text += wynik;
                    }
                };
            };
        }

    }
}
