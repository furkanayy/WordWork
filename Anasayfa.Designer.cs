namespace YazılımYapımıProjeÖdevi
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.buttonOgren = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonIstatistik = new System.Windows.Forms.Button();
            this.buttonKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOgren
            // 
            this.buttonOgren.Image = ((System.Drawing.Image)(resources.GetObject("buttonOgren.Image")));
            this.buttonOgren.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOgren.Location = new System.Drawing.Point(91, 146);
            this.buttonOgren.Name = "buttonOgren";
            this.buttonOgren.Size = new System.Drawing.Size(154, 106);
            this.buttonOgren.TabIndex = 0;
            this.buttonOgren.Text = "ÖĞREN";
            this.buttonOgren.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOgren.UseVisualStyleBackColor = true;
            this.buttonOgren.Click += new System.EventHandler(this.ButtonOgren_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Image = ((System.Drawing.Image)(resources.GetObject("buttonTest.Image")));
            this.buttonTest.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTest.Location = new System.Drawing.Point(301, 146);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(154, 106);
            this.buttonTest.TabIndex = 2;
            this.buttonTest.Text = "TEST ETME";
            this.buttonTest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.ButtonTest_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(301, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 106);
            this.button2.TabIndex = 3;
            this.button2.Text = "KELİME EKLEME";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonKelimeEkle_Click);
            // 
            // buttonIstatistik
            // 
            this.buttonIstatistik.Image = ((System.Drawing.Image)(resources.GetObject("buttonIstatistik.Image")));
            this.buttonIstatistik.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonIstatistik.Location = new System.Drawing.Point(505, 146);
            this.buttonIstatistik.Name = "buttonIstatistik";
            this.buttonIstatistik.Size = new System.Drawing.Size(154, 106);
            this.buttonIstatistik.TabIndex = 4;
            this.buttonIstatistik.Text = "İSTATİSTİK";
            this.buttonIstatistik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonIstatistik.UseVisualStyleBackColor = true;
            this.buttonIstatistik.Click += new System.EventHandler(this.ButtonIstatistik_Click);
            // 
            // buttonKapat
            // 
            this.buttonKapat.Image = ((System.Drawing.Image)(resources.GetObject("buttonKapat.Image")));
            this.buttonKapat.Location = new System.Drawing.Point(760, 0);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(40, 40);
            this.buttonKapat.TabIndex = 5;
            this.buttonKapat.UseVisualStyleBackColor = true;
            this.buttonKapat.Click += new System.EventHandler(this.ButtonKapat_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.ControlBox = false;
            this.Controls.Add(this.buttonKapat);
            this.Controls.Add(this.buttonIstatistik);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonOgren);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                          ANASAYFA";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOgren;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonIstatistik;
        private System.Windows.Forms.Button buttonKapat;
    }
}

