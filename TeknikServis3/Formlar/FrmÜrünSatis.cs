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
    public partial class FrmÜrünSatis : Form
    {
        public FrmÜrünSatis()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSatısYap_Click(object sender, EventArgs e)
        {
            TBLURUNHAREKET t = new TBLURUNHAREKET();
            t.URUN = int.Parse(lookUpEdit1.EditValue.ToString());
            t.MUSTERI = int.Parse(lookUpEdit2.EditValue.ToString());
            t.PERSONEL = short.Parse(lookUpEdit3.EditValue.ToString());
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            t.ADET = short.Parse(TxtAdet.Text);
            t.FIYAT = decimal.Parse(TxtSatışFiyat.Text);
            t.URUNSERINO = TxtSeriNo.Text;
            db.TBLURUNHAREKET.Add(t);
            db.SaveChanges();
            MessageBox.Show("Satış Başarıyla Gerçekleştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmÜrünSatis_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBLURUN
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();

            lookUpEdit2.Properties.DataSource = (from x in db.TBLCARI
                                                 select new
                                                 {
                                                     x.ID,
                                                    AD = x.AD + " " +x.SOYAD
                                                 }).ToList();

            lookUpEdit3.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }

        private void TxtAdet_Click(object sender, EventArgs e)
        {
            TxtAdet.Text = "";
            TxtAdet.Focus();
        }

        private void TxtSatışFiyat_Click(object sender, EventArgs e)
        {
            TxtSatışFiyat.Text = "";
            TxtSatışFiyat.Focus();
        }

        private void TxtSeriNo_Click(object sender, EventArgs e)
        {
            TxtSeriNo.Text = "";
            TxtSeriNo.Focus();
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}
