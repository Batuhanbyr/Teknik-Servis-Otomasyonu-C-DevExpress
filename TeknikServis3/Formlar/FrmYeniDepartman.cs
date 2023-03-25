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
    public partial class FrmYeniDepartman : Form
    {
        public FrmYeniDepartman()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN t = new TBLDEPARTMAN();
            if (TxtAd.Text.Length <= 50 && TxtAd.Text != "" && TxtAcıklama.Text != "" && TxtAcıklama.Text.Length >= 1 && TxtAcıklama.Text.Length <= 100)
            {
                t.AD = TxtAd.Text;
                t.ACIKLAMA = TxtAcıklama.Text;
                db.TBLDEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı,Lütfen Geçerli Değerler Giriniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtAd_Click(object sender, EventArgs e)
        {
            TxtAd.Text = "";
            TxtAd.Focus();
        }
    }
}
