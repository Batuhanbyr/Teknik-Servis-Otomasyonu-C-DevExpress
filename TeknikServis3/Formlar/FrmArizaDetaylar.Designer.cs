
namespace TeknikServis3.Formlar
{
    partial class FrmArizaDetaylar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArizaDetaylar));
            this.BtnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtArizaDetay = new System.Windows.Forms.RichTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSeriNO = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTarih = new DevExpress.XtraEditors.TextEdit();
            this.BtnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnGüncelle.ImageOptions.SvgImage")));
            this.BtnGüncelle.Location = new System.Drawing.Point(162, 439);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(143, 48);
            this.BtnGüncelle.TabIndex = 74;
            this.BtnGüncelle.Text = "GÜNCELLE";
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Enabled = false;
            this.labelControl1.Location = new System.Drawing.Point(183, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(247, 28);
            this.labelControl1.TabIndex = 75;
            this.labelControl1.Text = "Arızalı Ürün Kaydı Açıklama";
            // 
            // TxtArizaDetay
            // 
            this.TxtArizaDetay.BackColor = System.Drawing.Color.LightGray;
            this.TxtArizaDetay.ForeColor = System.Drawing.Color.DimGray;
            this.TxtArizaDetay.Location = new System.Drawing.Point(183, 255);
            this.TxtArizaDetay.Name = "TxtArizaDetay";
            this.TxtArizaDetay.Size = new System.Drawing.Size(352, 158);
            this.TxtArizaDetay.TabIndex = 3;
            this.TxtArizaDetay.Text = "";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Enabled = false;
            this.labelControl2.Location = new System.Drawing.Point(96, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 23);
            this.labelControl2.TabIndex = 77;
            this.labelControl2.Text = "Seri NO :";
            // 
            // TxtSeriNO
            // 
            this.TxtSeriNO.Location = new System.Drawing.Point(183, 73);
            this.TxtSeriNO.Name = "TxtSeriNO";
            this.TxtSeriNO.Properties.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.TxtSeriNO.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.TxtSeriNO.Properties.Appearance.Options.UseBackColor = true;
            this.TxtSeriNO.Properties.Appearance.Options.UseForeColor = true;
            this.TxtSeriNO.Properties.Mask.EditMask = "AAAAA";
            this.TxtSeriNO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtSeriNO.Size = new System.Drawing.Size(247, 22);
            this.TxtSeriNO.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Enabled = false;
            this.labelControl3.Location = new System.Drawing.Point(117, 123);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 23);
            this.labelControl3.TabIndex = 79;
            this.labelControl3.Text = "Tarih :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Enabled = false;
            this.labelControl4.Location = new System.Drawing.Point(47, 253);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(119, 23);
            this.labelControl4.TabIndex = 80;
            this.labelControl4.Text = "Arıza Detayları :";
            // 
            // TxtTarih
            // 
            this.TxtTarih.Location = new System.Drawing.Point(183, 124);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Properties.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.TxtTarih.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.TxtTarih.Properties.Appearance.Options.UseBackColor = true;
            this.TxtTarih.Properties.Appearance.Options.UseForeColor = true;
            this.TxtTarih.Properties.Mask.EditMask = "d";
            this.TxtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.TxtTarih.Size = new System.Drawing.Size(247, 22);
            this.TxtTarih.TabIndex = 2;
            this.TxtTarih.Click += new System.EventHandler(this.TxtTarih_Click);
            // 
            // BtnVazgec
            // 
            this.BtnVazgec.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnVazgec.ImageOptions.SvgImage")));
            this.BtnVazgec.Location = new System.Drawing.Point(311, 439);
            this.BtnVazgec.Name = "BtnVazgec";
            this.BtnVazgec.Size = new System.Drawing.Size(143, 48);
            this.BtnVazgec.TabIndex = 82;
            this.BtnVazgec.Text = "VAZGEÇ";
            this.BtnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightGray;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ürün Kaydoldu",
            "Parça Bekliyor",
            "Mesaj Bekliyor",
            "İptal Edildi",
            "Fiyat Verildi"});
            this.comboBox1.Location = new System.Drawing.Point(183, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 24);
            this.comboBox1.TabIndex = 83;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Enabled = false;
            this.labelControl5.Location = new System.Drawing.Point(10, 178);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(154, 23);
            this.labelControl5.TabIndex = 84;
            this.labelControl5.Text = "Ürün Durum Detay :";
            // 
            // FrmArizaDetaylar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(593, 520);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnVazgec);
            this.Controls.Add(this.TxtTarih);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TxtSeriNO);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtArizaDetay);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BtnGüncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArizaDetaylar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arıza Detaylar";
            this.Load += new System.EventHandler(this.FrmArizaDetaylar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnGüncelle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox TxtArizaDetay;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtSeriNO;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtTarih;
        private DevExpress.XtraEditors.SimpleButton BtnVazgec;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}