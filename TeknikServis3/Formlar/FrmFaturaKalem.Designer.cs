
namespace TeknikServis3.Formlar
{
    partial class FrmFaturaKalem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaKalem));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtFaturaID = new DevExpress.XtraEditors.TextEdit();
            this.TxtTutar = new DevExpress.XtraEditors.TextEdit();
            this.TxtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.TxtAdet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtÜrün = new DevExpress.XtraEditors.TextEdit();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtÜrün.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1668, 749);
            this.gridControl1.TabIndex = 22;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.SystemColors.ButtonFace;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.TxtFaturaID);
            this.groupControl1.Controls.Add(this.TxtTutar);
            this.groupControl1.Controls.Add(this.TxtFiyat);
            this.groupControl1.Controls.Add(this.TxtAdet);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtÜrün);
            this.groupControl1.Controls.Add(this.TxtId);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.BtnListele);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1676, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(410, 749);
            this.groupControl1.TabIndex = 23;
            this.groupControl1.Text = "Fatura Kalem İşlemleri";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // TxtFaturaID
            // 
            this.TxtFaturaID.Location = new System.Drawing.Point(104, 292);
            this.TxtFaturaID.Name = "TxtFaturaID";
            this.TxtFaturaID.Size = new System.Drawing.Size(232, 22);
            this.TxtFaturaID.TabIndex = 34;
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(104, 264);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(232, 22);
            this.TxtTutar.TabIndex = 33;
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(104, 233);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(232, 22);
            this.TxtFiyat.TabIndex = 32;
            // 
            // TxtAdet
            // 
            this.TxtAdet.Location = new System.Drawing.Point(105, 205);
            this.TxtAdet.Name = "TxtAdet";
            this.TxtAdet.Size = new System.Drawing.Size(232, 22);
            this.TxtAdet.TabIndex = 31;
            // 
            // labelControl2
            // 
            this.labelControl2.Enabled = false;
            this.labelControl2.Location = new System.Drawing.Point(55, 208);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 16);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Adet : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Enabled = false;
            this.labelControl5.Location = new System.Drawing.Point(28, 292);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 16);
            this.labelControl5.TabIndex = 28;
            this.labelControl5.Text = "Fatura ID : ";
            // 
            // labelControl4
            // 
            this.labelControl4.Enabled = false;
            this.labelControl4.Location = new System.Drawing.Point(50, 264);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 16);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Tutar : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Enabled = false;
            this.labelControl3.Location = new System.Drawing.Point(54, 236);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 16);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Fiyat : ";
            // 
            // TxtÜrün
            // 
            this.TxtÜrün.Location = new System.Drawing.Point(105, 174);
            this.TxtÜrün.Name = "TxtÜrün";
            this.TxtÜrün.Size = new System.Drawing.Size(232, 22);
            this.TxtÜrün.TabIndex = 23;
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(104, 142);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(233, 23);
            this.TxtId.TabIndex = 21;
            // 
            // labelControl7
            // 
            this.labelControl7.Enabled = false;
            this.labelControl7.Location = new System.Drawing.Point(33, 149);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(61, 16);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "Detay ID : ";
            // 
            // BtnListele
            // 
            this.BtnListele.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnListele.ImageOptions.SvgImage")));
            this.BtnListele.Location = new System.Drawing.Point(50, 542);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(290, 50);
            this.BtnListele.TabIndex = 19;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSil.ImageOptions.SvgImage")));
            this.BtnSil.Location = new System.Drawing.Point(50, 430);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(290, 50);
            this.BtnSil.TabIndex = 18;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnGuncelle.ImageOptions.SvgImage")));
            this.BtnGuncelle.Location = new System.Drawing.Point(50, 486);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(290, 50);
            this.BtnGuncelle.TabIndex = 17;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnKaydet.ImageOptions.SvgImage")));
            this.BtnKaydet.Location = new System.Drawing.Point(50, 374);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(290, 50);
            this.BtnKaydet.TabIndex = 16;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Enabled = false;
            this.labelControl1.Location = new System.Drawing.Point(54, 180);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Ürün : ";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // FrmFaturaKalem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 753);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmFaturaKalem";
            this.Text = "Fatura Kalem";
            this.Load += new System.EventHandler(this.FrmFaturaKalem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtÜrün.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtÜrün;
        private System.Windows.Forms.TextBox TxtId;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtAdet;
        private DevExpress.XtraEditors.TextEdit TxtFaturaID;
        private DevExpress.XtraEditors.TextEdit TxtTutar;
        private DevExpress.XtraEditors.TextEdit TxtFiyat;
    }
}