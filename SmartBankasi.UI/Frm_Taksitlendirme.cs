using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartBankasi.BLL.MusteriTurleriislemleri;
using SmartBankasi.BLL.Odemeislemleri;

namespace SmartBankasi.UI
{
    public partial class frm_Taksitlendirme : Form
    {
        public frm_Taksitlendirme()
        {
            InitializeComponent();
        }
        public int kullanici_IDTut;
        MusteriTurleriManager mtmanage = new MusteriTurleriManager();
        OdemelerManager odemeManage = new OdemelerManager();
        //int sayisi = Convert.ToInt32(txt_taksitsayisi.Text);
        //int sayisi = 0;


        private decimal FaizHesabi(decimal miktar,int taksitsayisi)
        {
            if (taksitsayisi>0 && taksitsayisi<=12)
            {
                miktar = miktar + miktar * 0.015m;
            }
            if (taksitsayisi>12 && taksitsayisi<=24)
            {
                miktar = miktar + miktar * 0.019m;
            }
            if (taksitsayisi > 24 && taksitsayisi <= 36)
            {
                miktar = miktar + miktar * 0.022m;
            }
            return miktar;
        }

        TextBox[] taksit;
        int sayisi;

        private void TaksitSayisi12denAz()
        {
            if (sayisi <= 12)
            {
                for (int i = sayisi + 1; i <= 12; i++)
                {
                    taksit[i].Text = 0.ToString();
                }
            }
        }
        private void btn_taksitolustur_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(txt_taksitsayisi.Text))
            {
                //*******************************************************
                //*******************************************************
                sayisi = Convert.ToInt32(txt_taksitsayisi.Text);
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
                decimal aylikOdeme = FaizHesabi(krediMiktari, sayisi)/sayisi;
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

        private void frm_Taksitlendirme_Load(object sender, EventArgs e)
        {
            mtmanage.MusteriTurleri(cmb_musterituru);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if ((int)cmb_musterituru.SelectedValue==1)
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

        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            DateTime tarih = date_taksitbaslama.Value;
            DateTime[] tarihEkle = new DateTime[sayisi];
            decimal[] taksitEkle = new decimal[sayisi];            
            for (int i = 0; i < sayisi; i++)
            {
                taksitEkle[i] = Convert.ToDecimal(taksit[i].Text);
                int x = tarih.Month;
                if (x==12 && tarih.Year==date_taksitbaslama.Value.Year)
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
            if (sayisi<=12)
            {
                for (int i = sayisi+1; i <=12 ; i++)
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

     
    }
}
