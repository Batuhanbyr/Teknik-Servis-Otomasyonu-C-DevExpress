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
    public partial class FrmArızalıÜrünKaydı : Form
    {
        public FrmArızalıÜrünKaydı()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtID_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void FrmArızalıÜrünKaydı_Load(object sender, EventArgs e)
        {
            //Müşteri
            lookUpEdit2.Properties.DataSource = (from x in db.TBLCARI
                                                 select new
                                                 {
                                                     x.ID,
                                                    AD = x.AD + " " + x.SOYAD
                                                 }).ToList();

            //Personel
            lookUpEdit1.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            TBLURUNKABUL t = new TBLURUNKABUL();
           
            t.GELISTARIH = DateTime.Parse(TxtTarih.Text);
            t.ISLEMID = int.Parse(lookUpEdit2.EditValue.ToString());
            t.PERSONEL =short.Parse(lookUpEdit1.EditValue.ToString()); 
            t.URUNSERINO = TxtSeriNo.Text;
            t.URUNDURUMDETAY = "Ürün Kaydoldu";
            t.URUNDURUM = true;
            db.TBLURUNKABUL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Arızalı Ürün Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void TxtSeriNo_Click(object sender, EventArgs e)
        {
            TxtSeriNo.Text = "";
            TxtSeriNo.Focus();

        }
    }
}
