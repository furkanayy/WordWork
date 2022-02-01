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
    public partial class IstatistikSonuc : MaterialSkin.Controls.MaterialForm
    {
        public IstatistikSonuc()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }
        SQLiteConnection con = new SQLiteConnection("Data Source=db/Sozcuk.db");
        private void IstatistikSonuc_Load(object sender, EventArgs e)
        {

        }
        private int Ogrenilenler(int ay, int yıl)
        {
            int sonay = 0;
            con.Open();
            string sql = "SELECT count(*) FROM Kelimeler";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            int kayitSayisi = Convert.ToInt32(cmd.ExecuteScalar());


            for (int i = 1; i < kayitSayisi; i++)
            {
                //SQLiteDatabase kelimelerin tutulduğu tarihin ay ve yılı alınarak gönderilen değer ile karşılaştırılıp o ayda kaç tane kelime öğrenildiyse
                //değişkene atanıyor
                SQLiteCommand cmd1 = new SQLiteCommand("Select Tarih from Kelimeler where Numara=" + i + "", con);
                DateTime Gün = Convert.ToDateTime(cmd1.ExecuteScalar());
                int günayı = Convert.ToInt32(Gün.Month.ToString());
                int günyılı = Convert.ToInt32(Gün.Year.ToString());


                SQLiteCommand cmd2 = new SQLiteCommand("Select Seviyesi from Kelimeler where Numara=" + i + "", con);
                int seviye = Convert.ToInt32(cmd2.ExecuteScalar());


                if (günayı == ay && günyılı == yıl && seviye == 5)
                {
                    sonay++;
                }

            }
            con.Close();
            return sonay;
        }
        private void GrafikDoldur()
        {
            //Öğrenilen kelimelerin uygun ay ve tarihine göre girafik oluşturuluyor.
            int a;
            int yıl1 = Convert.ToInt32(comboBoxYıl.SelectedItem.ToString());
            for (a = 1; a < 13; a++)
            {
                int a1 = Ogrenilenler(a, yıl1);
                chartTarih.Series["Ogrenildi"].Points.AddXY(a + "/" + yıl1, a1);
            }

        }

        private void MaterialFlatButtonGoster_Click(object sender, EventArgs e)
        {
            if(comboBoxYıl.SelectedIndex == -1)
                 MessageBox.Show("Lütfen Seçim Yapınız");
            chartTarih.Series["Ogrenildi"].Points.Clear();
            GrafikDoldur();

        }

        private void ButtonKapat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ButtonAnasayfa_Click(object sender, EventArgs e)
        {
            this.Close();
            Anasayfa menu = new Anasayfa();
            menu.Show();
        }
    }
}
