using SmartBankasi.BLL.MusteriTurleriislemleri;
using SmartBankasi.BLL.Odemeislemleri;
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
    public partial class Frm_Odemeler : Form
    {
        public Frm_Odemeler()
        {
            InitializeComponent();
        }
        public int kullanici_IDTut;
        MusteriTurleriManager mtmanage = new MusteriTurleriManager();
        OdemelerManager odemeManage = new OdemelerManager();
        TextBox[] taksit;
        int sayisi;
        int musterituru_id, musteri_id, odemeplani_id, parabirimi_id, odemeturleri_id;

        private void Frm_Odemeler_Load(object sender, EventArgs e)
        {
            odemeManage.OdemelerListesi(gridControlOdemeler);
            cmb_musterituru.DataSource = odemeManage.MusteriTurleriListesi();
            cmb_musterituru.DisplayMember = "TurAdi";
            cmb_musterituru.ValueMember = "MusteriTurleriID";
            cmbx_musterituru.DataSource = odemeManage.MusteriTurleriListesi();
            cmbx_musterituru.DisplayMember = "TurAdi";
            cmbx_musterituru.ValueMember = "MusteriTurleriID";
            mtmanage.MusteriTurleri(cmb_musterituru);
            cmb_odemeler.DisplayMember = "OdemePlanlariID";
            cmb_odemeler.ValueMember = "OdemePlanlariID";
            odemeManage.OdemePlanlariListesi(cmb_odemeler);
            cmb_parabirimi.DisplayMember = "BirimAdi";
            cmb_parabirimi.ValueMember = "ParaBirimleriID";
            odemeManage.OdemeTurleriParaBirimiListesi(cmb_parabirimi);
            odemeManage.OdemeTurleriListesi(gridControl1OdemeTuru);
            odemeManage.OdemePlanlariListesi(gridControlOdemePlani);
        }
        #region Odeme Planları
        private decimal FaizHesabi(decimal miktar, int taksitsayisi)
        {
            if (taksitsayisi > 0 && taksitsayisi <= 12)
            {
                miktar = miktar + miktar * 0.015m;
            }
            if (taksitsayisi > 12 && taksitsayisi <= 24)
            {
                miktar = miktar + miktar * 0.019m;
            }
            if (taksitsayisi > 24 && taksitsayisi <= 36)
            {
                miktar = miktar + miktar * 0.022m;
            }
            return miktar;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if ((int)cmb_musterituru.SelectedValue == 1)
            {
                //bireysel müşteri
                mtmanage.BireyselMusteriGetir(mtb_tc.Text);
                txt_Adi.Text = mtmanage.isim;
                txt_soyadi.Text = mtmanage.soyisim;
            }
            if ((int)cmb_musterituru.SelectedValue == 2)
            {
                //kurumsal müşteri
                mtmanage.KurumsalMusteriGetir(mtb_tc.Text);
                txt_Adi.Text = mtmanage.isim;
                txt_soyadi.Text = mtmanage.soyisim;
            }
        }

        private void btn_taksitolustur_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_taksitsayisi.Text))
            {
                //*******************************************************
                //*******************************************************
                sayisi = Convert.ToInt32(txt_taksitsayisi.Text);
                gridControlOdemePlani.Visible = false;
                //if (sayisi < 12)
                //{
                //    for (int i = sayisi + 1; i <= 12; i++)
                //    {
                //        taksit[i].Text = 0.ToString();
                //    }
                //}
                //*******************************************************
                //*******************************************************

                decimal krediMiktari = Convert.ToDecimal(txt_kredimiktari.Text);
                //sayisi = Convert.ToInt32(txt_taksitsayisi.Text);
                decimal aylikOdeme = FaizHesabi(krediMiktari, sayisi) / sayisi;
                taksit = new TextBox[sayisi];

                Label[] lDizi = new Label[sayisi];

                int sutun2TextBox = 0;
                int sutun3TextBox = 0;

                int sutun2label = 0;
                int sutun3label = 0;

                for (int i = 0; i < sayisi; i++)
                {
                    taksit[i] = new TextBox();

                    if (i <= 15)
                    {
                        taksit[i].Name = "taksit" + i;
                        panelControl1.Controls.Add(taksit[i]);
                        taksit[i].Text = aylikOdeme.ToString();
                        taksit[i].Top = i * 25;
                        taksit[i].Left = 75;
                        taksit[i].Width = 150;
                    }
                    if (i > 15 && i <= 30)
                    {
                        taksit[i].Name = "taksit" + i;
                        panelControl1.Controls.Add(taksit[i]);
                        taksit[i].Text = aylikOdeme.ToString();
                        taksit[i].Top = sutun2TextBox * 25;
                        taksit[i].Left = 300;
                        taksit[i].Width = 150;
                        sutun2TextBox++;
                    }
                    if (i > 30 && i <= 50)
                    {
                        taksit[i].Name = "taksit" + i;
                        panelControl1.Controls.Add(taksit[i]);
                        taksit[i].Text = aylikOdeme.ToString();
                        taksit[i].Top = sutun2TextBox * 25;
                        taksit[i].Left = 583;
                        taksit[i].Width = 150;
                        sutun3TextBox++;
                    }
                }
                for (int i = 0; i < lDizi.Length; i++)
                {
                    lDizi[i] = new Label();
                    if (i <= 15)
                    {
                        lDizi[i].Text = (i + 1).ToString() + ".TAKSİT";
                        panelControl1.Controls.Add(lDizi[i]);
                        lDizi[i].Top = i * 25;
                        lDizi[i].Left = 1;
                        lDizi[i].Width = 60;
                    }
                    if (i > 15 && i <= 30)
                    {

                        lDizi[i].Text = (i + 1).ToString() + ".TAKSİT";
                        panelControl1.Controls.Add(lDizi[i]);
                        lDizi[i].Top = sutun2label * 25;
                        lDizi[i].Left = 235;
                        lDizi[i].Width = 75;
                        sutun2label++;
                    }
                    if (i > 30 && i <= 50)
                    {

                        lDizi[i].Text = (i + 1).ToString() + ".TAKSİT";
                        panelControl1.Controls.Add(lDizi[i]);
                        lDizi[i].Top = sutun3label * 25;
                        lDizi[i].Left = 483;
                        lDizi[i].Width = 75;
                        sutun3label++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Taksit sayısı giriniz!");
            }
        }

        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            DateTime tarih = date_taksitbaslama.Value;
            DateTime[] tarihEkle = new DateTime[sayisi];
            decimal[] taksitEkle = new decimal[sayisi];
            for (int i = 0; i < sayisi; i++)
            {
                taksitEkle[i] = Convert.ToDecimal(taksit[i].Text);
                int x = tarih.Month;
                if (x == 12 && tarih.Year == date_taksitbaslama.Value.Year)
                {
                    tarihEkle[i] = tarih.AddYears(1);
                }
                //if (x == 12 && tarih.Year == date_taksitbaslama.Value.Year+1)
                //{
                //    tarihEkle[i] = tarih.AddYears(1);
                //}
                tarihEkle[i] = tarih.AddMonths(i);

            }
            //if (sayisi <= 12)
            //{
            //    for (int i = sayisi + 1; i <= 12; i++)
            //    {
            //        taksit[i].Text = 0.ToString();
            //    }
            //}
            if (sayisi <= 12)
            {
                for (int i = sayisi + 1; i <= 12; i++)
                {
                    taksitEkle = new decimal[12];
                    taksitEkle[i] = 0;

                }
                string mesaj = odemeManage.OdemePlanlariKaydet(Convert.ToDecimal(taksit[0].Text), tarihEkle[0], Convert.ToDecimal(taksit[1].Text), tarihEkle[1], Convert.ToDecimal(taksit[2].Text), tarihEkle[2], Convert.ToDecimal(taksit[3].Text), tarihEkle[3], Convert.ToDecimal(taksit[4].Text), tarihEkle[4], Convert.ToDecimal(taksit[5].Text), tarihEkle[5], Convert.ToDecimal(taksit[6].Text), tarihEkle[6], Convert.ToDecimal(taksit[7].Text), tarihEkle[7], Convert.ToDecimal(taksit[8].Text), tarihEkle[8], Convert.ToDecimal(taksit[9].Text), tarihEkle[9], Convert.ToDecimal(taksit[10].Text), tarihEkle[10], Convert.ToDecimal(taksit[11].Text), tarihEkle[11], kullanici_IDTut);
                MessageBox.Show(mesaj);
            }
            else
            {
                string mesaj = odemeManage.OdemePlanlariKaydet(Convert.ToDecimal(taksit[0].Text), tarihEkle[0], Convert.ToDecimal(taksit[1].Text), tarihEkle[1], Convert.ToDecimal(taksit[2].Text), tarihEkle[2], Convert.ToDecimal(taksit[3].Text), tarihEkle[3], Convert.ToDecimal(taksit[4].Text), tarihEkle[4], Convert.ToDecimal(taksit[5].Text), tarihEkle[5], Convert.ToDecimal(taksit[6].Text), tarihEkle[6], Convert.ToDecimal(taksit[7].Text), tarihEkle[7], Convert.ToDecimal(taksit[8].Text), tarihEkle[8], Convert.ToDecimal(taksit[9].Text), tarihEkle[9], Convert.ToDecimal(taksit[10].Text), tarihEkle[10], Convert.ToDecimal(taksit[11].Text), tarihEkle[11], kullanici_IDTut);
                MessageBox.Show(mesaj);
            }
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            string mesaj = odemeManage.OdemePlanlariSil(odemeplani_id);
            odemeManage.OdemePlanlariListesi(gridControlOdemePlani);
            MessageBox.Show(mesaj);
        }
        private void btn_listeyigoster_Click(object sender, EventArgs e)
        {
            gridControlOdemePlani.Visible = true;
        }
        #endregion
        #region Odemeler

        private void cmbx_musterituru_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                musterituru_id = (int)cmbx_musterituru.SelectedValue;
            }
            catch (Exception)
            {
                if (cmbx_musterituru.Text == "Bireysel")
                {
                    cmb_musteri.DataSource = odemeManage.BireyselMusteriListesi();
                    cmb_musteri.DisplayMember = "Adi";
                    cmb_musteri.ValueMember = "BireyselMustrilerID";
                }
                else if (cmbx_musterituru.Text == "Kurumsal")
                {
                    cmb_musteri.DataSource = odemeManage.KurumsalMusteriListesi();
                    cmb_musteri.DisplayMember = "KurumAdi";
                    cmb_musteri.ValueMember = "KurumsalMusterilerID";

                }
                else
                {
                    cmb_musteri.DataSource = odemeManage.BireyselMusteriListesi();
                    cmb_musteri.DisplayMember = "Adi";
                    cmb_musteri.ValueMember = "BireyselMustrilerID";

                }


            }
        }

        private void toolStripOdemeKaydet_Click(object sender, EventArgs e)
        {
            string kaydet = odemeManage.OdemelerKaydet(musterituru_id, musteri_id, odemeplani_id, kullanici_IDTut);
            odemeManage.OdemelerListesi(gridControlOdemeler);
            MessageBox.Show(kaydet);
        }

        private void cmb_musteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                musteri_id = (int)cmb_musteri.SelectedValue;
            }
            catch (Exception)
            {


            }
        }

        private void cmb_odemeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                odemeplani_id = (int)cmb_odemeler.SelectedValue;
            }
            catch (Exception)
            {

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            musterituru_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("MusteriTuruID").ToString());
            cmbx_musterituru.Text = odemeManage.MusteriTuruAdi(musterituru_id);
            musteri_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("MusteriID").ToString());
            cmb_musteri.Text = odemeManage.MusteriAdi(musteri_id, musterituru_id);
            odemeplani_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("OdemePlaniID").ToString());

        }

        

        private void toolStripOdemeGuncelle_Click(object sender, EventArgs e)
        {
            string guncelle = odemeManage.OdemelerGuncelle(musterituru_id, musteri_id, odemeplani_id, kullanici_IDTut);
            odemeManage.OdemelerListesi(gridControlOdemeler);
            MessageBox.Show(guncelle);
        }

        private void toolStripOdemeSil_Click(object sender, EventArgs e)
        {
            string sil = odemeManage.OdemelerSil(musterituru_id, musteri_id, odemeplani_id);
            odemeManage.OdemelerListesi(gridControlOdemeler);
            MessageBox.Show(sil);
        }

        private void cmb_parabirimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            parabirimi_id = (int)cmb_parabirimi.SelectedValue;
        }
        #endregion

        #region Odeme Turleri
        private void toolStripOdmturuKaydet_Click(object sender, EventArgs e)
        {
            string mesaj = odemeManage.OdemeTurleriKaydet(cmb_odemturuadi.Text, parabirimi_id, txt_aciklama.Text, kullanici_IDTut);
            odemeManage.OdemeTurleriListesi(gridControl1OdemeTuru);
            MessageBox.Show(mesaj);
        }

        private void toolStripOdmTuruGuncelle_Click(object sender, EventArgs e)
        {
            string mesaj = odemeManage.OdemeTurleriGuncelle(odemeturleri_id,cmb_odemturuadi.Text, parabirimi_id, txt_aciklama.Text, kullanici_IDTut);
            odemeManage.OdemeTurleriListesi(gridControl1OdemeTuru);
            MessageBox.Show(mesaj);
        }

        private void toolStripOdmTuruSil_Click(object sender, EventArgs e)
        {
            string mesaj = odemeManage.OdemeTurleriSil(odemeturleri_id);
            odemeManage.OdemeTurleriListesi(gridControl1OdemeTuru);
            MessageBox.Show(mesaj);
        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                odemeturleri_id = Convert.ToInt32(gridView3.GetFocusedRowCellValue("OdemeTurleriID").ToString());
                cmb_odemturuadi.Text = gridView3.GetFocusedRowCellValue("TurAdi").ToString();
                parabirimi_id = Convert.ToInt32(gridView3.GetFocusedRowCellValue("ParaBirimiID").ToString());
                cmb_parabirimi.Text = odemeManage.OdemeTurleriParaBirimiTuruAdi(parabirimi_id);
                txt_aciklama.Text = gridView3.GetFocusedRowCellValue("Aciklama").ToString();
            }
            catch (Exception)
            {
               
            }

        }
        #endregion


    }
}
