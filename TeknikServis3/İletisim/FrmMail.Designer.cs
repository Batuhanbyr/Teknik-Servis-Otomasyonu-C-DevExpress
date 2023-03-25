
namespace TeknikServis3.İletisim
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.BtnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtKonu = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtAlıcı = new DevExpress.XtraEditors.TextEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtIcerik = new System.Windows.Forms.RichTextBox();
            this.BtnVazgec = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKonu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlıcı.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGonder
            // 
            this.BtnGonder.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.BtnGonder.Appearance.Options.UseForeColor = true;
            this.BtnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGonder.ImageOptions.Image")));
            this.BtnGonder.Location = new System.Drawing.Point(153, 461);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(94, 29);
            this.BtnGonder.TabIndex = 2;
            this.BtnGonder.Text = "GÖNDER";
            this.BtnGonder.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Enabled = false;
            this.labelControl1.Location = new System.Drawing.Point(112, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(293, 41);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mail Gönderme Paneli";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(39, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 5);
            this.panel2.TabIndex = 3;
            // 
            // TxtKonu
            // 
            this.TxtKonu.EditValue = "KONU";
            this.TxtKonu.Enabled = false;
            this.TxtKonu.Location = new System.Drawing.Point(39, 143);
            this.TxtKonu.Name = "TxtKonu";
            this.TxtKonu.Properties.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.TxtKonu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKonu.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.TxtKonu.Properties.Appearance.Options.UseBackColor = true;
            this.TxtKonu.Properties.Appearance.Options.UseFont = true;
            this.TxtKonu.Properties.Appearance.Options.UseForeColor = true;
            this.TxtKonu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtKonu.Size = new System.Drawing.Size(433, 28);
            this.TxtKonu.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(39, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 5);
            this.panel1.TabIndex = 5;
            // 
            // TxtAlıcı
            // 
            this.TxtAlıcı.EditValue = "ALICI";
            this.TxtAlıcı.Location = new System.Drawing.Point(39, 96);
            this.TxtAlıcı.Name = "TxtAlıcı";
            this.TxtAlıcı.Properties.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.TxtAlıcı.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAlıcı.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.TxtAlıcı.Properties.Appearance.Options.UseBackColor = true;
            this.TxtAlıcı.Properties.Appearance.Options.UseFont = true;
            this.TxtAlıcı.Properties.Appearance.Options.UseForeColor = true;
            this.TxtAlıcı.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtAlıcı.Size = new System.Drawing.Size(433, 28);
            this.TxtAlıcı.TabIndex = 4;
            this.TxtAlıcı.Click += new System.EventHandler(this.TxtAlıcı_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(39, 424);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 5);
            this.panel3.TabIndex = 5;
            // 
            // TxtIcerik
            // 
            this.TxtIcerik.BackColor = System.Drawing.Color.LightGray;
            this.TxtIcerik.ForeColor = System.Drawing.Color.DimGray;
            this.TxtIcerik.Location = new System.Drawing.Point(39, 190);
            this.TxtIcerik.Name = "TxtIcerik";
            this.TxtIcerik.Size = new System.Drawing.Size(433, 228);
            this.TxtIcerik.TabIndex = 6;
            this.TxtIcerik.Text = "";
            // 
            // BtnVazgec
            // 
            this.BtnVazgec.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.BtnVazgec.Appearance.Options.UseForeColor = true;
            this.BtnVazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnVazgec.ImageOptions.Image")));
            this.BtnVazgec.Location = new System.Drawing.Point(253, 461);
            this.BtnVazgec.Name = "BtnVazgec";
            this.BtnVazgec.Size = new System.Drawing.Size(94, 29);
            this.BtnVazgec.TabIndex = 7;
            this.BtnVazgec.Text = "VAZGEÇ";
            this.BtnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(517, 528);
            this.Controls.Add(this.BtnVazgec);
            this.Controls.Add(this.TxtIcerik);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtAlıcı);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtKonu);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BtnGonder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.FrmMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtKonu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlıcı.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnGonder;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit TxtKonu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit TxtAlıcı;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox TxtIcerik;
        private DevExpress.XtraEditors.SimpleButton BtnVazgec;
    }
}