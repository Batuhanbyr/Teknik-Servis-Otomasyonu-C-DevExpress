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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               CARİ = u.TBLCARI.AD + u.TBLCARI.SOYAD,
                               PERSONEL = u.TBLPERSONEL.AD  + u.TBLPERSONEL.SOYAD
                           };

            gridControl1.DataSource = degerler.ToList();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARI
                                                 select new
                                                 {
                                                     x.ID,
                                                   AD = x.AD + " " + x.SOYAD,
                                                 }).ToList();

            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD,
                                                 }).ToList();

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               CARİ = u.TBLCARI.AD + u.TBLCARI.SOYAD,
                               PERSONEL = u.TBLPERSONEL.AD + u.TBLPERSONEL.SOYAD
                           };

            gridControl1.DataSource = degerler.ToList();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURABILGI t = new TBLFATURABILGI();
            t.SERI = TxtSeri.Text;
            t.SIRANO = TxtSıraNo.Text;
            t.TARIH = Convert.ToDateTime(TxtTarih.Text);
            t.SAAT = TxtSaat.Text;
            t.VERGIDAIRE = TxtVergiDairesi.Text;
            t.CARİ = int.Parse(lookUpEdit1.EditValue.ToString());
            t.PERSONEL = short.Parse(lookUpEdit2.EditValue.ToString());
            db.TBLFATURABILGI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Sisteme Kaydedilmiştir, Kalem Girişi Yapabilirsiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

      
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemPopup fr = new FrmFaturaKalemPopup();
            fr.id =int.Parse( gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLFATURABILGI.Find(id);
            db.TBLFATURABILGI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLFATURABILGI.Find(id);
            deger.SERI = TxtSeri.Text;
            deger.SIRANO = TxtSıraNo.Text;
            deger.TARIH = Convert.ToDateTime(TxtTarih.Text);
            deger.SAAT = TxtSaat.Text;
            deger.VERGIDAIRE = TxtVergiDairesi.Text;
            deger.CARİ = int.Parse(lookUpEdit1.EditValue.ToString());
            deger.PERSONEL = short.Parse(lookUpEdit2.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtSeri.Text = gridView1.GetFocusedRowCellValue("SERI").ToString();
            TxtSıraNo.Text = gridView1.GetFocusedRowCellValue("SIRANO").ToString();
            TxtTarih.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();
            TxtSaat.Text = gridView1.GetFocusedRowCellValue("SAAT").ToString();
            TxtVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRE").ToString();
           
        }
    }
}
