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
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURADETAY t = new TBLFATURADETAY();
            t.URUN = TxtÜrün.Text;
            t.ADET = short.Parse(TxtAdet.Text);
            t.FIYAT = decimal.Parse(TxtFiyat.Text);
            t.TUTAR = decimal.Parse(TxtTutar.Text);
            t.FATURAID = int.Parse(TxtFaturaID.Text);
            db.TBLFATURADETAY.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           };

            gridControl1.DataSource = degerler.ToList();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLFATURADETAY.Find(id);
            db.TBLFATURADETAY.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLFATURADETAY.Find(id);
            deger.URUN = TxtÜrün.Text;
            deger.ADET = short.Parse(TxtAdet.Text);
            deger.FIYAT = decimal.Parse(TxtFiyat.Text);
            deger.TUTAR = decimal.Parse(TxtTutar.Text);
            deger.FATURAID = int.Parse(TxtFaturaID.Text);
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           };

            gridControl1.DataSource = degerler.ToList();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("FATURADETAYID").ToString();
            TxtÜrün.Text = gridView1.GetFocusedRowCellValue("URUN").ToString();
            TxtAdet.Text = gridView1.GetFocusedRowCellValue("ADET").ToString();
            TxtFiyat.Text = gridView1.GetFocusedRowCellValue("FIYAT").ToString();
            TxtTutar.Text = gridView1.GetFocusedRowCellValue("TUTAR").ToString();
            TxtFaturaID.Text = gridView1.GetFocusedRowCellValue("FATURAID").ToString();
        }
    }
}
