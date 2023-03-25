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
    public partial class FrmFaturaKalemPopup : Form
    {
        public FrmFaturaKalemPopup()
        {
            InitializeComponent();
        }

        public int id;
        private void FrmFaturaKalemPopup_Load(object sender, EventArgs e)
        {
            // labelControl1.Text = id;
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            gridControl1.DataSource = db.TBLFATURADETAY.Where(x => x.FATURAID == id).ToList();
            gridControl2.DataSource = db.TBLFATURABILGI.Where(x => x.ID == id).ToList();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.pdf";
            gridControl1.ExportToPdf(path);
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.xls";
            gridControl1.ExportToXls(path);
        }

        private void pictureEdit3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
