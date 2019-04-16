using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using SmartBankasi.BLL.Loginislemleri;
using SmartBankasi.BLL.Urunislemleri;
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
    public partial class Frm_Urunler : Form
    {
        string mesajUrun;
        int urun_id,urunturu_id,urundetay_id;        
        UrunlerManager urunManage = new UrunlerManager();
        public int kullanici_IDTut;


        public Frm_Urunler()
        {
            InitializeComponent();
        }

        private void Frm_Urunler_Load(object sender, EventArgs e)
        {
            urunManage.UrunlerListesi(gridControl1);
            urunManage.UrunlerDetayListesi(gridControl2,urun_id);
            urunManage.UrunTuruListele(cmb_urunTuru);
        }

        #region Ürünler
        private void toolStripUrunKaydet_Click(object sender, EventArgs e)
        {
            mesajUrun = urunManage.UrunlerKaydet(txt_urunAdi.Text, urunturu_id, txt_urunAciklama.Text, kullanici_IDTut);
            urunManage.UrunlerListesi(gridControl1);
            MessageBox.Show(mesajUrun);
        }

        private void toolStripUrunGuncelle_Click(object sender, EventArgs e)
        {
            mesajUrun = urunManage.UrunlerGuncelle(urun_id, txt_urunAdi.Text, urunturu_id, txt_urunAciklama.Text, kullanici_IDTut);
            urunManage.UrunlerListesi(gridControl1);
            MessageBox.Show(mesajUrun);
        }

        private void toolStripUrunSil_Click(object sender, EventArgs e)
        {
            mesajUrun = urunManage.UrunlerSil(urun_id);
            urunManage.UrunlerListesi(gridControl1);
            MessageBox.Show(mesajUrun);
        }

        private void cmb_urunTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            urunturu_id = (int)cmb_urunTuru.SelectedValue;
        }



        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            urun_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("UrunlerID").ToString());
            txt_urunAdi.Text = gridView1.GetFocusedRowCellValue("UrunAdi").ToString();
            urunturu_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("UrunTuruID").ToString());
            cmb_urunTuru.Text = urunManage.UrunTurAdi(urunturu_id);
            txt_urunAciklama.Text = gridView1.GetFocusedRowCellValue("Aciklama").ToString();
            //kullanici_IDTut = Convert.ToInt32(gridView1.GetFocusedRowCellValue("KullaniciID").ToString());
        } 
        #endregion

        #region Ürün Detayları


        private void toolStripUrunDtyKaydet_Click(object sender, EventArgs e)
        {
            mesajUrun = urunManage.UrunlerDetayKaydet(txt_urundetayBilgisi.Text, urun_id, kullanici_IDTut);
            urunManage.UrunlerDetayListesi(gridControl2, urun_id);
            MessageBox.Show(mesajUrun);
        }

        private void toolStripUrunDtyGuncelle_Click(object sender, EventArgs e)
        {
            mesajUrun = urunManage.UrunlerDetayGuncelle(urundetay_id,txt_urundetayBilgisi.Text, urun_id, kullanici_IDTut);
            urunManage.UrunlerDetayListesi(gridControl2, urun_id);
            MessageBox.Show(mesajUrun);
        }


        private void xtraTabControl1_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPage2)
            {
                urunManage.UrunlerDetayListesi(gridControl2, urun_id);
            }
        }


        private void toolStripUrunDtySil_Click(object sender, EventArgs e)
        {
            mesajUrun = urunManage.UrunlerDetaySil(urundetay_id);
            urunManage.UrunlerDetayListesi(gridControl2, urun_id);
            MessageBox.Show(mesajUrun);
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                urundetay_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("UrunDetaylariID").ToString());
                txt_urundetayBilgisi.Text = gridView2.GetFocusedRowCellValue("DetayBilgisi").ToString();
                urun_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("UrunID").ToString());
                //kullanici_IDTut = Convert.ToInt32(gridView2.GetFocusedRowCellValue("KullaniciID").ToString());
            }
            catch (Exception)
            {

                
            }
        }

        #endregion


    }
}
