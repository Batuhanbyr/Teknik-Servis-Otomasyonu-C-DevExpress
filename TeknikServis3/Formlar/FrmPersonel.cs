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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL,
                               u.TELEFON


                           };

            gridControl1.DataSource = degerler.ToList();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLDEPARTMAN select new
            {
                x.ID,
                x.AD
            }).ToList();

            string ad1, soyad1,ad2,soyad2,ad3,soyad3,ad4,soyad4;
            //1.personel
            ad1 = db.TBLPERSONEL.First(x => x.ID == 1).AD;
            soyad1 = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            labelControl6.Text = db.TBLPERSONEL.First(x => x.ID == 1).MAIL;
            labelControl4.Text = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            labelControl3.Text = ad1 + " " + soyad1;

            //2.personel
            ad2 = db.TBLPERSONEL.First(x => x.ID == 2).AD;
            soyad2 = db.TBLPERSONEL.First(x => x.ID == 2).SOYAD;
            labelControl9.Text = db.TBLPERSONEL.First(x => x.ID == 2).MAIL;
            labelControl11.Text = db.TBLPERSONEL.First(x => x.ID == 2).TBLDEPARTMAN.AD;
            labelControl14.Text = ad2 + " " + soyad2;

            //3.personel
            ad3 = db.TBLPERSONEL.First(x => x.ID == 3).AD;
            soyad3 = db.TBLPERSONEL.First(x => x.ID == 3).SOYAD;
            labelControl16.Text = db.TBLPERSONEL.First(x => x.ID == 3).MAIL;
            labelControl18.Text = db.TBLPERSONEL.First(x => x.ID == 3).TBLDEPARTMAN.AD;
            labelControl20.Text = ad3 + " " + soyad3;

            //4.personel
            ad4 = db.TBLPERSONEL.First(x => x.ID == 4).AD;
            soyad4 = db.TBLPERSONEL.First(x => x.ID == 4).SOYAD;
            labelControl22.Text = db.TBLPERSONEL.First(x => x.ID == 4).MAIL;
            labelControl24.Text = db.TBLPERSONEL.First(x => x.ID == 4).TBLDEPARTMAN.AD;
            labelControl26.Text = ad4 + " " + soyad4;


        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLPERSONEL t = new TBLPERSONEL();
            t.AD = TxtAd.Text;
            t.SOYAD = TxtSoyad.Text;
            t.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
            t.MAIL = TxtMail.Text;
            t.TELEFON = TxtTel.Text;
            db.TBLPERSONEL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL,
                               u.TELEFON


                           };

            gridControl1.DataSource = degerler.ToList();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLPERSONEL.Find(id);
            db.TBLPERSONEL.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLPERSONEL.Find(id);
            deger.AD = TxtAd.Text;
            deger.SOYAD = TxtSoyad.Text;
            deger.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
            deger.MAIL = TxtMail.Text;
            deger.TELEFON = TxtTel.Text;

            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            TxtMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            TxtTel.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
           
        }
    }
}
