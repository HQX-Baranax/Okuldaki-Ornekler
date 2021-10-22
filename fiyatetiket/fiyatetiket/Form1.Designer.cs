namespace fiyatetiket
{
    partial class Form1
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
            this.yüzde10btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.etikettxt = new System.Windows.Forms.TextBox();
            this.yüzde25btn = new System.Windows.Forms.Button();
            this.yüzde50btn = new System.Windows.Forms.Button();
            this.yüzde75btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fiyatlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yüzde10btn
            // 
            this.yüzde10btn.Location = new System.Drawing.Point(16, 120);
            this.yüzde10btn.Name = "yüzde10btn";
            this.yüzde10btn.Size = new System.Drawing.Size(75, 75);
            this.yüzde10btn.TabIndex = 0;
            this.yüzde10btn.Text = "%10 indirim ";
            this.yüzde10btn.UseVisualStyleBackColor = true;
            this.yüzde10btn.Click += new System.EventHandler(this.yüzde10btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Etiket Fiyatı:";
            // 
            // etikettxt
            // 
            this.etikettxt.Location = new System.Drawing.Point(166, 53);
            this.etikettxt.Name = "etikettxt";
            this.etikettxt.Size = new System.Drawing.Size(100, 20);
            this.etikettxt.TabIndex = 2;
            // 
            // yüzde25btn
            // 
            this.yüzde25btn.Location = new System.Drawing.Point(118, 120);
            this.yüzde25btn.Name = "yüzde25btn";
            this.yüzde25btn.Size = new System.Drawing.Size(75, 75);
            this.yüzde25btn.TabIndex = 3;
            this.yüzde25btn.Text = "%25 indirim ";
            this.yüzde25btn.UseVisualStyleBackColor = true;
            this.yüzde25btn.Click += new System.EventHandler(this.yüzde25btn_Click);
            // 
            // yüzde50btn
            // 
            this.yüzde50btn.Location = new System.Drawing.Point(221, 120);
            this.yüzde50btn.Name = "yüzde50btn";
            this.yüzde50btn.Size = new System.Drawing.Size(75, 75);
            this.yüzde50btn.TabIndex = 4;
            this.yüzde50btn.Text = "%50 indirim ";
            this.yüzde50btn.UseVisualStyleBackColor = true;
            this.yüzde50btn.Click += new System.EventHandler(this.yüzde50btn_Click);
            // 
            // yüzde75btn
            // 
            this.yüzde75btn.Location = new System.Drawing.Point(323, 120);
            this.yüzde75btn.Name = "yüzde75btn";
            this.yüzde75btn.Size = new System.Drawing.Size(75, 75);
            this.yüzde75btn.TabIndex = 5;
            this.yüzde75btn.Text = "%75 indirim ";
            this.yüzde75btn.UseVisualStyleBackColor = true;
            this.yüzde75btn.Click += new System.EventHandler(this.yüzde75btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(114, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "İndirimli Fiyatı:";
            // 
            // fiyatlbl
            // 
            this.fiyatlbl.AutoSize = true;
            this.fiyatlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyatlbl.Location = new System.Drawing.Point(262, 261);
            this.fiyatlbl.Name = "fiyatlbl";
            this.fiyatlbl.Size = new System.Drawing.Size(24, 26);
            this.fiyatlbl.TabIndex = 7;
            this.fiyatlbl.Text = "  ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 59);
            this.button1.TabIndex = 8;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(480, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fiyatlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yüzde75btn);
            this.Controls.Add(this.yüzde50btn);
            this.Controls.Add(this.yüzde25btn);
            this.Controls.Add(this.etikettxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yüzde10btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yüzde10btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox etikettxt;
        private System.Windows.Forms.Button yüzde25btn;
        private System.Windows.Forms.Button yüzde50btn;
        private System.Windows.Forms.Button yüzde75btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fiyatlbl;
        private System.Windows.Forms.Button button1;
    }
}

