using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody04_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double  Mocnina(int zaklad, int exponent)
        {
            double vypocet = 1;
            bool exponentZaporny = exponent < 0;
            exponent = Math.Abs(exponent);

            while(exponent > 0)
            {
                vypocet *= zaklad;
                --exponent;
            }
            if (exponentZaporny) vypocet = 1 / vypocet;
            return vypocet;
        }
        private int Faktorial(int x)
        {
            int faktorial = 1;
            while (x > 0)
            {
                faktorial *= x;
                --x;
            }
            return faktorial;
        }
        private int CifLichSoucet(int a)
        {
            int cifra;
            int soucet = 0;
            while (a > 0)
            {
                cifra = a % 10;
                if (cifra % 2 != 0) soucet += cifra;
                a /= 10;
            }
            return soucet;
        }
        private static bool jePrvocislo(int y)
        {
            bool prvocislo = true;
            int pocetDelitelu = 0;
            for (int i = 2; i < y-1; i++)
            {
                if (y % i == 0) ++pocetDelitelu;
            }
            if (pocetDelitelu > 0) prvocislo = false;
            return prvocislo;
        }
        private int pocetSudDel(int a)
        {
            int pocet = 0;
            for (int i = 2; i <= a; i++)
            {
                if (a % i == 0) pocet++;
                ++i;
            }
            return pocet;
        }

        private void button_mocnina_Click(object sender, EventArgs e)
        {
            int zaklad = int.Parse(textBox_zaklad.Text);
            int exponent = int.Parse(textBox_exponent.Text);
            MessageBox.Show("Mocnina je " + Mocnina(zaklad, exponent));
        }

        private void button_faktorial_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox_faktorial.Text);
            MessageBox.Show("Faktorial je " + Faktorial(x));
        }

        private void button_cifLich_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox_cifra.Text);
            MessageBox.Show("Součet lichých cifer je " + CifLichSoucet(x));

        }

        private void button_prvocislo_Click(object sender, EventArgs e)
        {
            int y = int.Parse(textBox_prvocislo.Text);
            if (jePrvocislo(y)) MessageBox.Show("Zadané číslo je prvočíslo.");
            else MessageBox.Show("Zadané číslo není prvočíslo.");
        }

        private void button_pocetDel_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox_pocetDel.Text);
            if (pocetSudDel(a) > 0) MessageBox.Show("Počet sudých dělitelů je " + pocetSudDel(a));
            else MessageBox.Show("Žádne sudé dělitele.\n");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
