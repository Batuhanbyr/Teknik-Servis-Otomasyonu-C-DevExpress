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
    public partial class FrmAnaSayfa : Form
    {
     
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            gridControl4.DataSource = (from x in db.TBLURUN
                                       select new
                                       {
                                           x.AD,
                                           x.STOK
                                       }).Where(x => x.STOK < 30).ToList();
            gridControl2.DataSource = (from y in db.TBLCARI
                                       select new
                                       {
                                           y.AD,
                                           y.SOYAD,
                                           y.IL
                                       }).ToList();
            gridControl3.DataSource = db.ürünkategori().ToList();

            DateTime bugün = DateTime.Today;

            var deger = (from x in db.TBLNOTLARIM.OrderBy(y => y.ID)
                         where (x.TARİH == bugün)
                         select new
                         {
                             x.BASLIK,
                             x.ICERIK
                         });
            gridControl1.DataSource = deger.ToList();

            string konu1, ad1, konu2, ad2, konu3, ad3, konu4, ad4, konu5, ad5, konu6, ad6, konu7, ad7;
            konu1 = db.TBLİLETİSİM.First(x => x.ID == 1).KONU;
            ad1 = db.TBLİLETİSİM.First(x => x.ID == 1).ADSOYAD;
            labelControl1.Text = konu1 + " - " + ad1;

            konu2 = db.TBLİLETİSİM.First(x => x.ID == 2).KONU;
            ad2 = db.TBLİLETİSİM.First(x => x.ID == 2).ADSOYAD;
            labelControl2.Text = konu2 + " - " + ad2;

            konu3 = db.TBLİLETİSİM.First(x => x.ID == 3).KONU;
            ad3 = db.TBLİLETİSİM.First(x => x.ID == 3).ADSOYAD;
            labelControl3.Text = konu3 + " - " + ad3;

            konu4 = db.TBLİLETİSİM.First(x => x.ID == 4).KONU;
            ad4 = db.TBLİLETİSİM.First(x => x.ID == 4).ADSOYAD;
            labelControl4.Text = konu4 + " - " + ad4;

            konu5 = db.TBLİLETİSİM.First(x => x.ID == 5).KONU;
            ad5 = db.TBLİLETİSİM.First(x => x.ID == 5).ADSOYAD;
            labelControl5.Text = konu5 + " - " + ad5;

            konu6 = db.TBLİLETİSİM.First(x => x.ID == 6).KONU;
            ad6 = db.TBLİLETİSİM.First(x => x.ID == 6).ADSOYAD;
            labelControl6.Text = konu6 + " - " + ad6;

            konu7 = db.TBLİLETİSİM.First(x => x.ID == 7).KONU;
            ad7 = db.TBLİLETİSİM.First(x => x.ID == 7).ADSOYAD;
            labelControl7.Text = konu7 + " - " + ad7;

           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class Class1
    {
    }

    public class FrmAnaSayfaa
    {
    }

    public class FRMAnaSayfa
    {
    }
}
