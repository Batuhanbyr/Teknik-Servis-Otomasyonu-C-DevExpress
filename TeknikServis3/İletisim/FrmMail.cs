using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TeknikServis3.İletisim
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            string frommail = "gönderici";
            string şifre = "şifreniz";
            string alici = TxtAlıcı.Text;
            string konu = TxtKonu.Text;
            string icerik = TxtIcerik.Text;

            mail.From = (new MailAddress(frommail));
            mail.To.Add(alici);
            mail.Subject = konu;
            mail.Body = icerik;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
            smtp.Credentials = new NetworkCredential(frommail, şifre);
            smtp.EnableSsl = true;
            smtp.Send(mail);

            MessageBox.Show("Mail Başarıyla Gönderildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FrmMail_Load(object sender, EventArgs e)
        {

        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtAlıcı_Click(object sender, EventArgs e)
        {
            TxtAlıcı.Text = "";
            TxtAlıcı.Focus();
        }
    }
}
