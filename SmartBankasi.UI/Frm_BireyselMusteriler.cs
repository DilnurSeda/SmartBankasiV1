using SmartBankasi.BLL.ililceSecimi;
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
    public partial class Frm_BireyselMusteriler : Form
    {
        string mesajMusteri;
        public Frm_BireyselMusteriler()
        {
            InitializeComponent();
        }

        MusterilerManager musteriManage = new MusterilerManager();
        ililceGetir il_ilceGetir = new ililceGetir();
        //LoginManager logManager = new LoginManager();
        int bireyselmusteri_id;
        int musteritur_id=1;
        int urun_id,bireyselmusteriurun_id;
        public int kullanici_IDTut;
        //**************************************************************
        private void Frm_BireyselMusteriler_Load(object sender, EventArgs e)
        {
            il_ilceGetir.illerListesi(cmb_dogumyeri);
            musteriManage.BireyselMusteriListesi(gridControl1);
            //***********************************************
            musteriManage.BireyselMusteriUrunleriListesi(gridControl2, bireyselmusteri_id);
        }

        #region Bireysel Müşteriler
        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            mesajMusteri = musteriManage.BireyselMusteriKaydet(mtb_TC.Text, txt_MusteriAdi.Text, txt_MusteriSoyAdi.Text, cmb_cinsiyet.Text, MedeniHali(), cmb_dogumyeri.Text, Convert.ToDateTime(date_dogumtarihi.Value).ToString(), txt_email.Text, txt_telefon.Text, txt_meslek.Text, Convert.ToDecimal(txt_aylikkazanc.Text), Convert.ToDecimal(txt_maas.Text), txt_adres.Text, musteritur_id, kullanici_IDTut);
            musteriManage.BireyselMusteriListesi(gridControl1);
            MessageBox.Show(mesajMusteri);

        }
        bool MedeniHali()
        {
            if (cmb_medenihali.SelectedIndex == 0)
            {
                return false;
            }
            else if (cmb_medenihali.SelectedIndex == 1)
            {
                return true;
            }
            return false;

        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            mesajMusteri = musteriManage.BireyselMusteriGuncelle(bireyselmusteri_id, mtb_TC.Text, txt_MusteriAdi.Text, txt_MusteriSoyAdi.Text, cmb_cinsiyet.Text, MedeniHali(), cmb_dogumyeri.Text, Convert.ToDateTime(date_dogumtarihi.Value).ToString(), txt_email.Text, txt_telefon.Text, txt_meslek.Text, Convert.ToDecimal(txt_aylikkazanc.Text), Convert.ToDecimal(txt_maas.Text), txt_adres.Text, musteritur_id, kullanici_IDTut);
            musteriManage.BireyselMusteriListesi(gridControl1);
            MessageBox.Show(mesajMusteri);
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            mesajMusteri = musteriManage.BireyselMusteriSil(bireyselmusteri_id);
            musteriManage.BireyselMusteriListesi(gridControl1);
            MessageBox.Show(mesajMusteri);
        }
        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                bireyselmusteri_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("BireyselMustrilerID").ToString());
                mtb_TC.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
                txt_MusteriAdi.Text = gridView1.GetFocusedRowCellValue("Adi").ToString();
                txt_MusteriSoyAdi.Text = gridView1.GetFocusedRowCellValue("Soyadi").ToString();
                cmb_cinsiyet.Text = gridView1.GetFocusedRowCellValue("Cinsiyet").ToString();
                if (Convert.ToBoolean(gridView1.GetFocusedRowCellValue("MedeniHali").ToString()) == true)
                {
                    cmb_medenihali.Text = "EVLİ";
                }
                else
                {
                    cmb_medenihali.Text = "BEKAR";
                }
                cmb_dogumyeri.Text = gridView1.GetFocusedRowCellValue("DogumYeri").ToString();
                date_dogumtarihi.Value = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("DogumTarihi").ToString());
                txt_email.Text = gridView1.GetFocusedRowCellValue("Email").ToString();
                txt_telefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
                txt_meslek.Text = gridView1.GetFocusedRowCellValue("Meslek").ToString();
                txt_aylikkazanc.Text = gridView1.GetFocusedRowCellValue("AylikKazanci").ToString();
                txt_maas.Text = gridView1.GetFocusedRowCellValue("Maas").ToString();
                txt_adres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
                musteritur_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("MusteriTurID").ToString());
                //logManager.kullanici_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("KullaniciID").ToString());
            }
            catch (Exception)
            {


            }
        }



        #endregion

        #region Bireysel Müşteri Ürünleri
        private void toolStripBireyselUrunKaydet_Click(object sender, EventArgs e)
        {
            mesajMusteri = musteriManage.BireyselMusteriUrunleriKaydet(urun_id, mtb_iban.Text, mtb_hesapno.Text, bireyselmusteriurun_id, kullanici_IDTut);
            musteriManage.BireyselMusteriUrunleriListesi(gridControl2,bireyselmusteri_id);
            MessageBox.Show(mesajMusteri);
        }

        private void toolStripBireyselUrunGuncelle_Click(object sender, EventArgs e)
        {
            mesajMusteri = musteriManage.BireyselMusteriUrunleriGuncelle(bireyselmusteriurun_id,urun_id, mtb_iban.Text, mtb_hesapno.Text, bireyselmusteri_id, kullanici_IDTut);
            musteriManage.BireyselMusteriUrunleriListesi(gridControl2, bireyselmusteri_id);
            MessageBox.Show(mesajMusteri);
        }

        private void toolStripBireyselUrunSil_Click(object sender, EventArgs e)
        {
            mesajMusteri = musteriManage.BireyselMusteriUrunleriSil(bireyselmusteriurun_id);
            musteriManage.BireyselMusteriUrunleriListesi(gridControl2, bireyselmusteri_id);
            MessageBox.Show(mesajMusteri);
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage==xtraTabPage2)
            {
                musteriManage.BireyselMusteriUrunleriListesi(gridControl2, bireyselmusteri_id);
            }
        }

        private void textBoxAdinaGoreAra_TextChanged(object sender, EventArgs e)
        {
            musteriManage.AdaGoreAra(gridControl1, textBoxAdinaGoreAra.Text);
        }

        private void textBoxTCyeGoreAra_TextChanged(object sender, EventArgs e)
        {
            musteriManage.TCGoreAra(gridControl1, textBoxTCyeGoreAra.Text);
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                bireyselmusteriurun_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("BireyselMusteriUrunleriID").ToString());
                urun_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("UrunID").ToString());
                mtb_iban.Text = gridView2.GetFocusedRowCellValue("IBAN").ToString();
                mtb_hesapno.Text = gridView2.GetFocusedRowCellValue("HesapNumarasi").ToString();
                bireyselmusteri_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("BireyselMusteriID").ToString());
                //logManager.kullanici_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("KullaniciID").ToString());
            }
            catch (Exception)
            {

                
            }
        } 
        #endregion
    }
}
