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
        private void button1_Click(object sender, EventArgs e)
        {

            DateTime dnes = DateTime.Now;
            DateTime stodni = dnes.AddDays(100);
            MessageBox.Show("Dnes je: " + dnes.ToString());
            MessageBox.Show("Datum za 100 dni: " + stodni);

        }
    }
}
