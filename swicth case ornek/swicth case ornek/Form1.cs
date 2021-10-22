using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swicth_case_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Tema
            


            //meslek seçimi ile ilgili işte
            guna2ComboBox2.Items.Add("Yazilimci");
            guna2ComboBox2.Items.Add("Doktor");
            guna2ComboBox2.Items.Add("Aşçı");
            guna2ComboBox2.Items.Add("Polis");
            guna2ComboBox2.Items.Add("Tezgahtar");

            //Track Bar Labela Yazma (Form Başladığında)
            label3.Text = guna2TrackBar1.Value.ToString();

            //Renk Seçimi
            guna2ComboBox1.Items.Add("Kırmızı");
            guna2ComboBox1.Items.Add("Sarı");
            guna2ComboBox1.Items.Add("Yeşil");
            guna2ComboBox1.Items.Add("Mor");
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (guna2ComboBox1.Text)
            {
                case "Kırmızı": label1.ForeColor = Color.Red; break;
                case "Sarı": label1.ForeColor = Color.Yellow; break;
                case "Yeşil": label1.ForeColor = Color.Green; break;
                case "Mor": label1.ForeColor = Color.Purple; break;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Empty;
            guna2ComboBox1.ResetText();
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label3.Text = guna2TrackBar1.Value.ToString();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //Doktor:6k Aşçı:5k Polis:5.8k Tezgahtar:4.5k
            //Çocuk Başına:30TL

            int maas = 0;
            int cocuksayisi = Convert.ToInt32(guna2NumericUpDown1.Value);

            switch (guna2ComboBox2.Text)
            {
                case "Yazilimci": maas = 7500 + cocuksayisi * 30; break; 
                case "Doktor": maas = 6000 + cocuksayisi * 30; break;
                case "Aşçı": maas = 5000 + cocuksayisi * 30; break;
                case "Polis": maas = 5800 + cocuksayisi * 30; break;
                case "Tezgahtar": maas = 4500 + cocuksayisi * 30; break;

            }
            MessageBox.Show("Merhaba " + guna2TextBox1.Text + "\nMesleğiniz: " + guna2ComboBox2.Text + "\nÇocuk Sayısı: "
                + guna2NumericUpDown1.Value + "\nMaaşınız: " + maas);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "";
            guna2NumericUpDown1.Value = 0;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            double kalan, bolum;
            double a = Convert.ToInt16(guna2TextBox2.Text);
            double b = Convert.ToInt16(guna2TextBox3.Text);
            bolum = a / b;
            kalan = a % b;
            listBox1.Items.Add(bolum.ToString());
            listBox2.Items.Add(kalan.ToString());
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            guna2TextBox2.ResetText();
            guna2TextBox3.ResetText();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.BackColor == Color.DimGray)
            {
                this.BackColor = Color.Silver;
            }
            else if (this.BackColor == Color.Silver)
            {
                this.BackColor = Color.DimGray;
            }
        }
    }
}
