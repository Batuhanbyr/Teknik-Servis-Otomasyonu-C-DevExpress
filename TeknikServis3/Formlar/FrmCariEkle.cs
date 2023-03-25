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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        int secilen;
        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();
            t.AD = TxtAd.Text;
            t.SOYAD = TxtSoyad.Text;
            t.IL = lookUpEdit1.Text;
            t.ILCE = lookUpEdit2.Text;

            t.BANKA = TxtBanka.Text;
            t.TELEFON = TxtTelefon.Text;
            t.MAIL = TxtMail.Text;
            t.VERGIDAIRESI = TxtVergiDairesi.Text;
            t.VERGINO = TxtVergiNo.Text;
            t.STATU = TxtStatu.Text;
            t.ADRES = TxtAdres.Text;

            // EKLEMEYİ  UNUTMA!!!!!
            db.TBLCARI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Yeni Cari Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FrmCariEkle_Load(object sender, EventArgs e)
        {

            lookUpEdit1.Properties.DataSource = (from x in db.TBLILLER
                                                 select new
                                                 {
                                                     x.id,
                                                     x.sehir
                                                 }).ToList();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
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

        private void TxtAd_Click(object sender, EventArgs e)
        {
            TxtAd.Text = "";
            TxtAd.Focus();
        }

        private void TxtSoyad_Click(object sender, EventArgs e)
        {
            TxtSoyad.Text = "";
            TxtSoyad.Focus();
        }

        private void TxtTelefon_Click(object sender, EventArgs e)
        {
            TxtTelefon.Text = "";
            TxtTelefon.Focus();
        }

        private void TxtMail_Click(object sender, EventArgs e)
        {
            TxtMail.Text = "";
            TxtMail.Focus();
        }

        private void TxtBanka_Click(object sender, EventArgs e)
        {
            TxtBanka.Text = "";
            TxtBanka.Focus();
        }

        private void TxtVergiDairesi_Click(object sender, EventArgs e)
        {
            TxtVergiDairesi.Text = "";
            TxtVergiDairesi.Focus();
        }

        private void TxtVergiNo_Click(object sender, EventArgs e)
        {
            TxtVergiNo.Text = "";
            TxtVergiNo.Focus();
        }

        private void TxtStatu_Click(object sender, EventArgs e)
        {
            TxtStatu.Text = "";
            TxtStatu.Focus();
        }

        private void TxtAdres_Click(object sender, EventArgs e)
        {
            TxtAdres.Text = "";
            TxtAdres.Focus();
        }
    }
}
