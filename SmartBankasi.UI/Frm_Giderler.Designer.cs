namespace SmartBankasi.UI
{
    partial class Frm_Giderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Giderler));
            this.gridControlGiderler = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.group = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.date_giderTarihi = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.mtb_miktar = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_faizlimi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_faizorani = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGiderler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.group.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlGiderler
            // 
            this.gridControlGiderler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlGiderler.Location = new System.Drawing.Point(1, 1);
            this.gridControlGiderler.MainView = this.gridView1;
            this.gridControlGiderler.Name = "gridControlGiderler";
            this.gridControlGiderler.Size = new System.Drawing.Size(421, 423);
            this.gridControlGiderler.TabIndex = 16;
            this.gridControlGiderler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlGiderler;
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
            this.tabPane1.TabIndex = 17;
            this.tabPane1.Text = "tabPane1";
            // 
            // group
            // 
            this.group.Caption = "tabNavigationPage1";
            this.group.Controls.Add(this.mtb_faizorani);
            this.group.Controls.Add(this.label3);
            this.group.Controls.Add(this.cmb_faizlimi);
            this.group.Controls.Add(this.label1);
            this.group.Controls.Add(this.mtb_miktar);
            this.group.Controls.Add(this.date_giderTarihi);
            this.group.Controls.Add(this.label10);
            this.group.Controls.Add(this.label11);
            this.group.Controls.Add(this.txt_aciklama);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.toolStrip1);
            this.group.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("group.ImageOptions.Image")));
            this.group.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.group.Name = "group";
            this.group.PageText = "Giderler";
            this.group.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.group.Size = new System.Drawing.Size(300, 376);
            // 
            // date_giderTarihi
            // 
            this.date_giderTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_giderTarihi.Location = new System.Drawing.Point(108, 63);
            this.date_giderTarihi.Name = "date_giderTarihi";
            this.date_giderTarihi.Size = new System.Drawing.Size(157, 20);
            this.date_giderTarihi.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Miktar:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Gider Tarihi:";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(108, 146);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(157, 49);
            this.txt_aciklama.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 146);
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
            // mtb_miktar
            // 
            this.mtb_miktar.Location = new System.Drawing.Point(108, 104);
            this.mtb_miktar.Mask = "0000000000";
            this.mtb_miktar.Name = "mtb_miktar";
            this.mtb_miktar.Size = new System.Drawing.Size(157, 20);
            this.mtb_miktar.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Faizli mi?:";
            // 
            // cmb_faizlimi
            // 
            this.cmb_faizlimi.FormattingEnabled = true;
            this.cmb_faizlimi.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cmb_faizlimi.Location = new System.Drawing.Point(108, 209);
            this.cmb_faizlimi.Name = "cmb_faizlimi";
            this.cmb_faizlimi.Size = new System.Drawing.Size(157, 21);
            this.cmb_faizlimi.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Faiz Oranı:";
            // 
            // mtb_faizorani
            // 
            this.mtb_faizorani.Location = new System.Drawing.Point(108, 249);
            this.mtb_faizorani.Mask = "0000000000";
            this.mtb_faizorani.Name = "mtb_faizorani";
            this.mtb_faizorani.Size = new System.Drawing.Size(157, 20);
            this.mtb_faizorani.TabIndex = 43;
            // 
            // Frm_Giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 425);
            this.Controls.Add(this.gridControlGiderler);
            this.Controls.Add(this.tabPane1);
            this.Name = "Frm_Giderler";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.Frm_Giderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGiderler)).EndInit();
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

        private DevExpress.XtraGrid.GridControl gridControlGiderler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage group;
        private System.Windows.Forms.DateTimePicker date_giderTarihi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
        private System.Windows.Forms.MaskedTextBox mtb_faizorani;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_faizlimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_miktar;
    }
}