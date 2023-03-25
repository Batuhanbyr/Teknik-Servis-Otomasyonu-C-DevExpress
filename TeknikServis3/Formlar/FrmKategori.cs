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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void FrmKategori_Load(object sender, EventArgs e)
        {
            var degerler = from k in db.TBLKATEGORİ
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtKategoriAd.Text != "" && TxtKategoriAd.Text.Length <= 30)
            {
                TBLKATEGORİ t = new TBLKATEGORİ();
                t.AD = TxtKategoriAd.Text;
                db.TBLKATEGORİ.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez ve 30 karakterden Uzun Olamaz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from k in db.TBLKATEGORİ
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList(); 
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtKategoriAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kategoriyi Gerçekten Silmek İstiyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

            {
                if (TxtKategoriAd.Text != "")
                { 
                int id = int.Parse(TxtId.Text);
                var deger = db.TBLKATEGORİ.Find(id);
                db.TBLKATEGORİ.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Kategori Seçiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLKATEGORİ.Find(id);
            deger.AD = TxtKategoriAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtKategoriAd.Text = "";
            TxtId.Text = "";

        }
    }
}
