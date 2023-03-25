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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {
            lookUpEdit2.Properties.DataSource = (from x in db.TBLKATEGORİ
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();

        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.AD = TxtAd.Text;
            t.MARKA = TxtMarka.Text;
            t.ALISFIYAT = decimal.Parse(TxtAlısFiyat.Text);
            t.SATISFIYAT = decimal.Parse(TxtSatısFiyat.Text);
            t.STOK = short.Parse(TxtStok.Text);
            t.DURUM = false;
            t.KATEGORI = byte.Parse(lookUpEdit2.EditValue.ToString());
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void TxtAd_Click(object sender, EventArgs e)
        {
            TxtAd.Text = "";
            TxtAd.Focus();
        }

        private void TxtMarka_Click(object sender, EventArgs e)
        {
            TxtMarka.Text = "";
            TxtMarka.Focus();
        }

        private void TxtKategori_Click(object sender, EventArgs e)
        {

        }

        private void TxtAlısFiyat_Click(object sender, EventArgs e)
        {
            TxtAlısFiyat.Text = "";
            TxtAlısFiyat.Focus();
        }

        private void TxtSatısFiyat_Click(object sender, EventArgs e)
        {
            TxtSatısFiyat.Text = "";
            TxtSatısFiyat.Focus();
        }

        private void TxtStok_Click(object sender, EventArgs e)
        {
            TxtStok.Text = "";
            TxtStok.Focus();
        }
    }
}
