
namespace TeknikServis3.Formlar
{
    partial class FrmCariListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCariListesi));
            this.TxtId = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtBanka = new System.Windows.Forms.TextBox();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.TxtTel = new DevExpress.XtraEditors.TextEdit();
            this.TxtAdres = new System.Windows.Forms.TextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.TxtStatu = new System.Windows.Forms.TextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.TxtVno = new System.Windows.Forms.TextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TxtVDairesi = new System.Windows.Forms.TextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTel.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(117, 75);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(193, 23);
            this.TxtId.TabIndex = 21;
            // 
            // labelControl7
            // 
            this.labelControl7.Enabled = false;
            this.labelControl7.Location = new System.Drawing.Point(59, 78);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 16);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "Cari ID : ";
            // 
            // BtnListele
            // 
            this.BtnListele.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnListele.ImageOptions.SvgImage")));
            this.BtnListele.Location = new System.Drawing.Point(55, 581);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(290, 50);
            this.BtnListele.TabIndex = 19;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSil.ImageOptions.SvgImage")));
            this.BtnSil.Location = new System.Drawing.Point(49, 469);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(290, 50);
            this.BtnSil.TabIndex = 18;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnGuncelle.ImageOptions.SvgImage")));
            this.BtnGuncelle.Location = new System.Drawing.Point(49, 525);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(290, 50);
            this.BtnGuncelle.TabIndex = 17;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnKaydet.ImageOptions.SvgImage")));
            this.BtnKaydet.Location = new System.Drawing.Point(49, 413);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(290, 50);
            this.BtnKaydet.TabIndex = 16;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Enabled = false;
            this.labelControl5.Location = new System.Drawing.Point(64, 252);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 16);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Banka : ";
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(117, 220);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.DisplayMember = "ilce";
            this.lookUpEdit2.Properties.NullText = "";
            this.lookUpEdit2.Properties.ValueMember = "id";
            this.lookUpEdit2.Size = new System.Drawing.Size(193, 22);
            this.lookUpEdit2.TabIndex = 14;
            this.lookUpEdit2.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Enabled = false;
            this.labelControl6.Location = new System.Drawing.Point(78, 223);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(33, 16);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "İlçe : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Enabled = false;
            this.labelControl3.Location = new System.Drawing.Point(91, 198);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 16);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "İl : ";
            // 
            // labelControl4
            // 
            this.labelControl4.Enabled = false;
            this.labelControl4.Location = new System.Drawing.Point(55, 165);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Telefon : ";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(117, 133);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(193, 23);
            this.TxtSoyad.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Enabled = false;
            this.labelControl2.Location = new System.Drawing.Point(60, 136);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Soyadı : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Enabled = false;
            this.labelControl1.Location = new System.Drawing.Point(80, 107);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Adı : ";
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
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 213);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1668, 538);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(117, 104);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(193, 23);
            this.TxtAd.TabIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtBanka);
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.TxtTel);
            this.groupControl1.Controls.Add(this.TxtAdres);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.TxtStatu);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.TxtVno);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.TxtVDairesi);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.TxtId);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.BtnListele);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.lookUpEdit2);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.TxtSoyad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TxtAd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1675, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(363, 750);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Cari Listesi";
            // 
            // TxtBanka
            // 
            this.TxtBanka.Location = new System.Drawing.Point(117, 247);
            this.TxtBanka.Name = "TxtBanka";
            this.TxtBanka.Size = new System.Drawing.Size(193, 23);
            this.TxtBanka.TabIndex = 32;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(117, 192);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DisplayMember = "sehir";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.ValueMember = "id";
            this.lookUpEdit1.Size = new System.Drawing.Size(193, 22);
            this.lookUpEdit1.TabIndex = 31;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged_1);
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(117, 162);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Properties.Mask.EditMask = "(999) 000-0000";
            this.TxtTel.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtTel.Size = new System.Drawing.Size(193, 22);
            this.TxtTel.TabIndex = 30;
            this.TxtTel.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(117, 364);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(193, 23);
            this.TxtAdres.TabIndex = 29;
            // 
            // labelControl10
            // 
            this.labelControl10.Enabled = false;
            this.labelControl10.Location = new System.Drawing.Point(65, 367);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(46, 16);
            this.labelControl10.TabIndex = 28;
            this.labelControl10.Text = "Adres : ";
            // 
            // TxtStatu
            // 
            this.TxtStatu.Location = new System.Drawing.Point(117, 335);
            this.TxtStatu.Name = "TxtStatu";
            this.TxtStatu.Size = new System.Drawing.Size(193, 23);
            this.TxtStatu.TabIndex = 27;
            // 
            // labelControl11
            // 
            this.labelControl11.Enabled = false;
            this.labelControl11.Location = new System.Drawing.Point(65, 338);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(43, 16);
            this.labelControl11.TabIndex = 26;
            this.labelControl11.Text = "Statu : ";
            // 
            // TxtVno
            // 
            this.TxtVno.Location = new System.Drawing.Point(117, 306);
            this.TxtVno.Name = "TxtVno";
            this.TxtVno.Size = new System.Drawing.Size(193, 23);
            this.TxtVno.TabIndex = 25;
            // 
            // labelControl8
            // 
            this.labelControl8.Enabled = false;
            this.labelControl8.Location = new System.Drawing.Point(49, 309);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(62, 16);
            this.labelControl8.TabIndex = 24;
            this.labelControl8.Text = "Vergi No : ";
            // 
            // TxtVDairesi
            // 
            this.TxtVDairesi.Location = new System.Drawing.Point(117, 277);
            this.TxtVDairesi.Name = "TxtVDairesi";
            this.TxtVDairesi.Size = new System.Drawing.Size(193, 23);
            this.TxtVDairesi.TabIndex = 23;
            // 
            // labelControl9
            // 
            this.labelControl9.Enabled = false;
            this.labelControl9.Location = new System.Drawing.Point(43, 280);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(68, 16);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "V. Dairesi : ";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Location = new System.Drawing.Point(21, 27);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(164, 28);
            this.labelControl13.TabIndex = 0;
            this.labelControl13.Text = "Toplam Cari Sayısı";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(21, 102);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(57, 45);
            this.labelControl12.TabIndex = 1;
            this.labelControl12.Text = "564";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(159)))), ((int)(((byte)(132)))));
            this.panel2.Controls.Add(this.labelControl12);
            this.panel2.Controls.Add(this.labelControl13);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 206);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(201)))), ((int)(((byte)(115)))));
            this.panel3.Controls.Add(this.labelControl16);
            this.panel3.Controls.Add(this.labelControl17);
            this.panel3.Location = new System.Drawing.Point(557, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 206);
            this.panel3.TabIndex = 12;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl16.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Appearance.Options.UseForeColor = true;
            this.labelControl16.Location = new System.Drawing.Point(21, 102);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(57, 45);
            this.labelControl16.TabIndex = 1;
            this.labelControl16.Text = "564";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl17.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Appearance.Options.UseForeColor = true;
            this.labelControl17.Location = new System.Drawing.Point(21, 27);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(141, 28);
            this.labelControl17.TabIndex = 0;
            this.labelControl17.Text = "Toplam İl Sayısı";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(217)))), ((int)(((byte)(62)))));
            this.panel4.Controls.Add(this.labelControl18);
            this.panel4.Controls.Add(this.labelControl19);
            this.panel4.Location = new System.Drawing.Point(1126, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(543, 206);
            this.panel4.TabIndex = 13;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl18.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Appearance.Options.UseForeColor = true;
            this.labelControl18.Location = new System.Drawing.Point(21, 102);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(57, 45);
            this.labelControl18.TabIndex = 1;
            this.labelControl18.Text = "564";
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl19.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Appearance.Options.UseForeColor = true;
            this.labelControl19.Location = new System.Drawing.Point(21, 27);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(161, 28);
            this.labelControl19.TabIndex = 0;
            this.labelControl19.Text = "Toplam İlçe Sayısı";
            // 
            // FrmCariListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 753);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmCariListesi";
            this.Text = "Cari Listesi";
            this.Load += new System.EventHandler(this.FrmCariListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTel.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtId;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox TxtSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.TextBox TxtAd;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.TextEdit TxtTel;
        private System.Windows.Forms.TextBox TxtAdres;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.TextBox TxtStatu;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.TextBox TxtVno;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.TextBox TxtVDairesi;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.TextBox TxtBanka;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl19;
    }
}