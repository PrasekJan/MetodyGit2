using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodyGit2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private int Za100Dni()
        //{




        //}
        private int Metoda2_faktorial(int cislo) //Tato metoda udělá faktorial 
        {
            int fakt = 1;

            for (int i = 2; i <= cislo; ++i)
            {
                fakt *= i;
            }

            return fakt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Funguje-Pavelka
            DateTime dnes = DateTime.Now;
            DateTime stodni = dnes.AddDays(100);
            MessageBox.Show("Dnes je: " + dnes.ToString());
            MessageBox.Show("Datum za 100 dni: " + stodni);
            ///////////////////////////////////////////////
            ///
            int n = int.Parse(textBox1.Text);
            int vysledny_fakt;
            vysledny_fakt = Metoda2_faktorial(n);
            MessageBox.Show("Faktorial je " + vysledny_fakt);

            //Vše funguje - Prášek
        }
    }
}
