namespace SmartBankasi.UI
{
    partial class Frm_BireyselMusteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BireyselMusteriler));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_maas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_aylikkazanc = new System.Windows.Forms.TextBox();
            this.txt_meslek = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.date_dogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.cmb_medenihali = new System.Windows.Forms.ComboBox();
            this.cmb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.cmb_dogumyeri = new System.Windows.Forms.ComboBox();
            this.mtb_TC = new System.Windows.Forms.MaskedTextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_MusteriSoyAdi = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_MusteriAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.mtb_hesapno = new System.Windows.Forms.MaskedTextBox();
            this.mtb_iban = new System.Windows.Forms.MaskedTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripBireyselUrunKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripBireyselUrunGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripBireyselUrunSil = new System.Windows.Forms.ToolStripButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textBoxTCyeGoreAra = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBoxAdinaGoreAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(763, 477);
            this.xtraTabControl1.TabIndex = 8;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.xtraTabPage1.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.textBoxTCyeGoreAra);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.textBoxAdinaGoreAra);
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(757, 430);
            this.xtraTabPage1.Text = "Bireysel Müşteri Bilgileri";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.txt_adres);
            this.groupControl1.Controls.Add(this.txt_maas);
            this.groupControl1.Controls.Add(this.label12);
            this.groupControl1.Controls.Add(this.label13);
            this.groupControl1.Controls.Add(this.txt_aylikkazanc);
            this.groupControl1.Controls.Add(this.txt_meslek);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.date_dogumtarihi);
            this.groupControl1.Controls.Add(this.cmb_medenihali);
            this.groupControl1.Controls.Add(this.cmb_cinsiyet);
            this.groupControl1.Controls.Add(this.cmb_dogumyeri);
            this.groupControl1.Controls.Add(this.mtb_TC);
            this.groupControl1.Controls.Add(this.txt_telefon);
            this.groupControl1.Controls.Add(this.txt_MusteriSoyAdi);
            this.groupControl1.Controls.Add(this.txt_email);
            this.groupControl1.Controls.Add(this.txt_MusteriAdi);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.toolStrip1);
            this.groupControl1.Location = new System.Drawing.Point(456, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(302, 430);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Bireysel Müşteri Bilgileri";
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(159, 351);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(129, 72);
            this.txt_adres.TabIndex = 28;
            // 
            // txt_maas
            // 
            this.txt_maas.Location = new System.Drawing.Point(159, 299);
            this.txt_maas.Name = "txt_maas";
            this.txt_maas.Size = new System.Drawing.Size(129, 21);
            this.txt_maas.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(159, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "ADRES:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(159, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "MAAŞ:";
            // 
            // txt_aylikkazanc
            // 
            this.txt_aylikkazanc.Location = new System.Drawing.Point(159, 248);
            this.txt_aylikkazanc.Name = "txt_aylikkazanc";
            this.txt_aylikkazanc.Size = new System.Drawing.Size(129, 21);
            this.txt_aylikkazanc.TabIndex = 24;
            // 
            // txt_meslek
            // 
            this.txt_meslek.Location = new System.Drawing.Point(159, 191);
            this.txt_meslek.Name = "txt_meslek";
            this.txt_meslek.Size = new System.Drawing.Size(129, 21);
            this.txt_meslek.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(159, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "AYLIK KAZANÇ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(159, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "MESLEK:";
            // 
            // date_dogumtarihi
            // 
            this.date_dogumtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_dogumtarihi.Location = new System.Drawing.Point(5, 402);
            this.date_dogumtarihi.Name = "date_dogumtarihi";
            this.date_dogumtarihi.Size = new System.Drawing.Size(129, 21);
            this.date_dogumtarihi.TabIndex = 20;
            // 
            // cmb_medenihali
            // 
            this.cmb_medenihali.FormattingEnabled = true;
            this.cmb_medenihali.Items.AddRange(new object[] {
            "BEKAR",
            "EVLİ"});
            this.cmb_medenihali.Location = new System.Drawing.Point(5, 300);
            this.cmb_medenihali.Name = "cmb_medenihali";
            this.cmb_medenihali.Size = new System.Drawing.Size(129, 21);
            this.cmb_medenihali.TabIndex = 17;
            // 
            // cmb_cinsiyet
            // 
            this.cmb_cinsiyet.FormattingEnabled = true;
            this.cmb_cinsiyet.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.cmb_cinsiyet.Location = new System.Drawing.Point(5, 247);
            this.cmb_cinsiyet.Name = "cmb_cinsiyet";
            this.cmb_cinsiyet.Size = new System.Drawing.Size(129, 21);
            this.cmb_cinsiyet.TabIndex = 17;
            // 
            // cmb_dogumyeri
            // 
            this.cmb_dogumyeri.FormattingEnabled = true;
            this.cmb_dogumyeri.Location = new System.Drawing.Point(5, 354);
            this.cmb_dogumyeri.Name = "cmb_dogumyeri";
            this.cmb_dogumyeri.Size = new System.Drawing.Size(129, 21);
            this.cmb_dogumyeri.TabIndex = 16;
            // 
            // mtb_TC
            // 
            this.mtb_TC.Location = new System.Drawing.Point(5, 80);
            this.mtb_TC.Mask = "00000000000";
            this.mtb_TC.Name = "mtb_TC";
            this.mtb_TC.Size = new System.Drawing.Size(129, 21);
            this.mtb_TC.TabIndex = 15;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(159, 135);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(129, 21);
            this.txt_telefon.TabIndex = 14;
            // 
            // txt_MusteriSoyAdi
            // 
            this.txt_MusteriSoyAdi.Location = new System.Drawing.Point(5, 192);
            this.txt_MusteriSoyAdi.Name = "txt_MusteriSoyAdi";
            this.txt_MusteriSoyAdi.Size = new System.Drawing.Size(129, 21);
            this.txt_MusteriSoyAdi.TabIndex = 14;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(159, 78);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(129, 21);
            this.txt_email.TabIndex = 13;
            // 
            // txt_MusteriAdi
            // 
            this.txt_MusteriAdi.Location = new System.Drawing.Point(5, 135);
            this.txt_MusteriAdi.Name = "txt_MusteriAdi";
            this.txt_MusteriAdi.Size = new System.Drawing.Size(129, 21);
            this.txt_MusteriAdi.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "DOĞUM TARİHİ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "DOĞUM YERİ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "MEDENİ HALİ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CİNSİYET:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "TELEFON:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MÜŞTERİ SOYADI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "TC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "EMAİL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MÜŞTERİ ADI:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonKaydet,
            this.toolStripButtonGuncelle,
            this.toolStripButtonSil});
            this.toolStrip1.Location = new System.Drawing.Point(2, 20);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(298, 25);
            this.toolStrip1.TabIndex = 0;
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
            this.toolStripButtonGuncelle.Click += new System.EventHandler(this.toolStripButtonGuncelle_Click);
            // 
            // toolStripButtonSil
            // 
            this.toolStripButtonSil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSil.Image")));
            this.toolStripButtonSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSil.Name = "toolStripButtonSil";
            this.toolStripButtonSil.Size = new System.Drawing.Size(39, 22);
            this.toolStripButtonSil.Text = "Sil";
            this.toolStripButtonSil.Click += new System.EventHandler(this.toolStripButtonSil_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(2, 36);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(452, 394);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged_1);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl2);
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(757, 430);
            this.xtraTabPage2.Text = "Bireysel Müşteri Ürünleri";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.mtb_hesapno);
            this.groupControl2.Controls.Add(this.mtb_iban);
            this.groupControl2.Controls.Add(this.label24);
            this.groupControl2.Controls.Add(this.label26);
            this.groupControl2.Controls.Add(this.toolStrip2);
            this.groupControl2.Location = new System.Drawing.Point(448, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(309, 430);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "Bireysel Müşteri Ürünleri";
            // 
            // mtb_hesapno
            // 
            this.mtb_hesapno.Location = new System.Drawing.Point(38, 251);
            this.mtb_hesapno.Mask = "0000 0000 0000 0000";
            this.mtb_hesapno.Name = "mtb_hesapno";
            this.mtb_hesapno.Size = new System.Drawing.Size(217, 21);
            this.mtb_hesapno.TabIndex = 15;
            // 
            // mtb_iban
            // 
            this.mtb_iban.Location = new System.Drawing.Point(38, 165);
            this.mtb_iban.Mask = "TR00 0000 0000 0000 0000 0000 00";
            this.mtb_iban.Name = "mtb_iban";
            this.mtb_iban.Size = new System.Drawing.Size(217, 21);
            this.mtb_iban.TabIndex = 15;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(35, 136);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "IBAN:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(35, 226);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(99, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "HESAP NUMARASI:";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBireyselUrunKaydet,
            this.toolStripBireyselUrunGuncelle,
            this.toolStripBireyselUrunSil});
            this.toolStrip2.Location = new System.Drawing.Point(2, 20);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(305, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripBireyselUrunKaydet
            // 
            this.toolStripBireyselUrunKaydet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBireyselUrunKaydet.Image")));
            this.toolStripBireyselUrunKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBireyselUrunKaydet.Name = "toolStripBireyselUrunKaydet";
            this.toolStripBireyselUrunKaydet.Size = new System.Drawing.Size(63, 22);
            this.toolStripBireyselUrunKaydet.Text = "Kaydet";
            this.toolStripBireyselUrunKaydet.Click += new System.EventHandler(this.toolStripBireyselUrunKaydet_Click);
            // 
            // toolStripBireyselUrunGuncelle
            // 
            this.toolStripBireyselUrunGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBireyselUrunGuncelle.Image")));
            this.toolStripBireyselUrunGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBireyselUrunGuncelle.Name = "toolStripBireyselUrunGuncelle";
            this.toolStripBireyselUrunGuncelle.Size = new System.Drawing.Size(73, 22);
            this.toolStripBireyselUrunGuncelle.Text = "Güncelle";
            this.toolStripBireyselUrunGuncelle.Click += new System.EventHandler(this.toolStripBireyselUrunGuncelle_Click);
            // 
            // toolStripBireyselUrunSil
            // 
            this.toolStripBireyselUrunSil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBireyselUrunSil.Image")));
            this.toolStripBireyselUrunSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBireyselUrunSil.Name = "toolStripBireyselUrunSil";
            this.toolStripBireyselUrunSil.Size = new System.Drawing.Size(39, 22);
            this.toolStripBireyselUrunSil.Text = "Sil";
            this.toolStripBireyselUrunSil.Click += new System.EventHandler(this.toolStripBireyselUrunSil_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(446, 430);
            this.gridControl2.TabIndex = 11;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(217, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "TC\'YE GÖRE ARA:";
            // 
            // textBoxTCyeGoreAra
            // 
            this.textBoxTCyeGoreAra.Location = new System.Drawing.Point(309, 8);
            this.textBoxTCyeGoreAra.Name = "textBoxTCyeGoreAra";
            this.textBoxTCyeGoreAra.Size = new System.Drawing.Size(141, 21);
            this.textBoxTCyeGoreAra.TabIndex = 13;
            this.textBoxTCyeGoreAra.TextChanged += new System.EventHandler(this.textBoxTCyeGoreAra_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "ADINA GÖRE ARA:";
            // 
            // textBoxAdinaGoreAra
            // 
            this.textBoxAdinaGoreAra.Location = new System.Drawing.Point(108, 8);
            this.textBoxAdinaGoreAra.Name = "textBoxAdinaGoreAra";
            this.textBoxAdinaGoreAra.Size = new System.Drawing.Size(95, 21);
            this.textBoxAdinaGoreAra.TabIndex = 11;
            this.textBoxAdinaGoreAra.TextChanged += new System.EventHandler(this.textBoxAdinaGoreAra_TextChanged);
            // 
            // Frm_BireyselMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 477);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_BireyselMusteriler";
            this.Text = "Bireysel Müşteriler";
            this.Load += new System.EventHandler(this.Frm_BireyselMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.TextBox txt_maas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_aylikkazanc;
        private System.Windows.Forms.TextBox txt_meslek;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker date_dogumtarihi;
        private System.Windows.Forms.ComboBox cmb_medenihali;
        private System.Windows.Forms.ComboBox cmb_cinsiyet;
        public System.Windows.Forms.ComboBox cmb_dogumyeri;
        private System.Windows.Forms.MaskedTextBox mtb_TC;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_MusteriSoyAdi;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_MusteriAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.MaskedTextBox mtb_hesapno;
        private System.Windows.Forms.MaskedTextBox mtb_iban;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripBireyselUrunKaydet;
        private System.Windows.Forms.ToolStripButton toolStripBireyselUrunGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripBireyselUrunSil;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox textBoxTCyeGoreAra;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox textBoxAdinaGoreAra;
    }
}