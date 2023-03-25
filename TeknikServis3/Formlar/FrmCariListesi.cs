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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        int secilen;
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        public void liste()
        {
            var degerler = from x in db.TBLCARI
                           select new
                           {
                               x.ID,
                               x.AD,
                               x.SOYAD,
                               x.IL,
                               x.ILCE,

                   };

            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmCariListesi_Load(object sender, EventArgs e)
        {

            liste();
            labelControl12.Text = db.TBLCARI.Count().ToString();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLILLER
                                                 select new
                                                 {
                                                     x.id,
                                                     x.sehir
                                                 }).ToList();

            labelControl16.Text = db.TBLCARI.Select(x => x.IL).Distinct().Count().ToString();
            labelControl18.Text = db.TBLCARI.Select(x => x.ILCE).Distinct().Count().ToString();

        }

        private void lookUpEdit1_EditValueChanged_1(object sender, EventArgs e)
        {
            secilen = int.Parse(lookUpEdit1.EditValue.ToString());
            lookUpEdit2.Properties.DataSource = (from y in db.TBLILCELER
                                                 select new
                                                 {
                                                     y.id,
                                                     y.ilce,
                                                     y.sehir

                                                 }).Where(z => z.sehir == secilen).ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text != "" && TxtSoyad.Text!="" && TxtAd.Text.Length<=20 ) {
                TBLCARI t = new TBLCARI();
                t.AD = TxtAd.Text;
                t.SOYAD = TxtSoyad.Text;
                t.IL = lookUpEdit1.Text;
                t.ILCE = lookUpEdit2.Text;

                t.TELEFON = TxtTel.Text;
                t.BANKA = TxtBanka.Text;
                t.VERGIDAIRESI = TxtVDairesi.Text;
                t.VERGINO = TxtVno.Text;
                t.STATU = TxtStatu.Text;
                t.ADRES = TxtAdres.Text;


                db.TBLCARI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                liste();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLCARI.Find(id);
            db.TBLCARI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLCARI.Find(id);
            deger.AD = TxtAd.Text;
            deger.SOYAD = TxtSoyad.Text;
            deger.IL = lookUpEdit1.Text;
            deger.ILCE = lookUpEdit2.Text;
            deger.TELEFON = TxtTel.Text;
            deger.BANKA = TxtBanka.Text;
            deger.VERGIDAIRESI = TxtVDairesi.Text;
            deger.VERGINO = TxtVno.Text;
            deger.STATU = TxtStatu.Text;
            deger.ADRES = TxtAdres.Text;
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
        }
    }
}
