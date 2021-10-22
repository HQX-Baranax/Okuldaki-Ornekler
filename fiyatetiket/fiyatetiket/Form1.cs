using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fiyatetiket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double etiketfiyati, indirimlifiyat;

        private void yüzde25btn_Click(object sender, EventArgs e)
        {
            etiketfiyati = Convert.ToDouble(etikettxt.Text);
            indirimlifiyat = etiketfiyati - etiketfiyati * .25;
            fiyatlbl.Text = indirimlifiyat.ToString();
        }

        private void yüzde50btn_Click(object sender, EventArgs e)
        {
            etiketfiyati = Convert.ToDouble(etikettxt.Text);
            indirimlifiyat = etiketfiyati - etiketfiyati * .50;
            fiyatlbl.Text = indirimlifiyat.ToString();
        }

        private void yüzde75btn_Click(object sender, EventArgs e)
        {
            etiketfiyati = Convert.ToDouble(etikettxt.Text);
            indirimlifiyat = etiketfiyati - etiketfiyati * .75;
            fiyatlbl.Text = indirimlifiyat.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fiyatlbl.ResetText();
        }

        private void yüzde10btn_Click(object sender, EventArgs e)
        {
            etiketfiyati = Convert.ToDouble(etikettxt.Text);
            indirimlifiyat = etiketfiyati - etiketfiyati * .10;
            fiyatlbl.Text = indirimlifiyat.ToString();
        }
    }
}
