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
    public partial class FrmArizaDetaylar : Form
    {
        public FrmArizaDetaylar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUNTAKIP t = new TBLURUNTAKIP();
            t.ACIKLAMA = TxtArizaDetay.Text;
            t.SERİNO = TxtSeriNO.Text;
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            db.TBLURUNTAKIP.Add(t);
           

            //2. güncelleme
            TBLURUNKABUL tb = new TBLURUNKABUL();
            int urunid = int.Parse(id.ToString());
            var deger = db.TBLURUNKABUL.Find(urunid);
            deger.URUNDURUMDETAY = comboBox1.Text;
            db.SaveChanges();


            MessageBox.Show("Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string id,serino;
        private void FrmArizaDetaylar_Load(object sender, EventArgs e)
        {
          TxtSeriNO.Text = serino;
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
