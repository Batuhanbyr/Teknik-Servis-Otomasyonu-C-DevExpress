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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.TBLURUN.Count().ToString();
            labelControl3.Text = db.TBLKATEGORİ.Count().ToString();
            labelControl9.Text = db.TBLDEPARTMAN.Count().ToString();
            labelControl23.Text = db.TBLCARI.Count().ToString();
            labelControl11.Text = db.TBLNOTLARIM.Count().ToString();
            labelControl37.Text = (from x in db.TBLURUN
                                   orderby x.MARKA ascending
                                   select x.AD).FirstOrDefault();
            labelControl27.Text = (from x in db.TBLURUN
                                   orderby x.MARKA descending
                                   select x.AD).FirstOrDefault();
            labelControl7.Text = "10";
            labelControl5.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            labelControl19.Text = (from x in db.TBLURUN
                                   orderby x.STOK descending
                                   select x.AD).FirstOrDefault();
            labelControl17.Text = (from x in db.TBLURUN
                                   orderby x.STOK ascending
                                   select x.AD).FirstOrDefault();
            labelControl13.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT descending
                                   select x.AD).FirstOrDefault();
            labelControl11.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT ascending
                                   select x.AD).FirstOrDefault();
            labelControl29.Text = db.TBLURUN.Count(x => x.KATEGORI == 4).ToString();
            labelControl31.Text = db.TBLURUN.Count(x => x.KATEGORI == 13).ToString();
            labelControl35.Text = db.TBLURUN.Count(x => x.KATEGORI == 6).ToString();
            labelControl25.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            labelControl21.Text = db.TBLURUN.Count(x => x.KATEGORI == 3).ToString();
            labelControl39.Text = (from x in db.TBLURUN
                                   select x.MARKA).Distinct().Count().ToString();

            labelControl33.Text = db.TBLURUNKABUL.Count().ToString();

            labelControl15.Text = db.makskategoriurun().FirstOrDefault();

            /* 5.panel eksik  11 37 27 23 35 31
             * 
             */
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
