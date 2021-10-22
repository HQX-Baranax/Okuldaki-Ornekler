using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void girisbutton_Click(object sender, EventArgs e)
        {
            if (isimtextbox.Text == "admin" && sifretextbox.Text == "2104")
            {
                MessageBox.Show("Giriş Başarılı");
                MessageBox.Show("Hoş Geldin Admin");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }


            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı", "Hata");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
