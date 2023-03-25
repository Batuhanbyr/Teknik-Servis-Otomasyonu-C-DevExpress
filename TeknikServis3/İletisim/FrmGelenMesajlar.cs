using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis3.İletisim
{
    public partial class FrmGelenMesajlar : Form
    {
        public FrmGelenMesajlar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmGelenMesajlar_Load(object sender, EventArgs e)
        {
            labelControl12.Text = db.TBLİLETİSİM.Count().ToString();
            labelControl14.Text = db.TBLİLETİSİM.Where(x => x.KONU == "Teşekkür").Count().ToString();
            labelControl16.Text = db.TBLİLETİSİM.Where(x => x.KONU == "Rica").Count().ToString();
            labelControl18.Text = db.TBLİLETİSİM.Where(x => x.KONU == "Şikayet").Count().ToString();

            chartControl1.Series["Series 1"].Points.AddPoint("Teşekkür", db.TBLİLETİSİM.Where(x => x.KONU == "Teşekkür").Count());
            chartControl1.Series["Series 1"].Points.AddPoint("Rica", db.TBLİLETİSİM.Where(x => x.KONU == "Rica").Count());
            chartControl1.Series["Series 1"].Points.AddPoint("Şikayet", db.TBLİLETİSİM.Where(x => x.KONU == "Şikayet").Count());


            gridControl1.DataSource = (from x in db.TBLİLETİSİM
                                       select new
                                       {
                                           x.ID,
                                           x.ADSOYAD,
                                           x.KONU,
                                           x.MAİL,
                                           x.MESAJ
                                       }).ToList();
        }
    }
}
