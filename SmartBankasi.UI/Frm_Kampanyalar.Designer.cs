namespace SmartBankasi.UI
{
    partial class Frm_Kampanyalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Kampanyalar));
            this.gridControlKampanya = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.group = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.txt_kmpnyaAdi = new System.Windows.Forms.TextBox();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date_bitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.date_baslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.btnVazgecCikis = new System.Windows.Forms.Button();
            this.btnCikisTarihiEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKampanya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.group.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlKampanya
            // 
            this.gridControlKampanya.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlKampanya.Location = new System.Drawing.Point(1, 1);
            this.gridControlKampanya.MainView = this.gridView1;
            this.gridControlKampanya.Name = "gridControlKampanya";
            this.gridControlKampanya.Size = new System.Drawing.Size(421, 423);
            this.gridControlKampanya.TabIndex = 10;
            this.gridControlKampanya.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlKampanya;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // tabPane1
            // 
            this.tabPane1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPane1.Controls.Add(this.group);
            this.tabPane1.Location = new System.Drawing.Point(425, 2);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.group});
            this.tabPane1.RegularSize = new System.Drawing.Size(300, 422);
            this.tabPane1.SelectedPage = this.group;
            this.tabPane1.Size = new System.Drawing.Size(300, 422);
            this.tabPane1.TabIndex = 11;
            this.tabPane1.Text = "tabPane1";
            // 
            // group
            // 
            this.group.Caption = "tabNavigationPage1";
            this.group.Controls.Add(this.btnVazgecCikis);
            this.group.Controls.Add(this.btnCikisTarihiEkle);
            this.group.Controls.Add(this.txt_kmpnyaAdi);
            this.group.Controls.Add(this.txt_aciklama);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.label1);
            this.group.Controls.Add(this.date_bitisTarihi);
            this.group.Controls.Add(this.date_baslangicTarihi);
            this.group.Controls.Add(this.label10);
            this.group.Controls.Add(this.label11);
            this.group.Controls.Add(this.toolStrip1);
            this.group.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("group.ImageOptions.Image")));
            this.group.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.group.Name = "group";
            this.group.PageText = "Kampanyalar";
            this.group.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.group.Size = new System.Drawing.Size(300, 376);
            // 
            // txt_kmpnyaAdi
            // 
            this.txt_kmpnyaAdi.Location = new System.Drawing.Point(116, 163);
            this.txt_kmpnyaAdi.Name = "txt_kmpnyaAdi";
            this.txt_kmpnyaAdi.Size = new System.Drawing.Size(158, 20);
            this.txt_kmpnyaAdi.TabIndex = 25;
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(117, 198);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(157, 68);
            this.txt_aciklama.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Açıklama:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Kampanya Adı:";
            // 
            // date_bitisTarihi
            // 
            this.date_bitisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_bitisTarihi.Location = new System.Drawing.Point(116, 124);
            this.date_bitisTarihi.Name = "date_bitisTarihi";
            this.date_bitisTarihi.Size = new System.Drawing.Size(158, 20);
            this.date_bitisTarihi.TabIndex = 21;
            this.date_bitisTarihi.Visible = false;
            // 
            // date_baslangicTarihi
            // 
            this.date_baslangicTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_baslangicTarihi.Location = new System.Drawing.Point(116, 85);
            this.date_baslangicTarihi.Name = "date_baslangicTarihi";
            this.date_baslangicTarihi.Size = new System.Drawing.Size(158, 20);
            this.date_baslangicTarihi.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Bitiş Tarihi:";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Başlangıç Tarihi:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonKaydet,
            this.toolStripButtonGuncelle,
            this.toolStripButtonSil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(300, 25);
            this.toolStrip1.TabIndex = 16;
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
            // btnVazgecCikis
            // 
            this.btnVazgecCikis.Location = new System.Drawing.Point(203, 279);
            this.btnVazgecCikis.Name = "btnVazgecCikis";
            this.btnVazgecCikis.Size = new System.Drawing.Size(72, 39);
            this.btnVazgecCikis.TabIndex = 28;
            this.btnVazgecCikis.Text = "Vazgeç";
            this.btnVazgecCikis.UseVisualStyleBackColor = true;
            this.btnVazgecCikis.Click += new System.EventHandler(this.btnVazgecCikis_Click);
            // 
            // btnCikisTarihiEkle
            // 
            this.btnCikisTarihiEkle.Location = new System.Drawing.Point(117, 279);
            this.btnCikisTarihiEkle.Name = "btnCikisTarihiEkle";
            this.btnCikisTarihiEkle.Size = new System.Drawing.Size(72, 39);
            this.btnCikisTarihiEkle.TabIndex = 27;
            this.btnCikisTarihiEkle.Text = "Çıkış Tarihi Ekle";
            this.btnCikisTarihiEkle.UseVisualStyleBackColor = true;
            this.btnCikisTarihiEkle.Click += new System.EventHandler(this.btnCikisTarihiEkle_Click);
            // 
            // Frm_Kampanyalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 425);
            this.Controls.Add(this.gridControlKampanya);
            this.Controls.Add(this.tabPane1);
            this.Name = "Frm_Kampanyalar";
            this.Text = "Kampanyalar";
            this.Load += new System.EventHandler(this.Frm_Kampanyalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKampanya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlKampanya;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage group;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
        private System.Windows.Forms.DateTimePicker date_bitisTarihi;
        private System.Windows.Forms.DateTimePicker date_baslangicTarihi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_kmpnyaAdi;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVazgecCikis;
        private System.Windows.Forms.Button btnCikisTarihiEkle;
    }
}