
namespace TeknikServis3.Formlar
{
    partial class FrmArızalıÜrünKaydı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArızalıÜrünKaydı));
            this.panel7 = new System.Windows.Forms.Panel();
            this.TxtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.TxtPersonel = new DevExpress.XtraEditors.TextEdit();
            this.BtnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtTarih = new DevExpress.XtraEditors.TextEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(60, 315);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(276, 4);
            this.panel7.TabIndex = 72;
            // 
            // TxtSeriNo
            // 
            this.TxtSeriNo.EditValue = "Seri NO";
            this.TxtSeriNo.Location = new System.Drawing.Point(63, 277);
            this.TxtSeriNo.Name = "TxtSeriNo";
            this.TxtSeriNo.Properties.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.TxtSeriNo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSeriNo.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.TxtSeriNo.Properties.Appearance.Options.UseBackColor = true;
            this.TxtSeriNo.Properties.Appearance.Options.UseFont = true;
            this.TxtSeriNo.Properties.Appearance.Options.UseForeColor = true;
            this.TxtSeriNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtSeriNo.Properties.Mask.EditMask = "AAAAA";
            this.TxtSeriNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtSeriNo.Size = new System.Drawing.Size(253, 32);
            this.TxtSeriNo.TabIndex = 4;
            this.TxtSeriNo.Click += new System.EventHandler(this.TxtSeriNo_Click);
            // 
            // TxtPersonel
            // 
            this.TxtPersonel.EditValue = "Personel";
            this.TxtPersonel.Enabled = false;
            this.TxtPersonel.Location = new System.Drawing.Point(60, 159);
            this.TxtPersonel.Name = "TxtPersonel";
            this.TxtPersonel.Properties.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.TxtPersonel.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonel.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.TxtPersonel.Properties.Appearance.Options.UseBackColor = true;
            this.TxtPersonel.Properties.Appearance.Options.UseFont = true;
            this.TxtPersonel.Properties.Appearance.Options.UseForeColor = true;
            this.TxtPersonel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtPersonel.Size = new System.Drawing.Size(107, 32);
            this.TxtPersonel.TabIndex = 75;
            // 
            // BtnVazgec
            // 
            this.BtnVazgec.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnVazgec.ImageOptions.SvgImage")));
            this.BtnVazgec.Location = new System.Drawing.Point(202, 351);
            this.BtnVazgec.Name = "BtnVazgec";
            this.BtnVazgec.Size = new System.Drawing.Size(114, 48);
            this.BtnVazgec.TabIndex = 74;
            this.BtnVazgec.Text = "VAZGEÇ";
            this.BtnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnKaydet.ImageOptions.SvgImage")));
            this.BtnKaydet.Location = new System.Drawing.Point(72, 351);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(114, 48);
            this.BtnKaydet.TabIndex = 73;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // textEdit6
            // 
            this.textEdit6.EditValue = "ARIZALI ÜRÜN";
            this.textEdit6.Enabled = false;
            this.textEdit6.Location = new System.Drawing.Point(101, 23);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.textEdit6.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit6.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.textEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit6.Properties.Appearance.Options.UseFont = true;
            this.textEdit6.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit6.Size = new System.Drawing.Size(235, 42);
            this.textEdit6.TabIndex = 70;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(60, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 4);
            this.panel3.TabIndex = 65;
            // 
            // TxtTarih
            // 
            this.TxtTarih.EditValue = "Tarih";
            this.TxtTarih.Location = new System.Drawing.Point(60, 218);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Properties.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.TxtTarih.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTarih.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.TxtTarih.Properties.Appearance.Options.UseBackColor = true;
            this.TxtTarih.Properties.Appearance.Options.UseFont = true;
            this.TxtTarih.Properties.Appearance.Options.UseForeColor = true;
            this.TxtTarih.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtTarih.Properties.Mask.EditMask = "d";
            this.TxtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.TxtTarih.Size = new System.Drawing.Size(253, 32);
            this.TxtTarih.TabIndex = 3;
            this.TxtTarih.Click += new System.EventHandler(this.TxtTarih_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(60, 197);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 4);
            this.panel4.TabIndex = 63;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(60, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 4);
            this.panel1.TabIndex = 60;
            // 
            // TxtID
            // 
            this.TxtID.EditValue = "Müşteri ID";
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(60, 99);
            this.TxtID.Name = "TxtID";
            this.TxtID.Properties.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.TxtID.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtID.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.TxtID.Properties.Appearance.Options.UseBackColor = true;
            this.TxtID.Properties.Appearance.Options.UseFont = true;
            this.TxtID.Properties.Appearance.Options.UseForeColor = true;
            this.TxtID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtID.Size = new System.Drawing.Size(125, 32);
            this.TxtID.TabIndex = 59;
            this.TxtID.EditValueChanged += new System.EventHandler(this.TxtID_EditValueChanged);
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.EditValue = "Deger Seçin";
            this.lookUpEdit2.Location = new System.Drawing.Point(178, 107);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.lookUpEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lookUpEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.DisplayMember = "AD";
            this.lookUpEdit2.Properties.NullText = "";
            this.lookUpEdit2.Properties.ValueMember = "ID";
            this.lookUpEdit2.Size = new System.Drawing.Size(158, 22);
            this.lookUpEdit2.TabIndex = 1;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.EditValue = "Deger Seçin";
            this.lookUpEdit1.Location = new System.Drawing.Point(178, 168);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.lookUpEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lookUpEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DisplayMember = "AD";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.ValueMember = "ID";
            this.lookUpEdit1.Size = new System.Drawing.Size(158, 22);
            this.lookUpEdit1.TabIndex = 2;
            // 
            // FrmArızalıÜrünKaydı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(400, 439);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.lookUpEdit2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.TxtSeriNo);
            this.Controls.Add(this.TxtPersonel);
            this.Controls.Add(this.BtnVazgec);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.textEdit6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TxtTarih);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArızalıÜrünKaydı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arızalı Ürün Kaydı";
            this.Load += new System.EventHandler(this.FrmArızalıÜrünKaydı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.TextEdit TxtSeriNo;
        private DevExpress.XtraEditors.TextEdit TxtPersonel;
        private DevExpress.XtraEditors.SimpleButton BtnVazgec;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TextEdit TxtTarih;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}