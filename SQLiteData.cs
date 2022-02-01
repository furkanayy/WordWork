using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace YazılımYapımıProjeÖdevi
{
    class SQLiteData
    {
        SQLiteConnection con = new SQLiteConnection("Data Source= db/Sozcuk.db");

        public int KelimeSayısı()
        {
            con.Open();
            //SQLiteDatabaseye bağlanarak verileri tek tek sayarak kaç tane olduğunu sayı değişkenine atıyor.
            string Sorgu = "Select * from Kelimeler";
            SQLiteDataAdapter getir = new SQLiteDataAdapter(Sorgu, con);
            DataSet göster3 = new DataSet();
            getir.Fill(göster3, "Kelimeler");
            int sayi;
            sayi = göster3.Tables["Kelimeler"].Rows.Count;
            con.Close();
            return sayi;
        }

        public void SqliteDogruTarih(int seviyesi, int i)
        {   //Kelimenin seviyesine göre hangi gün sorulacağını hesap ettirilerelek belirleniyor ve sorulacağı güncelleniyor.

            SQLiteConnection con = new SQLiteConnection("Data Source= db/Sozcuk.db");
            con.Open();
            SQLiteCommand guncelleme;
            if (seviyesi == 0)
            {
                DateTime sonrakiGun = DateTime.Today.AddDays(+1);
                guncelleme = new SQLiteCommand("update kelimeler SET Seviyesi='" + 1 + "', Tarih='" + sonrakiGun + "' where Numara = " + i + "", con);
                guncelleme.ExecuteNonQuery();
            }
            else if (seviyesi == 1)
            {
                DateTime sonrakiGun = DateTime.Today.AddDays(+7);
                guncelleme = new SQLiteCommand("UPDATE kelimeler SET Seviyesi='" + 2 + "', Tarih='" + sonrakiGun + "' where Numara = " + i + "", con);
                guncelleme.ExecuteNonQuery();
            }

            else if (seviyesi == 2)
            {
                DateTime sonrakiGun = DateTime.Today.AddDays(+30);
                guncelleme = new SQLiteCommand("UPDATE kelimeler SET Seviyesi='" + 3 + "', Tarih='" + sonrakiGun + "' where Numara = " + i + "", con);
                guncelleme.ExecuteNonQuery();
            }

            else if (seviyesi == 3)
            {
                DateTime sonrakiGun = DateTime.Today.AddDays(+60);
                guncelleme = new SQLiteCommand("UPDATE kelimeler SET Seviyesi='" + 4 + "', Tarih='" + sonrakiGun + "' where Numara = " + i + "", con);
                guncelleme.ExecuteNonQuery();
            }
            else if (seviyesi == 4)
            {
                DateTime sonrakiGun = DateTime.Today;
                guncelleme = new SQLiteCommand("UPDATE kelimeler SET Seviyesi='" + 5 + "', Tarih='" + sonrakiGun + "' where Numara = " + i + "", con);
                guncelleme.ExecuteNonQuery();
            }

            con.Close();
        }

        public void SQLiteYanlısTarihi(int i1)
        { 
            //Sorualrı yanlış bildiğinde tarihi belirliyor ve güncelliyor.
            con.Open();
            SQLiteCommand guncelleme;
            DateTime sonrakiGun = DateTime.Today.AddDays(+1);
            guncelleme = new SQLiteCommand("update kelimeler SET Seviyesi='" + 0 + "', Tarih='" + sonrakiGun + "' where Numara = " + i1 + "", con);
            guncelleme.ExecuteNonQuery();
            con.Close();
        }

        public void SQliteDoğrusu(Label LABEL, int i1)
        {   //Soruları yanlış cevapladığında SQLiteDatabase bağlanıp doğru cevabı çekiyor.
            con.Open();
            string sqlsorgum = "Select Numara,Ingilizcesi,Turkcesi,Tur,IngCumlesi,Tarih,Seviyesi from Kelimeler where Numara = " + i1 + "";
            SQLiteDataAdapter getir2 = new SQLiteDataAdapter(sqlsorgum, con);
            DataSet göster = new DataSet();
            getir2.Fill(göster, "Kelimeler");
            LABEL.DataBindings.Clear();
            LABEL.DataBindings.Add("TEXT", göster.Tables["Kelimeler"], "Turkcesi");
            getir2.Dispose();
            con.Close();
            LABEL.Visible = true;
        }
    }
}
