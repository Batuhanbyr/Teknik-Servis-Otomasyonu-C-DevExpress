
namespace TeknikServis3.Formlar
{
    partial class FrmYeniKategori
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniKategori));
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.BtnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit6
            // 
            this.textEdit6.EditValue = "YENİ KATEGORİ";
            this.textEdit6.Enabled = false;
            this.textEdit6.Location = new System.Drawing.Point(112, 12);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.textEdit6.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit6.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.textEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit6.Properties.Appearance.Options.UseFont = true;
            this.textEdit6.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit6.Size = new System.Drawing.Size(301, 42);
            this.textEdit6.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(47, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 4);
            this.panel1.TabIndex = 14;
            // 
            // TxtAd
            // 
            this.TxtAd.EditValue = "Kategori Adı";
            this.TxtAd.Location = new System.Drawing.Point(70, 88);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Properties.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.TxtAd.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.TxtAd.Properties.Appearance.Options.UseBackColor = true;
            this.TxtAd.Properties.Appearance.Options.UseFont = true;
            this.TxtAd.Properties.Appearance.Options.UseForeColor = true;
            this.TxtAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtAd.Size = new System.Drawing.Size(176, 32);
            this.TxtAd.TabIndex = 1;
            this.TxtAd.Click += new System.EventHandler(this.TxtAd_Click);
            // 
            // BtnVazgec
            // 
            this.BtnVazgec.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnVazgec.ImageOptions.SvgImage")));
            this.BtnVazgec.Location = new System.Drawing.Point(227, 163);
            this.BtnVazgec.Name = "BtnVazgec";
            this.BtnVazgec.Size = new System.Drawing.Size(165, 48);
            this.BtnVazgec.TabIndex = 17;
            this.BtnVazgec.Text = "VAZGEÇ";
            this.BtnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnKaydet.ImageOptions.SvgImage")));
            this.BtnKaydet.Location = new System.Drawing.Point(47, 163);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(165, 48);
            this.BtnKaydet.TabIndex = 16;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // FrmYeniKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(425, 254);
            this.Controls.Add(this.BtnVazgec);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.textEdit6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmYeniKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kategori";
            this.Load += new System.EventHandler(this.FrmYeniKategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit6;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.SimpleButton BtnVazgec;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
    }
}