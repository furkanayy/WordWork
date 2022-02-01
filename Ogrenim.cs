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
    public partial class Ogrenim : MaterialSkin.Controls.MaterialForm
    {
        public Ogrenim()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }
        int i = 1, seviye;

        private void Ogrenim_Load(object sender, EventArgs e)
        {
            materialLblTr.Visible = false;
            materialLblIng.Visible = false;
            materialLblTur.Visible = false;
            materialLblIngCum.Visible = false;
            materialLblTrCum.Visible = false;
            txtboxTr.Visible = false;
            txtboxIng.Visible = false;
            txtboxTur.Visible = false;
            txtboxIngCum.Visible = false;
            txtboxTrCum.Visible = false;
        }
       
        private void MaterialFlatButtonOgren_Click(object sender, EventArgs e)
        {
            materialLblTr.Visible = true;
            materialLblIng.Visible = true;
            materialLblTur.Visible = true;
            materialLblIngCum.Visible = true;
            materialLblTrCum.Visible = true;
            txtboxTr.Visible = true;
            txtboxIng.Visible = true;
            txtboxTur.Visible = true;
            txtboxIngCum.Visible = true;
            txtboxTrCum.Visible = true;
            KelimeleriGoster();
            SeviyeGuncelleme();
            materialFlatButtonOgren.Text = "SIRADAKİ";

            i++;
        }
        private void KelimeleriGoster()
        {
            SQLiteData db1 = new SQLiteData();
            int sayi = db1.KelimeSayısı();

            for (int j = 1; j < sayi; j++)
            {
                //SQliteDatabase e bağlanıp verileri alıyor.
                //Textboxların içi temizleniyor.
                string bağlantı, ogrsorgum;
                bağlantı = "Data Source= db/Sozcuk.db";
                ogrsorgum = "Select Numara,Ingilizcesi,Turkcesi,Tur,IngCumlesi,TrCumlesi,Tarih,Seviyesi from Kelimeler where Numara = " + i + "";
                SQLiteConnection yeni = new SQLiteConnection(bağlantı);
                yeni.Open();
                SQLiteDataAdapter ogrgetir = new SQLiteDataAdapter(ogrsorgum, yeni);
                DataSet göster = new DataSet();
                ogrgetir.Fill(göster, "Kelimeler");
                txtboxIng.Text = "";
                txtboxIng.DataBindings.Clear();
                txtboxTur.Text = "";
                txtboxTur.DataBindings.Clear();
                txtboxIngCum.Text = "";
                txtboxIngCum.DataBindings.Clear();
                txtboxTrCum.Text = "";
                txtboxTrCum.DataBindings.Clear();
                txtboxTr.Text = "";
                txtboxTr.DataBindings.Clear();



                if (i > sayi)
                {
                    MessageBox.Show("Kelimeler Bitti!!!");
                    break;

                }
                txtboxIng.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Seviyesi");
                    seviye = Convert.ToInt32(txtboxIng.Text);
                    txtboxIng.Text = "";
                    txtboxIng.DataBindings.Clear();
                //Alınan verilerilerin seviyesine göre textboxlara yazdırılıyor.
                if (seviye == 0)
                {
                    txtboxIng.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Ingilizcesi");
                    txtboxTr.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Turkcesi");
                    txtboxTur.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Tur");
                    txtboxIngCum.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "IngCumlesi");
                    txtboxTrCum.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "TrCumlesi");
                    break;
                }
                else
                    i++;
            }
        }

        private void ButtonAnasayfa_Click(object sender, EventArgs e)
        {
            this.Close();
            Anasayfa menu = new Anasayfa();
            menu.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void SeviyeGuncelleme()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source= db/Sozcuk.db");
            con.Open();
            SQLiteCommand guncelleme;
            DateTime sonrakiGun = DateTime.Today.AddDays(+1);
            guncelleme = new SQLiteCommand("update kelimeler SET Seviyesi='" + 1 + "' where Numara = " + i + "", con);
            guncelleme.ExecuteNonQuery();
            con.Close();
        }
    }
}
