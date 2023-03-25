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
    public partial class FrmArizaliÜrünDetayListesi : Form
    {
        public FrmArizaliÜrünDetayListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmArizaliÜrünDetayListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLURUNTAKIP
                                      select new
                                      {
                                          x.TAKIPID,
                                          x.SERİNO,
                                          x.TARIH,
                                          x.ACIKLAMA
                                      }).ToList();
        }
    }
}
