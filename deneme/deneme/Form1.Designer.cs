namespace deneme
{
    partial class GirisForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.girisbutton = new System.Windows.Forms.Button();
            this.isimtextbox = new System.Windows.Forms.TextBox();
            this.sifretextbox = new System.Windows.Forms.TextBox();
            this.Kullanıcıadılabael = new System.Windows.Forms.Label();
            this.Sifrelabel = new System.Windows.Forms.Label();
            this.cıkısbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // girisbutton
            // 
            this.girisbutton.BackColor = System.Drawing.Color.GreenYellow;
            this.girisbutton.FlatAppearance.BorderSize = 0;
            this.girisbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisbutton.Location = new System.Drawing.Point(30, 157);
            this.girisbutton.Name = "girisbutton";
            this.girisbutton.Size = new System.Drawing.Size(100, 34);
            this.girisbutton.TabIndex = 1;
            this.girisbutton.Text = "Giriş Yap";
            this.girisbutton.UseVisualStyleBackColor = false;
            this.girisbutton.Click += new System.EventHandler(this.girisbutton_Click);
            // 
            // isimtextbox
            // 
            this.isimtextbox.BackColor = System.Drawing.SystemColors.Window;
            this.isimtextbox.Location = new System.Drawing.Point(30, 65);
            this.isimtextbox.Name = "isimtextbox";
            this.isimtextbox.Size = new System.Drawing.Size(100, 20);
            this.isimtextbox.TabIndex = 2;
            // 
            // sifretextbox
            // 
            this.sifretextbox.Location = new System.Drawing.Point(30, 108);
            this.sifretextbox.Name = "sifretextbox";
            this.sifretextbox.PasswordChar = '*';
            this.sifretextbox.Size = new System.Drawing.Size(100, 20);
            this.sifretextbox.TabIndex = 3;
            this.sifretextbox.Tag = "";
            // 
            // Kullanıcıadılabael
            // 
            this.Kullanıcıadılabael.AutoSize = true;
            this.Kullanıcıadılabael.Location = new System.Drawing.Point(27, 49);
            this.Kullanıcıadılabael.Name = "Kullanıcıadılabael";
            this.Kullanıcıadılabael.Size = new System.Drawing.Size(64, 13);
            this.Kullanıcıadılabael.TabIndex = 4;
            this.Kullanıcıadılabael.Text = "Kullanıcı Adı";
            // 
            // Sifrelabel
            // 
            this.Sifrelabel.AutoSize = true;
            this.Sifrelabel.Location = new System.Drawing.Point(30, 92);
            this.Sifrelabel.Name = "Sifrelabel";
            this.Sifrelabel.Size = new System.Drawing.Size(28, 13);
            this.Sifrelabel.TabIndex = 5;
            this.Sifrelabel.Text = "Şifre";
            // 
            // cıkısbutton
            // 
            this.cıkısbutton.BackColor = System.Drawing.Color.Red;
            this.cıkısbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cıkısbutton.FlatAppearance.BorderSize = 0;
            this.cıkısbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cıkısbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cıkısbutton.Location = new System.Drawing.Point(30, 204);
            this.cıkısbutton.Name = "cıkısbutton";
            this.cıkısbutton.Size = new System.Drawing.Size(97, 36);
            this.cıkısbutton.TabIndex = 6;
            this.cıkısbutton.Text = "Çıkış";
            this.cıkısbutton.UseVisualStyleBackColor = false;
            this.cıkısbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::deneme.Properties.Resources.remove_button;
            this.pictureBox1.Location = new System.Drawing.Point(114, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(160, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cıkısbutton);
            this.Controls.Add(this.Sifrelabel);
            this.Controls.Add(this.Kullanıcıadılabael);
            this.Controls.Add(this.sifretextbox);
            this.Controls.Add(this.isimtextbox);
            this.Controls.Add(this.girisbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.GirisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button girisbutton;
        private System.Windows.Forms.TextBox isimtextbox;
        private System.Windows.Forms.TextBox sifretextbox;
        private System.Windows.Forms.Label Kullanıcıadılabael;
        private System.Windows.Forms.Label Sifrelabel;
        private System.Windows.Forms.Button cıkısbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

