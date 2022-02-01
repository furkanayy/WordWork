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
    public partial class Anasayfa : MaterialSkin.Controls.MaterialForm
    {
        public Anasayfa()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
        }

        private void ButtonOgren_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ogrenim frmogr = new Ogrenim();
            frmogr.Show();
        }

        private void ButtonTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Test frmtst = new Test();
            frmtst.Show();
        }

        private void ButtonIstatistik_Click(object sender, EventArgs e)
        {
            this.Hide();
            IstatistikSonuc frmsnc = new IstatistikSonuc();
            frmsnc.Show();
        }

        private void ButtonKelimeEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            KelimeEkle frmekle = new KelimeEkle();
            frmekle.Show();
        }

        private void ButtonKapat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); //
        }
    }
}
