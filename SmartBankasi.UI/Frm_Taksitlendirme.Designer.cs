namespace SmartBankasi.UI
{
    partial class frm_Taksitlendirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Taksitlendirme));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_musterituru = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.mtb_tc = new System.Windows.Forms.MaskedTextBox();
            this.txt_Adi = new DevExpress.XtraEditors.TextEdit();
            this.txt_soyadi = new DevExpress.XtraEditors.TextEdit();
            this.txt_kredimiktari = new DevExpress.XtraEditors.TextEdit();
            this.txt_taksitsayisi = new DevExpress.XtraEditors.TextEdit();
            this.btn_taksitolustur = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date_taksitbaslama = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kredimiktari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_taksitsayisi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Location = new System.Drawing.Point(279, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(608, 483);
            this.panelControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.date_taksitbaslama);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.cmb_musterituru);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.mtb_tc);
            this.groupBox1.Controls.Add(this.txt_Adi);
            this.groupBox1.Controls.Add(this.txt_soyadi);
            this.groupBox1.Controls.Add(this.txt_kredimiktari);
            this.groupBox1.Controls.Add(this.txt_taksitsayisi);
            this.groupBox1.Controls.Add(this.btn_taksitolustur);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(-3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 473);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MÜŞTERİ BİLGİLERİ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(195, 94);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(72, 23);
            this.simpleButton1.TabIndex = 19;
            this.simpleButton1.Text = "GETİR";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmb_musterituru
            // 
            this.cmb_musterituru.FormattingEnabled = true;
            this.cmb_musterituru.Location = new System.Drawing.Point(103, 61);
            this.cmb_musterituru.Name = "cmb_musterituru";
            this.cmb_musterituru.Size = new System.Drawing.Size(162, 21);
            this.cmb_musterituru.TabIndex = 18;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonKaydet,
            this.toolStripButtonGuncelle,
            this.toolStripButtonSil});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(276, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonKaydet
            // 
            this.toolStripButtonKaydet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonKaydet.Image")));
            this.toolStripButtonKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonKaydet.Name = "toolStripButtonKaydet";
            this.toolStripButtonKaydet.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonKaydet.Text = "Kaydet";
            this.toolStripButtonKaydet.Click += new System.EventHandler(this.toolStripButtonKaydet_Click);
            // 
            // toolStripButtonGuncelle
            // 
            this.toolStripButtonGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuncelle.Image")));
            this.toolStripButtonGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuncelle.Name = "toolStripButtonGuncelle";
            this.toolStripButtonGuncelle.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonGuncelle.Text = "Güncelle";
            // 
            // toolStripButtonSil
            // 
            this.toolStripButtonSil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSil.Image")));
            this.toolStripButtonSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSil.Name = "toolStripButtonSil";
            this.toolStripButtonSil.Size = new System.Drawing.Size(39, 22);
            this.toolStripButtonSil.Text = "Sil";
            // 
            // mtb_tc
            // 
            this.mtb_tc.Location = new System.Drawing.Point(103, 96);
            this.mtb_tc.Mask = "000000000000";
            this.mtb_tc.Name = "mtb_tc";
            this.mtb_tc.Size = new System.Drawing.Size(86, 20);
            this.mtb_tc.TabIndex = 14;
            // 
            // txt_Adi
            // 
            this.txt_Adi.Location = new System.Drawing.Point(103, 127);
            this.txt_Adi.Name = "txt_Adi";
            this.txt_Adi.Size = new System.Drawing.Size(162, 20);
            this.txt_Adi.TabIndex = 13;
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Location = new System.Drawing.Point(103, 154);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Size = new System.Drawing.Size(162, 20);
            this.txt_soyadi.TabIndex = 13;
            // 
            // txt_kredimiktari
            // 
            this.txt_kredimiktari.Location = new System.Drawing.Point(103, 219);
            this.txt_kredimiktari.Name = "txt_kredimiktari";
            this.txt_kredimiktari.Size = new System.Drawing.Size(162, 20);
            this.txt_kredimiktari.TabIndex = 13;
            // 
            // txt_taksitsayisi
            // 
            this.txt_taksitsayisi.Location = new System.Drawing.Point(103, 188);
            this.txt_taksitsayisi.Name = "txt_taksitsayisi";
            this.txt_taksitsayisi.Size = new System.Drawing.Size(162, 20);
            this.txt_taksitsayisi.TabIndex = 13;
            // 
            // btn_taksitolustur
            // 
            this.btn_taksitolustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_taksitolustur.ImageOptions.Image")));
            this.btn_taksitolustur.Location = new System.Drawing.Point(103, 308);
            this.btn_taksitolustur.Name = "btn_taksitolustur";
            this.btn_taksitolustur.Size = new System.Drawing.Size(162, 71);
            this.btn_taksitolustur.TabIndex = 12;
            this.btn_taksitolustur.Text = "TAKSİT OLUŞTUR";
            this.btn_taksitolustur.Click += new System.EventHandler(this.btn_taksitolustur_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Müşteri Türü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Taksit Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kredi Miktarı:";
            // 
            // date_taksitbaslama
            // 
            this.date_taksitbaslama.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_taksitbaslama.Location = new System.Drawing.Point(103, 259);
            this.date_taksitbaslama.Name = "date_taksitbaslama";
            this.date_taksitbaslama.Size = new System.Drawing.Size(162, 20);
            this.date_taksitbaslama.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 26);
            this.label7.TabIndex = 21;
            this.label7.Text = "Taksit Başlama \r\n               Tarihi:";
            // 
            // frm_Taksitlendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_Taksitlendirme";
            this.Text = "Taksitlendirme";
            this.Load += new System.EventHandler(this.frm_Taksitlendirme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kredimiktari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_taksitsayisi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_taksitolustur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_taksitsayisi;
        private DevExpress.XtraEditors.TextEdit txt_Adi;
        private DevExpress.XtraEditors.TextEdit txt_soyadi;
        private DevExpress.XtraEditors.TextEdit txt_kredimiktari;
        private System.Windows.Forms.MaskedTextBox mtb_tc;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox cmb_musterituru;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date_taksitbaslama;
    }
}