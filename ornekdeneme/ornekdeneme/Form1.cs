using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornekdeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //fatura hesaplama sms adedi 1 dk 2 gb 10 tlden
            double fatura = Convert.ToInt32(smstxt.Text) * 1 + Convert.ToInt32(dktxt.Text) * 2 + Convert.ToInt32(gbtxt.Text) * 10;
            MessageBox.Show("Bu aylık Faturamız: " + fatura + " TL");
            //40-50 tl arası %10 - 50-60 tl arası %15 - 60 tl den büyükse %20
            if (fatura>=40 && fatura<=50)
            {
                MessageBox.Show("Faturanıza %10'luk indirim uygulanacaktır");
                fatura = fatura - fatura * 0.1;
                MessageBox.Show("Faturanızın İndirimli Fiyatı: " + fatura + "TL");
            }

            else if (fatura >= 50 && fatura <= 60)
            {
                MessageBox.Show("Faturanıza %15'luk indirim uygulanacaktır");
                fatura = fatura - fatura * 0.15;
                MessageBox.Show("Faturanızın İndirimli Fiyatı: " + fatura + "TL");
            }

            else if (fatura>60)
            {
                MessageBox.Show("Faturanıza %20'luk indirim uygulanacaktır");
                fatura = fatura - fatura * 0.2;
                MessageBox.Show("Faturanızın İndirimli Fiyatı: " + fatura + "TL");
            }
            else
            {
                MessageBox.Show("Faturanıza uygun indirim bulunamadı");
            }
        }
    }
}
