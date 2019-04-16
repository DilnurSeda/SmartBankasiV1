namespace SmartBankasi.UI
{
    partial class Frm_Faturalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Faturalar));
            this.gridControlFaturalar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.group = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.time_faturasaati = new System.Windows.Forms.DateTimePicker();
            this.date_faturaTarihi = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.cmb_odemeler = new System.Windows.Forms.ComboBox();
            this.cmb_musteri = new System.Windows.Forms.ComboBox();
            this.cmbx_musterituru = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFaturalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.group.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlFaturalar
            // 
            this.gridControlFaturalar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlFaturalar.Location = new System.Drawing.Point(1, 1);
            this.gridControlFaturalar.MainView = this.gridView1;
            this.gridControlFaturalar.Name = "gridControlFaturalar";
            this.gridControlFaturalar.Size = new System.Drawing.Size(421, 423);
            this.gridControlFaturalar.TabIndex = 14;
            this.gridControlFaturalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlFaturalar;
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
            this.tabPane1.TabIndex = 15;
            this.tabPane1.Text = "tabPane1";
            // 
            // group
            // 
            this.group.Caption = "tabNavigationPage1";
            this.group.Controls.Add(this.cmb_odemeler);
            this.group.Controls.Add(this.cmb_musteri);
            this.group.Controls.Add(this.cmbx_musterituru);
            this.group.Controls.Add(this.label9);
            this.group.Controls.Add(this.label1);
            this.group.Controls.Add(this.label3);
            this.group.Controls.Add(this.time_faturasaati);
            this.group.Controls.Add(this.date_faturaTarihi);
            this.group.Controls.Add(this.label10);
            this.group.Controls.Add(this.label11);
            this.group.Controls.Add(this.txt_aciklama);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.toolStrip1);
            this.group.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("group.ImageOptions.Image")));
            this.group.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.group.Name = "group";
            this.group.PageText = "Faturalar";
            this.group.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.group.Size = new System.Drawing.Size(300, 376);
            // 
            // time_faturasaati
            // 
            this.time_faturasaati.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time_faturasaati.Location = new System.Drawing.Point(108, 97);
            this.time_faturasaati.Name = "time_faturasaati";
            this.time_faturasaati.Size = new System.Drawing.Size(162, 20);
            this.time_faturasaati.TabIndex = 37;
            // 
            // date_faturaTarihi
            // 
            this.date_faturaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_faturaTarihi.Location = new System.Drawing.Point(108, 58);
            this.date_faturaTarihi.Name = "date_faturaTarihi";
            this.date_faturaTarihi.Size = new System.Drawing.Size(162, 20);
            this.date_faturaTarihi.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Fatura Saati:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Fatura Tarihi:";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(108, 255);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(162, 68);
            this.txt_aciklama.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Açıklama:";
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
            // cmb_odemeler
            // 
            this.cmb_odemeler.FormattingEnabled = true;
            this.cmb_odemeler.Location = new System.Drawing.Point(108, 213);
            this.cmb_odemeler.Name = "cmb_odemeler";
            this.cmb_odemeler.Size = new System.Drawing.Size(162, 21);
            this.cmb_odemeler.TabIndex = 43;
            this.cmb_odemeler.SelectedIndexChanged += new System.EventHandler(this.cmb_odemeler_SelectedIndexChanged);
            // 
            // cmb_musteri
            // 
            this.cmb_musteri.FormattingEnabled = true;
            this.cmb_musteri.Location = new System.Drawing.Point(108, 176);
            this.cmb_musteri.Name = "cmb_musteri";
            this.cmb_musteri.Size = new System.Drawing.Size(162, 21);
            this.cmb_musteri.TabIndex = 44;
            this.cmb_musteri.SelectedIndexChanged += new System.EventHandler(this.cmb_musteri_SelectedIndexChanged);
            // 
            // cmbx_musterituru
            // 
            this.cmbx_musterituru.FormattingEnabled = true;
            this.cmbx_musterituru.Location = new System.Drawing.Point(108, 138);
            this.cmbx_musterituru.Name = "cmbx_musterituru";
            this.cmbx_musterituru.Size = new System.Drawing.Size(162, 21);
            this.cmbx_musterituru.TabIndex = 42;
            this.cmbx_musterituru.SelectedIndexChanged += new System.EventHandler(this.cmbx_musterituru_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Ödeme Planı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Müşteri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Müşteri Türü:";
            // 
            // Frm_Faturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 425);
            this.Controls.Add(this.gridControlFaturalar);
            this.Controls.Add(this.tabPane1);
            this.Name = "Frm_Faturalar";
            this.Text = "Faturalar";
            this.Load += new System.EventHandler(this.Frm_Faturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFaturalar)).EndInit();
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

        private DevExpress.XtraGrid.GridControl gridControlFaturalar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage group;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
        private System.Windows.Forms.DateTimePicker time_faturasaati;
        private System.Windows.Forms.DateTimePicker date_faturaTarihi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_odemeler;
        private System.Windows.Forms.ComboBox cmb_musteri;
        private System.Windows.Forms.ComboBox cmbx_musterituru;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}