using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using MaterialSkin;
using MaterialSkin.Controls;

namespace YazılımYapımıProjeÖdevi
{
    public partial class Test : MaterialSkin.Controls.MaterialForm
    {
        public Test()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }
        int i = 1;
        int seviye = 0;

        private void Test_Load(object sender, EventArgs e)
        {
            materialLblIng.Visible = false;
            materialLblTr.Visible = false;
            materialLblTur.Visible = false;
            materialLblIngCum.Visible = false;
            txtboxIng.Visible = false;
            txtboxTr.Visible = false;
            txtboxTur.Visible = false;
            txtboxIngCum.Visible = false;
            materialFlatButtonKontrol.Visible = false;
            materialLblDogru.Visible = false;
            materialFlatButtonKontrol.Enabled = false;
        }
        private void MaterialFlatButtonBasla_Click(object sender, EventArgs e)
        {
            materialLblIng.Visible = true;
            materialLblTr.Visible = true;
            materialLblTur.Visible = true;
            materialLblIngCum.Visible = true;
            txtboxIng.Visible = true;
            txtboxTr.Visible = true;
            txtboxTur.Visible = true;
            txtboxIngCum.Visible = true;
            materialFlatButtonKontrol.Visible = true;
            materialFlatButtonBasla.Visible = false;
            materialFlatButtonKontrol.Enabled = true;
            materialLblDogru.DataBindings.Clear();
            materialLblDogru.Visible = false;
            txtboxTr.ReadOnly = false;
            txtboxTr.Text = "";
            KelimeleriGoster();
        }

        private void MaterialFlatButtonKontrol_Click(object sender, EventArgs e)
        {
            if (txtboxTr.Text == "")
            {
                MessageBox.Show("LÜTFEN TÜRKÇE KISMINI BOŞ BIRAKMAYIN");
            }

            else
            {
                SQLiteConnection con = new SQLiteConnection("Data Source= db/Sozcuk.db");
                con.Open();
                string sql = "SELECT * FROM Kelimeler WHERE Ingilizcesi=@ing AND Turkcesi=@turkce";

                SQLiteParameter prm1 = new SQLiteParameter("ing", txtboxIng.Text);
                SQLiteParameter prm2 = new SQLiteParameter("turkce", txtboxTr.Text.ToLower());

                SQLiteCommand cmd = new SQLiteCommand(sql, con);

                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                //Yanlış yaptığında veya doğru yaptığında SQLiteData bağlanıp fonksiyon çağırıyor.
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Doğru Yaptın...");
                    DogruTarih(seviye);
                    i++;
                }
                else
                {
                    MessageBox.Show("Yanlış yaptın!!!");
                    Dogrusu();
                    YanlısTarihi();
                    i++;

                }

                materialFlatButtonBasla.Text = "SIRADAKİ";
                materialFlatButtonBasla.Visible = true;
                materialFlatButtonKontrol.Enabled = false;
                txtboxTr.ReadOnly = true;

                con.Close();
            }
        }

        private void Dogrusu()
        {
            SQLiteData db1 = new SQLiteData();
            db1.SQliteDoğrusu(materialLblDogru, i);
        }

        private void KelimeleriGoster()
        {
            SQLiteData db1 = new SQLiteData();
            int sayi = db1.KelimeSayısı();

            for (int j = 1; j < sayi; j++)
            {
                //Sorulacak soruları SQLiteDatabase den çekip textboxlara yazdırıyor.Her cevaplamadan sonra yeni soru cevaplanmak istendiğinde 
                //textboxlar temizleyip yeni soru soruluyor.
                string bağlantı, tstsorgum;
                bağlantı = "Data Source= db/Sozcuk.db";
                tstsorgum = "Select Numara,Ingilizcesi,Turkcesi,Tur,IngCumlesi,Tarih,Seviyesi from Kelimeler where Numara = " + i + "";
                SQLiteConnection yeni = new SQLiteConnection(bağlantı);
                yeni.Open();
                SQLiteDataAdapter tstgetir = new SQLiteDataAdapter(tstsorgum, yeni);
                DataSet göster = new DataSet();
                tstgetir.Fill(göster, "Kelimeler");
                txtboxIng.Text = "";
                txtboxIng.DataBindings.Clear();
                txtboxTur.Text = "";
                txtboxTur.DataBindings.Clear();
                txtboxIngCum.Text = "";
                txtboxIngCum.DataBindings.Clear();

                if (i > sayi)
                {
                    MessageBox.Show("Sorular bitti");
                    materialFlatButtonKontrol.Enabled = false;
                    break;

                }
                DateTime bugun = DateTime.Today;
                txtboxIng.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Tarih");
                DateTime sorunungunu = Convert.ToDateTime(txtboxIng.Text);
                txtboxIng.Text = "";
                txtboxIng.DataBindings.Clear();

                txtboxIng.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Seviyesi");
                seviye = Convert.ToInt32(txtboxIng.Text);
                txtboxIng.Text = "";
                txtboxIng.DataBindings.Clear();


                //Sorunun sorulacağı gün ile bugünü karşılaştırıyor.Eğer aynı gün ise soru soruluyor.
                int ZamanıGeldiMi = DateTime.Compare(bugun, sorunungunu);
                txtboxIng.DataBindings.Clear();
                if (ZamanıGeldiMi >= 0 && seviye < 5)
                {

                    txtboxIng.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Ingilizcesi");
                    txtboxTur.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Tur");
                    txtboxIngCum.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "IngCumlesi");
                    break;
                }
                else
                    i++;


            }

        }

        private void DogruTarih(int seviyesi1)
        {
            SQLiteData db1 = new SQLiteData();
            db1.SqliteDogruTarih(seviyesi1, i);
        }

        private void YanlısTarihi()
        {
            SQLiteData db1 = new SQLiteData();
            db1.SQLiteYanlısTarihi(i);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Anasayfa ana = new Anasayfa();
            ana.Show();
        }

        private void ButtonAnasayfa_Click(object sender, EventArgs e)
        {
            this.Close();
            Anasayfa menu = new Anasayfa();
            menu.Show();
        }

        private void ButtonKapat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
