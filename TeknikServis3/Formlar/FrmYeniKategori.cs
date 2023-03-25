using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis3.Formlar
{
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmYeniKategori_Load(object sender, EventArgs e)
        {
     
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text != "" && TxtAd.Text.Length <= 30)
            {
                TBLKATEGORİ t = new TBLKATEGORİ();
                t.AD = TxtAd.Text;
                db.TBLKATEGORİ.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez ve 30 karakterden Uzun Olamaz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void TxtAd_Click(object sender, EventArgs e)
        {
            TxtAd.Text = "";
            TxtAd.Focus();
        }
    }
}
