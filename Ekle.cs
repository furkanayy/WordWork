using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace YazılımYapımıProjeÖdevi
{
    class Ekle
    {
        public void KayıtEkle(string ing, string turk, string turu, string ıngcumle, string trcumle)
        {

            SQLiteConnection baglan = new SQLiteConnection();
            baglan.ConnectionString = ("Data Source=db/Sozcuk.db");

            turk = turk.ToLower();

            //Alınan veriler SqLiteDatabaseden parametre alınarak ekleniyor.

            baglan.Open();
            string sql = "Insert into Kelimeler(Ingilizcesi,Turkcesi,Tur,IngCumlesi,TrCumlesi,Tarih,Seviyesi) values(@Ingilizcesi,@Turkcesi,@Tur,@IngCumlesi,@TrCumlesi,@Tarih,@Seviyesi)";
            SQLiteCommand cmd = new SQLiteCommand(sql, baglan);
            cmd.Parameters.AddWithValue("@Ingilizcesi", ing);
            cmd.Parameters.AddWithValue("@Turkcesi", turk);
            cmd.Parameters.AddWithValue("@Tur", turu);
            cmd.Parameters.AddWithValue("@IngCumlesi", ıngcumle);
            cmd.Parameters.AddWithValue("@TrCumlesi", trcumle);
            cmd.Parameters.AddWithValue("@Tarih", DateTime.Today.ToString());
            cmd.Parameters.AddWithValue("@Seviyesi", "0");

            cmd.ExecuteNonQuery();
            baglan.Close();
            cmd.Dispose();

        }
    }
}
