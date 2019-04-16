namespace SmartBankasi.UI
{
    partial class Frm_Urunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Urunler));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cmb_urunTuru = new System.Windows.Forms.ComboBox();
            this.txt_urunAciklama = new System.Windows.Forms.TextBox();
            this.txt_urunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripUrunKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripUrunGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripUrunSil = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_urundetayBilgisi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripUrunDtyKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripUrunDtyGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripUrunDtySil = new System.Windows.Forms.ToolStripButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.xtraTabControl1.Size = new System.Drawing.Size(768, 467);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl2);
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabPage1.Size = new System.Drawing.Size(762, 420);
            this.xtraTabPage1.Text = "Ürün Bilgileri";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.cmb_urunTuru);
            this.groupControl2.Controls.Add(this.txt_urunAciklama);
            this.groupControl2.Controls.Add(this.txt_urunAdi);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.label24);
            this.groupControl2.Controls.Add(this.toolStrip2);
            this.groupControl2.Location = new System.Drawing.Point(485, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(282, 420);
            this.groupControl2.TabIndex = 13;
            this.groupControl2.Text = "Ürünler";
            // 
            // cmb_urunTuru
            // 
            this.cmb_urunTuru.FormattingEnabled = true;
            this.cmb_urunTuru.Location = new System.Drawing.Point(34, 205);
            this.cmb_urunTuru.Name = "cmb_urunTuru";
            this.cmb_urunTuru.Size = new System.Drawing.Size(210, 21);
            this.cmb_urunTuru.TabIndex = 4;
            this.cmb_urunTuru.SelectedIndexChanged += new System.EventHandler(this.cmb_urunTuru_SelectedIndexChanged);
            // 
            // txt_urunAciklama
            // 
            this.txt_urunAciklama.Location = new System.Drawing.Point(31, 282);
            this.txt_urunAciklama.Name = "txt_urunAciklama";
            this.txt_urunAciklama.Size = new System.Drawing.Size(213, 21);
            this.txt_urunAciklama.TabIndex = 3;
            // 
            // txt_urunAdi
            // 
            this.txt_urunAdi.Location = new System.Drawing.Point(31, 125);
            this.txt_urunAdi.Name = "txt_urunAdi";
            this.txt_urunAdi.Size = new System.Drawing.Size(213, 21);
            this.txt_urunAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "AÇIKLAMA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÜRÜN ADI:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(27, 179);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "ÜRÜN TÜRÜ:";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUrunKaydet,
            this.toolStripUrunGuncelle,
            this.toolStripUrunSil});
            this.toolStrip2.Location = new System.Drawing.Point(2, 20);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(278, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripUrunKaydet
            // 
            this.toolStripUrunKaydet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUrunKaydet.Image")));
            this.toolStripUrunKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUrunKaydet.Name = "toolStripUrunKaydet";
            this.toolStripUrunKaydet.Size = new System.Drawing.Size(63, 22);
            this.toolStripUrunKaydet.Text = "Kaydet";
            this.toolStripUrunKaydet.Click += new System.EventHandler(this.toolStripUrunKaydet_Click);
            // 
            // toolStripUrunGuncelle
            // 
            this.toolStripUrunGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUrunGuncelle.Image")));
            this.toolStripUrunGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUrunGuncelle.Name = "toolStripUrunGuncelle";
            this.toolStripUrunGuncelle.Size = new System.Drawing.Size(73, 22);
            this.toolStripUrunGuncelle.Text = "Güncelle";
            this.toolStripUrunGuncelle.Click += new System.EventHandler(this.toolStripUrunGuncelle_Click);
            // 
            // toolStripUrunSil
            // 
            this.toolStripUrunSil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUrunSil.Image")));
            this.toolStripUrunSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUrunSil.Name = "toolStripUrunSil";
            this.toolStripUrunSil.Size = new System.Drawing.Size(39, 22);
            this.toolStripUrunSil.Text = "Sil";
            this.toolStripUrunSil.Click += new System.EventHandler(this.toolStripUrunSil_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(-1, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(485, 420);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl1);
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(762, 420);
            this.xtraTabPage2.Text = "Ürün Detayları";

            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.txt_urundetayBilgisi);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.toolStrip1);
            this.groupControl1.Location = new System.Drawing.Point(483, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(282, 420);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Ürün Detayları";
            // 
            // txt_urundetayBilgisi
            // 
            this.txt_urundetayBilgisi.Location = new System.Drawing.Point(31, 151);
            this.txt_urundetayBilgisi.Multiline = true;
            this.txt_urundetayBilgisi.Name = "txt_urundetayBilgisi";
            this.txt_urundetayBilgisi.Size = new System.Drawing.Size(213, 86);
            this.txt_urundetayBilgisi.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ÜRÜN DETAY BİLGİSİ:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUrunDtyKaydet,
            this.toolStripUrunDtyGuncelle,
            this.toolStripUrunDtySil});
            this.toolStrip1.Location = new System.Drawing.Point(2, 20);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(278, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripUrunDtyKaydet
            // 
            this.toolStripUrunDtyKaydet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUrunDtyKaydet.Image")));
            this.toolStripUrunDtyKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUrunDtyKaydet.Name = "toolStripUrunDtyKaydet";
            this.toolStripUrunDtyKaydet.Size = new System.Drawing.Size(63, 22);
            this.toolStripUrunDtyKaydet.Text = "Kaydet";
            this.toolStripUrunDtyKaydet.Click += new System.EventHandler(this.toolStripUrunDtyKaydet_Click);
            // 
            // toolStripUrunDtyGuncelle
            // 
            this.toolStripUrunDtyGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUrunDtyGuncelle.Image")));
            this.toolStripUrunDtyGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUrunDtyGuncelle.Name = "toolStripUrunDtyGuncelle";
            this.toolStripUrunDtyGuncelle.Size = new System.Drawing.Size(73, 22);
            this.toolStripUrunDtyGuncelle.Text = "Güncelle";
            this.toolStripUrunDtyGuncelle.Click += new System.EventHandler(this.toolStripUrunDtyGuncelle_Click);
            // 
            // toolStripUrunDtySil
            // 
            this.toolStripUrunDtySil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUrunDtySil.Image")));
            this.toolStripUrunDtySil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUrunDtySil.Name = "toolStripUrunDtySil";
            this.toolStripUrunDtySil.Size = new System.Drawing.Size(39, 22);
            this.toolStripUrunDtySil.Text = "Sil";
            this.toolStripUrunDtySil.Click += new System.EventHandler(this.toolStripUrunDtySil_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Location = new System.Drawing.Point(-3, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(485, 420);
            this.gridControl2.TabIndex = 14;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // Frm_Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 467);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Urunler";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Frm_Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        public System.Windows.Forms.ComboBox cmb_urunTuru;
        private System.Windows.Forms.TextBox txt_urunAciklama;
        private System.Windows.Forms.TextBox txt_urunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripUrunKaydet;
        private System.Windows.Forms.ToolStripButton toolStripUrunGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripUrunSil;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txt_urundetayBilgisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripUrunDtyKaydet;
        private System.Windows.Forms.ToolStripButton toolStripUrunDtyGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripUrunDtySil;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}