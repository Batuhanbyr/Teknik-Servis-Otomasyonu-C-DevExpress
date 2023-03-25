using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Formlar.FrmUrunListesi fr3;
        private void BtnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null || fr3.IsDisposed)
            {
                fr3 = new Formlar.FrmUrunListesi();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }

        Formlar.FrmPersonel fr30;
        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr30 == null || fr30.IsDisposed)
            {
                fr30 = new Formlar.FrmPersonel();
                fr30.MdiParent = this;
                fr30.Show();
            }

        }

        Formlar.FrmYeniUrun fr4;
        private void BtnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null || fr4.IsDisposed)
            {
                fr4 = new Formlar.FrmYeniUrun();
                fr4.Show();
            }
        }

        Formlar.FrmKategori fr2;
        private void BtnKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null || fr2.IsDisposed)
            {
                fr2 = new Formlar.FrmKategori();
                fr2.MdiParent = this;
                fr2.Show();
            }

        }

        Formlar.FrmYeniKategori fr5;
        private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null || fr5.IsDisposed)
            {
                fr5 = new Formlar.FrmYeniKategori();
                fr5.Show();
            }

        }

        Formlar.Frmİstatistik fr6;
        private void Btnİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null || fr6.IsDisposed)
            {
                fr6 = new Formlar.Frmİstatistik();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }

        Formlar.FrmMarkalar fr7;
        private void BtnMarkaİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null || fr7.IsDisposed)
            {
                fr7 = new Formlar.FrmMarkalar();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }

        Formlar.FrmCariListesi fr8;
        private void BtnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8 == null || fr8.IsDisposed)
            {
                fr8 = new Formlar.FrmCariListesi();
                fr8.MdiParent = this;
                fr8.Show();
            }

        }
        Formlar.FrmCari fr9;
        private void BtnCariİlİstatisttiği_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9 == null || fr9.IsDisposed)
            {
                fr9 = new Formlar.FrmCari();
                fr9.MdiParent = this;
                fr9.Show();
            }
        }

        Formlar.FrmCariEkle fr10;
        private void BtnYeniCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10 == null || fr10.IsDisposed)
            {
                fr10 = new Formlar.FrmCariEkle();
                fr10.Show();
            }
        }
        Formlar.FrmDepartman fr11;
        private void BtnDepatmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11 == null || fr11.IsDisposed)
            {
                fr11 = new Formlar.FrmDepartman();
                fr11.MdiParent = this;
                fr11.Show();
            }

        }
        Formlar.FrmYeniDepartman fr12;
        private void BtnYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr12 == null || fr12.IsDisposed)
            {
                fr12 = new Formlar.FrmYeniDepartman();
                fr12.Show();
            }

        }
        Formlar.FrmPersonel fr13;
        private void BtnPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13 == null || fr13.IsDisposed)
            {
                fr13 = new Formlar.FrmPersonel();
                fr13.MdiParent = this;
                fr13.Show();
            }
        }

        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        Formlar.FrmKurlar fr14;
        private void BtnDövizKurları_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr14 == null || fr14.IsDisposed)
            {
                fr14 = new Formlar.FrmKurlar();
                fr14.MdiParent = this;
                fr14.Show();
            }

        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }
        Formlar.FrmNotlar fr15;
        private void BtnNotListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr15 == null || fr15.IsDisposed)
            {
                fr15 = new Formlar.FrmNotlar();
                fr15.MdiParent = this;
                fr15.Show();
            }
        }
        Formlar.FrmYeniNot fr16;
        private void BtnYeniNot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr16 == null || fr16.IsDisposed)
            {
                fr16 = new Formlar.FrmYeniNot();
                fr16.Show();
            }
        }

        Formlar.FrmArızaListesi fr17;
        private void BtnArızalıÜrünListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr17 == null || fr17.IsDisposed)
            {
                fr17 = new Formlar.FrmArızaListesi();
                fr17.MdiParent = this;
                fr17.Show();
            }
        }

        Formlar.FrmÜrünSatis fr18;
        private void BtnYeniÜrünSatıs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr18 == null || fr18.IsDisposed)
            {
                fr18 = new Formlar.FrmÜrünSatis();
                fr18.Show();
            }

        }
        Formlar.FrmSatislar fr19;
        private void BtnSatışListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr19 == null || fr19.IsDisposed)
            {
                fr19 = new Formlar.FrmSatislar();
                fr19.MdiParent = this;
                fr19.Show();
            }

        }
        Formlar.FrmSatislar fr20;
        private void BtnCariHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr20 == null || fr20.IsDisposed)
            {
                fr20 = new Formlar.FrmSatislar();
                fr20.MdiParent = this;
                fr20.Show();
            }

        }
        Formlar.FrmArızalıÜrünKaydı fr21;
        private void BtnYeniArızalıÜrnKaydı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr21 == null || fr21.IsDisposed)
            {
                fr21 = new Formlar.FrmArızalıÜrünKaydı();
                fr21.Show();
            }

        }
        Formlar.FrmArizaDetaylar fr22;
        private void BtnArızalıÜrünAçıklama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr22 == null || fr22.IsDisposed)
            {
                fr22 = new Formlar.FrmArizaDetaylar();
                fr22.Show();
            }

        }
        Formlar.FrmArizaliÜrünDetayListesi fr23;
        private void BtnArızalıÜrünDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr23 == null || fr23.IsDisposed)
            {
                fr23 = new Formlar.FrmArizaliÜrünDetayListesi();
                fr23.MdiParent = this;
                fr23.Show();
            }

        }
        Formlar.FrmQRCode fr24;
        private void BtnQRCodeOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr24 == null || fr24.IsDisposed)
            {
                fr24 = new Formlar.FrmQRCode();
                fr24.Show();
            }
        }
        Formlar.FrmFaturaListesi fr25;
        private void BtnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr25 == null || fr25.IsDisposed)
            {
                fr25 = new Formlar.FrmFaturaListesi();
                fr25.MdiParent = this;
                fr25.Show();
            }

        }
        Formlar.FrmFaturaKalem fr26;
        private void BtnFaturaKalem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr26 == null || fr26.IsDisposed)
            {
                fr26 = new Formlar.FrmFaturaKalem();
                fr26.MdiParent = this;
                fr26.Show();
            }

        }
        Formlar.FrmFaturaKalemleri fr27;
        private void BtnDetaylıFaturaSorgulama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr27 == null || fr27.IsDisposed)
            {
                fr27 = new Formlar.FrmFaturaKalemleri();
                fr27.MdiParent = this;
                fr27.Show();
            }
        }
        Formlar.FrmHarita fr28;
        private void BtnHakkımızda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr28 == null || fr28.IsDisposed)
            {
                fr28 = new Formlar.FrmHarita();
                fr28.MdiParent = this;
                fr28.Show();
            }
        }
        Raporlar.FrmRapor fr29;
        private void BtnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr29 == null || fr29.IsDisposed)
            {
                fr29 = new Raporlar.FrmRapor();
                fr29.Show();
            }

        }

        Formlar.FrmAnaSayfa fr;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAnaSayfa();
                fr.MdiParent = this;
                fr.Show();
            }


        }

        private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAnaSayfa();
                fr.MdiParent = this;
                fr.Show();
            }

        }
        Formlar.FrmYardım fr32;
        private void BtnYardım_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr32 == null || fr32.IsDisposed)
            {
                fr32 = new Formlar.FrmYardım();
                fr32.MdiParent = this;
                fr32.Show();
            }
        }

        İletisim.FrmRehber fr33;
        private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr33 == null || fr33.IsDisposed)
            {
                fr33 = new İletisim.FrmRehber();
                fr33.MdiParent = this;
                fr33.Show();
            }
        }
        İletisim.FrmGelenMesajlar fr34;
        private void BtnMesajKutusu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr34 == null || fr34.IsDisposed)
            {
                fr34 = new İletisim.FrmGelenMesajlar();
                fr34.MdiParent = this;
                fr34.Show();
            }
        }

        İletisim.FrmMail fr35;
        private void BtnMail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr35 == null || fr35.IsDisposed)
            {
                fr35 = new İletisim.FrmMail();
                fr35.Show();
            }

        }
    }
}
