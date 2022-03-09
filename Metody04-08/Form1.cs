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
           

        }
    }
}
