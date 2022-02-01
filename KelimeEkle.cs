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
    public partial class KelimeEkle : MaterialSkin.Controls.MaterialForm
    {
        public KelimeEkle()//
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void KelimeEkle_Load(object sender, EventArgs e)
        {

        }

        private void MaterialFlatButtonEkle_Click(object sender, EventArgs e)
        {   
            //Textbox a girilen bilgileri değişkenlere atanıp ekle sınıfına gnderiliyor.

            if (txtBoxTr.Text == "" || txtBoxIng.Text == "" || txtBoxTur.Text == "" || txtBoxIngCum.Text == "" || txtBoxTrCum.Text == "")
            {
                MessageBox.Show("LÜTFEN ALANLARI BOŞ BIRAKMAYIN");
            }

            else
            {
                string ing = txtBoxIng.Text, tr = txtBoxTr.Text;
                string turu = txtBoxTur.Text, cumle = txtBoxIngCum.Text;
                string trcumlesi = txtBoxTrCum.Text;

                Ekle ke = new Ekle();
                ke.KayıtEkle(ing, tr, turu, cumle, trcumlesi);
                string mesaj = "Kelime Eklendi!";
                MessageBox.Show(mesaj);
            }
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
