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
    public partial class FrmYeniNot : Form
    {
        public FrmYeniNot()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLNOTLARIM t = new TBLNOTLARIM();
            t.BASLIK = TxtBaslık.Text;
            t.ICERIK = Txtİçerik.Text;
            t.DURUM = false;
            db.TBLNOTLARIM.Add(t);
            db.SaveChanges();
            MessageBox.Show("Not Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBaslık_Click(object sender, EventArgs e)
        {
            TxtBaslık.Text = "";
            TxtBaslık.Focus();
        }
    }
}
