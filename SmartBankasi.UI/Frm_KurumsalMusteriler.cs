using SmartBankasi.BLL.Loginislemleri;
using SmartBankasi.BLL.Musteriislemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBankasi.UI
{
    public partial class Frm_KurumsalMusteriler : Form
    {
        public Frm_KurumsalMusteriler()
        {
            InitializeComponent();
        }
        string mesajMusteri;
        MusterilerManager musteriManager = new MusterilerManager();
        int kurumsalmusteri_id,urun_id,kurumsalyetkili_id,kurumsalmusteriurun_id;
        int kurumsalmusteritur_id = 2;
        public int kullanici_IDTut;


        private void Frm_KurumsalMusteriler_Load(object sender, EventArgs e)
        {
            musteriManager.KurumsalMusteriListesi(gridControl1);
            musteriManager.KurumsalYetkiliListesi(gridControl3, kurumsalmusteri_id);
            musteriManager.KurumsalMusteriUrunleriListesi(gridControl2,kurumsalyetkili_id);
            //---------------------------------------------------
            cmb_gorevler.DisplayMember = "GorevAdi";
            cmb_gorevler.ValueMember = "GorevlerID";
            musteriManager.GorevlerListesi(cmb_gorevler);
            //---------------------------------------------------
           
        }
        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPage3)
            {
                musteriManager.KurumsalYetkiliListesi(gridControl3, kurumsalmusteri_id);
            }
            if (xtraTabControl1.SelectedTabPage == xtraTabPage2)
            {
                musteriManager.KurumsalMusteriUrunleriListesi(gridControl2, kurumsalyetkili_id);
            }
        }

        #region Kurumsal Müşteriler
        private void toolStripButtonKaydet_Click_1(object sender, EventArgs e)
        {
            mesajMusteri = musteriManager.KurumsalMusteriKaydet(txt_kurumAdi.Text, txt_kurumAdresi.Text, mtb_tel1.Text, mtb_tel2.Text, txt_email.Text, txt_aciklama.Text,kurumsalmusteritur_id, kullanici_IDTut);
            musteriManager.KurumsalMusteriListesi(gridControl1);
            MessageBox.Show(mesajMusteri);
        }

        private void toolStripButtonGuncelle_Click_1(object sender, EventArgs e)
        {
            mesajMusteri = musteriManager.KurumsalMusteriGuncelle(kurumsalmusteri_id, txt_kurumAdi.Text, txt_kurumAdresi.Text, mtb_tel1.Text, mtb_tel2.Text, txt_email.Text, txt_aciklama.Text,kurumsalmusteritur_id, kullanici_IDTut);
            musteriManager.KurumsalMusteriListesi(gridControl1);
            MessageBox.Show(mesajMusteri);
        }

        private void toolStripButtonSil_Click_1(object sender, EventArgs e)
        {
            mesajMusteri = musteriManager.KurumsalMusteriSil(kurumsalmusteri_id);
            musteriManager.KurumsalMusteriListesi(gridControl1);
            MessageBox.Show(mesajMusteri);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                kurumsalmusteri_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("KurumsalMusterilerID").ToString());
                txt_kurumAdi.Text = gridView1.GetFocusedRowCellValue("KurumAdi").ToString();
                txt_kurumAdresi.Text = gridView1.GetFocusedRowCellValue("KurumAdres").ToString();
                mtb_tel1.Text = gridView1.GetFocusedRowCellValue("Telefon1").ToString();
                mtb_tel2.Text = gridView1.GetFocusedRowCellValue("Telefon2").ToString();
                txt_email.Text = gridView1.GetFocusedRowCellValue("Email").ToString();
                txt_aciklama.Text = gridView1.GetFocusedRowCellValue("Aciklama").ToString();
                kurumsalmusteritur_id= Convert.ToInt32(gridView1.GetFocusedRowCellValue("MusteriTurID").ToString());

            }
            catch (Exception)
            {

            }
        }


        #endregion

        #region Kurumsal Yetkililer
        private void toolStripyetkilikaydet_Click(object sender, EventArgs e)
        {
            mesajMusteri = musteriManager.KurumsalYetkiliKaydet(mtb_tc.Text,txt_adi.Text,txt_soyadi.Text,cmb_gorevler.Text,mtb_tel1.Text,mtb_tel2.Text,txt_email.Text,kurumsalmusteri_id,kullanici_IDTut);
            musteriManager.KurumsalYetkiliListesi(gridControl3, kurumsalmusteri_id);
            MessageBox.Show(mesajMusteri);
        }

        private void toolStripyetkiliguncelle_Click(object sender, EventArgs e)
        {
            mesajMusteri = musteriManager.KurumsalYetkiliGuncelle(kurumsalyetkili_id,mtb_tc.Text, txt_adi.Text, txt_soyadi.Text, cmb_gorevler.Text, mtb_tel1.Text, mtb_tel2.Text, txt_email.Text, kurumsalmusteri_id, kullanici_IDTut);
            musteriManager.KurumsalYetkiliListesi(gridControl3, kurumsalmusteri_id);
            MessageBox.Show(mesajMusteri);
        }

        private void toolStripyetkilisil_Click(object sender, EventArgs e)
        {
            mesajMusteri = musteriManager.KurumsalYetkiliSil(kurumsalyetkili_id);
            musteriManager.KurumsalYetkiliListesi(gridControl3, kurumsalmusteri_id);
            MessageBox.Show(mesajMusteri);
        }
        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                
                kurumsalyetkili_id = Convert.ToInt32(gridView3.GetFocusedRowCellValue("KurumsalYetkililerID").ToString());
                mtb_tc.Text = gridView3.GetFocusedRowCellValue("TC").ToString();
                txt_adi.Text = gridView3.GetFocusedRowCellValue("Adi").ToString();
                txt_soyadi.Text = gridView3.GetFocusedRowCellValue("Soyadi").ToString();
                cmb_gorevler.Text = gridView3.GetFocusedRowCellValue("Gorevi").ToString();
                maskedTextBox1.Text = gridView3.GetFocusedRowCellValue("Telefon1").ToString();
                maskedTextBox2.Text = gridView3.GetFocusedRowCellValue("Telefon2").ToString();
                text_email.Text = gridView3.GetFocusedRowCellValue("Email").ToString();
                //kurumsalmusteri_id = Convert.ToInt32(gridView3.GetFocusedRowCellValue("KurumsalYetkiliID").ToString());
            }
            catch (Exception)
            {


            }
        } 
        #endregion

        #region Kurumsal Müşteri Ürünleri
        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                kurumsalmusteriurun_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("KurumsalMusteriUrunleriID").ToString());
                urun_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("UrunID").ToString());
                kurumsalyetkili_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("KurumsalYetkiliID").ToString());
                mtb_iban2.Text = gridView2.GetFocusedRowCellValue("IBAN").ToString();
                mtb_hesapno2.Text = gridView2.GetFocusedRowCellValue("HesapNumarasi").ToString();
            
            }
            catch (Exception)
            {


            }
        }
        int x = 0;
        private void simplePDF_Click(object sender, EventArgs e)
        {
            gridControl1.ExportToPdf(@"C:\Users\dilnur.engin\Desktop\TestPdf"+txt_kurumAdi.Text+".Pdf");
            x++;
        }

        private void simpleEXCEL_Click(object sender, EventArgs e)
        {
            gridControl1.ExportToXls(@"C:\Users\dilnur.engin\Desktop\TestExcel" + txt_kurumAdi.Text + ".xls");
        }

        private void toolStripKurumUrunKaydet_Click(object sender, EventArgs e)
        {
            mesajMusteri = musteriManager.KurumsalMusteriUrunleriKaydet(urun_id, kurumsalyetkili_id, mtb_iban2.Text, mtb_hesapno2.Text, kullanici_IDTut);
            musteriManager.KurumsalMusteriUrunleriListesi(gridControl2,kurumsalyetkili_id);
            MessageBox.Show(mesajMusteri);
        }

        private void toolStripKurumUrunGuncelle_Click(object sender, EventArgs e)
        {
            mesajMusteri = musteriManager.KurumsalMusteriUrunleriGuncelle(kurumsalmusteriurun_id, urun_id, kurumsalyetkili_id, mtb_iban2.Text, mtb_hesapno2.Text, kullanici_IDTut);
            musteriManager.KurumsalMusteriUrunleriListesi(gridControl2,kurumsalyetkili_id);
            MessageBox.Show(mesajMusteri);
        }

        private void toolStripKurumUrunSil_Click(object sender, EventArgs e)
        {
            mesajMusteri = musteriManager.KurumsalMusteriUrunleriSil(kurumsalmusteriurun_id);
            musteriManager.KurumsalMusteriUrunleriListesi(gridControl2,kurumsalyetkili_id);
            MessageBox.Show(mesajMusteri);
        } 
        #endregion

    }
}
