namespace YazılımYapımıProjeÖdevi
{
    partial class IstatistikSonuc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IstatistikSonuc));
            this.chartTarih = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxYıl = new System.Windows.Forms.ComboBox();
            this.materialFlatButtonGoster = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonKapat = new System.Windows.Forms.Button();
            this.buttonAnasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartTarih)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTarih
            // 
            chartArea6.Name = "ChartArea1";
            this.chartTarih.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartTarih.Legends.Add(legend6);
            this.chartTarih.Location = new System.Drawing.Point(23, 92);
            this.chartTarih.Name = "chartTarih";
            series6.BorderColor = System.Drawing.SystemColors.Control;
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.Black;
            series6.Legend = "Legend1";
            series6.Name = "Ogrenildi";
            this.chartTarih.Series.Add(series6);
            this.chartTarih.Size = new System.Drawing.Size(553, 405);
            this.chartTarih.TabIndex = 0;
            this.chartTarih.Text = "chart1";
            // 
            // comboBoxYıl
            // 
            this.comboBoxYıl.FormattingEnabled = true;
            this.comboBoxYıl.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.comboBoxYıl.Location = new System.Drawing.Point(627, 233);
            this.comboBoxYıl.Name = "comboBoxYıl";
            this.comboBoxYıl.Size = new System.Drawing.Size(121, 24);
            this.comboBoxYıl.TabIndex = 1;
            // 
            // materialFlatButtonGoster
            // 
            this.materialFlatButtonGoster.AutoSize = true;
            this.materialFlatButtonGoster.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButtonGoster.Depth = 0;
            this.materialFlatButtonGoster.Location = new System.Drawing.Point(598, 286);
            this.materialFlatButtonGoster.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButtonGoster.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButtonGoster.Name = "materialFlatButtonGoster";
            this.materialFlatButtonGoster.Primary = false;
            this.materialFlatButtonGoster.Size = new System.Drawing.Size(179, 36);
            this.materialFlatButtonGoster.TabIndex = 3;
            this.materialFlatButtonGoster.Text = "ÖĞRENİLENİ GÖSTER";
            this.materialFlatButtonGoster.UseVisualStyleBackColor = true;
            this.materialFlatButtonGoster.Click += new System.EventHandler(this.MaterialFlatButtonGoster_Click);
            // 
            // buttonKapat
            // 
            this.buttonKapat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonKapat.Image = ((System.Drawing.Image)(resources.GetObject("buttonKapat.Image")));
            this.buttonKapat.Location = new System.Drawing.Point(760, 0);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(40, 40);
            this.buttonKapat.TabIndex = 6;
            this.buttonKapat.UseVisualStyleBackColor = false;
            this.buttonKapat.Click += new System.EventHandler(this.ButtonKapat_Click);
            // 
            // buttonAnasayfa
            // 
            this.buttonAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAnasayfa.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnasayfa.Image")));
            this.buttonAnasayfa.Location = new System.Drawing.Point(720, 0);
            this.buttonAnasayfa.Name = "buttonAnasayfa";
            this.buttonAnasayfa.Size = new System.Drawing.Size(40, 40);
            this.buttonAnasayfa.TabIndex = 13;
            this.buttonAnasayfa.UseVisualStyleBackColor = true;
            this.buttonAnasayfa.Click += new System.EventHandler(this.ButtonAnasayfa_Click);
            // 
            // IstatistikSonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAnasayfa);
            this.Controls.Add(this.buttonKapat);
            this.Controls.Add(this.materialFlatButtonGoster);
            this.Controls.Add(this.comboBoxYıl);
            this.Controls.Add(this.chartTarih);
            this.Name = "IstatistikSonuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                         ÖĞRENİLEN KELİME İSTATİSTİĞİ";
            this.Load += new System.EventHandler(this.IstatistikSonuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTarih)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTarih;
        private System.Windows.Forms.ComboBox comboBoxYıl;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonGoster;
        private System.Windows.Forms.Button buttonKapat;
        private System.Windows.Forms.Button buttonAnasayfa;
    }
}