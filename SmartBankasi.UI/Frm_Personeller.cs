using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartBankasi.BLL.Personelislemleri;
using SmartBankasi.BLL.ililceSecimi;
using SmartBankasi.BLL.Loginislemleri;

namespace SmartBankasi.UI
{
    public partial class Frm_Personeller : Form
    {
        public Frm_Personeller()
        {
            InitializeComponent();
        }

        string mesajPersonel;
        int personel_id;
        int personeldetay_id;
        int personelgorevyerleri_id,gorev_id, sube_id;        
        int personelmaaslari_id;
        PersonelManager perManage = new PersonelManager();
        ililceGetir il_ilceGetir = new ililceGetir();
        //LoginManager logManager = new LoginManager();
        public int kullanici_IDTut;
        //****************************************************
        TextBox resimYolu = new TextBox();
        //**************************************************
        private void Frm_Personeller_Load(object sender, EventArgs e)
        {
            il_ilceGetir.illerListesi(cmb_dogumyeri);
            cm_gorevler.DisplayMember = "GorevAdi";
            cm_gorevler.ValueMember = "GorevlerID";
            perManage.gorevListesi(cm_gorevler);
            //------------------------------------
            cmb_subeler.DisplayMember = "SubeAdi";
            cmb_subeler.ValueMember = "SubelerID";
            perManage.subeListesi(cmb_subeler);
            //***************************************
            perManage.PersonelListesi(gridControl1);
            perManage.PersonelDetayListesi(gridControl2,personel_id);
            perManage.PersonelGorevYerleriListesi(gridControl3, personel_id);
            perManage.PersonelMaasListesi(gridControl4, personel_id);

        }
        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPage2)
            {
                perManage.PersonelDetayListesi(gridControl2, personel_id);
            }
            if (xtraTabControl1.SelectedTabPage == xtraTabPage3)
            {
                perManage.PersonelGorevYerleriListesi(gridControl3, personel_id);
            }
            if (xtraTabControl1.SelectedTabPage == xtraTabPage4)
            {
                perManage.PersonelMaasListesi(gridControl4, personel_id);
            }
        }

        #region Personeller
        private void btnperresim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picturePerresim.ImageLocation = openFileDialog1.FileName;
            //MessageBox.Show(openFileDialog1.FileName);

            resimYolu.Text = openFileDialog1.FileName;
        }

        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            mesajPersonel = perManage.PersonelKaydet(mtb_TC.Text, txt_PersonelAdi.Text, txt_PersonelsoyAdi.Text, cmb_cinsiyet.Text, MedeniHali(), cmb_dogumyeri.Text, Convert.ToDateTime(date_dogumtarihi.Value).ToString(), resimYolu.Text,kullanici_IDTut);
            perManage.PersonelListesi(gridControl1);
            MessageBox.Show(mesajPersonel);
        }

        private void cmb_dogumyeri_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                personel_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("PersonellerID").ToString());
                mtb_TC.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
                txt_PersonelAdi.Text = gridView1.GetFocusedRowCellValue("Adi").ToString();
                txt_PersonelsoyAdi.Text = gridView1.GetFocusedRowCellValue("Soyadi").ToString();
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
                resimYolu.Text = gridView1.GetFocusedRowCellValue("Resim").ToString();
                //kullanici_IDTut = Convert.ToInt32(gridView1.GetFocusedRowCellValue("KullaniciID").ToString());



                if (!string.IsNullOrWhiteSpace(resimYolu.Text))
                {
                    picturePerresim.Image = Image.FromFile("C:\\Users\\dilnur.engin\\Pictures\\smartbank\\login_user.png");
                }
                else
                {
                    picturePerresim.ImageLocation = gridView1.GetFocusedRowCellValue("Resim").ToString();
                }

            }
            catch (Exception)
            {

            }


        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            mesajPersonel = perManage.PersonelGuncelle(personel_id, mtb_TC.Text, txt_PersonelAdi.Text, txt_PersonelsoyAdi.Text, cmb_cinsiyet.Text, MedeniHali(), cmb_dogumyeri.Text, Convert.ToDateTime(date_dogumtarihi.Value).ToString(), resimYolu.Text, kullanici_IDTut);
            perManage.PersonelListesi(gridControl1);
            MessageBox.Show(mesajPersonel);
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            mesajPersonel = perManage.PersonelSil(personel_id);
            perManage.PersonelListesi(gridControl1);
            MessageBox.Show(mesajPersonel);
        }

        #endregion

        #region Personel Detayları
        private void toolStripAyrintiKaydet_Click(object sender, EventArgs e)
        {
            if (date_cikisTarihi.Visible == false)
            {
                mesajPersonel = perManage.PersonelDetayKaydet(date_girisTarihi.Value, null, personel_id, kullanici_IDTut);
                perManage.PersonelDetayListesi(gridControl2, personel_id);
                MessageBox.Show(mesajPersonel);
            }
            else if (date_cikisTarihi.Visible == true)
            {
                mesajPersonel = perManage.PersonelDetayKaydet(date_girisTarihi.Value, date_cikisTarihi.Value, personel_id, kullanici_IDTut);
                perManage.PersonelDetayListesi(gridControl2, personel_id);
                MessageBox.Show(mesajPersonel);
            }
        }

        private void btnCikisTarihiEkle_Click(object sender, EventArgs e)
        {
            date_cikisTarihi.Visible = true;
            labelCikis.Visible = true;
        }

        private void btnVazgecCikis_Click(object sender, EventArgs e)
        {
            date_cikisTarihi.Visible = false;
            labelCikis.Visible = false;
        }

        private void toolStripAyrintiGuncelle_Click(object sender, EventArgs e)
        {
            if (date_cikisTarihi.Visible == false)
            {
                mesajPersonel = perManage.PersonelDetayGuncelle(personeldetay_id, date_girisTarihi.Value, null, personel_id, kullanici_IDTut);
                perManage.PersonelDetayListesi(gridControl2, personel_id);
                MessageBox.Show(mesajPersonel);
            }
            else if (date_cikisTarihi.Visible == true)
            {
                mesajPersonel = perManage.PersonelDetayGuncelle(personeldetay_id, date_girisTarihi.Value, date_cikisTarihi.Value, personel_id, kullanici_IDTut);
                perManage.PersonelDetayListesi(gridControl2, personel_id);
                MessageBox.Show(mesajPersonel);
            }
        }

        private void toolStripAyrintiSil_Click(object sender, EventArgs e)
        {
            mesajPersonel = perManage.PersonelDetaySil(personeldetay_id);
            perManage.PersonelDetayListesi(gridControl2, personel_id);
            MessageBox.Show(mesajPersonel);
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                personeldetay_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("PersonelDetaylariID").ToString());
                date_girisTarihi.Value = Convert.ToDateTime(gridView2.GetFocusedRowCellValue("GirisTarihi").ToString());
                date_cikisTarihi.Value = Convert.ToDateTime(gridView2.GetFocusedRowCellValue("CikisTarihi").ToString());
                personel_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("PersonelID").ToString());
                //kullanici_IDTut = Convert.ToInt32(gridView1.GetFocusedRowCellValue("KullaniciID").ToString());
            }
            catch (Exception)
            {


            }
        }
        #endregion

        #region Personel Görev Yerleri
        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                personelgorevyerleri_id = Convert.ToInt32(gridView3.GetFocusedRowCellValue("PersonelGorevYerleriID").ToString());
                personel_id = Convert.ToInt32(gridView3.GetFocusedRowCellValue("PersonelID").ToString());
                date_baslangicTarihi.Value = Convert.ToDateTime(gridView3.GetFocusedRowCellValue("BaslangicTarihi").ToString());
                date_bitisTarihi.Value = Convert.ToDateTime(gridView3.GetFocusedRowCellValue("BitisTarihi").ToString());
                gorev_id = Convert.ToInt32(gridView3.GetFocusedRowCellValue("GorevID").ToString());
                cm_gorevler.Text = perManage.GorevAdi(gorev_id);
                sube_id = Convert.ToInt32(gridView3.GetFocusedRowCellValue("SubeID").ToString());
                cmb_subeler.Text = perManage.SubeAdi(sube_id);
            }
            catch (Exception)
            {

               
            }
        }

        private void toolStripGorevYeriKaydet_Click(object sender, EventArgs e)
        {
            if (date_bitisTarihi.Visible == false)
            {
                mesajPersonel = perManage.PersonelGorevYerleriKaydet(personel_id,date_baslangicTarihi.Value, null, gorev_id, sube_id, kullanici_IDTut);
                perManage.PersonelGorevYerleriListesi(gridControl3, personel_id);
                MessageBox.Show(mesajPersonel);
            }
            else if (date_bitisTarihi.Visible == true)
            {
                mesajPersonel = perManage.PersonelGorevYerleriKaydet(personel_id, date_baslangicTarihi.Value, date_bitisTarihi.Value, gorev_id, sube_id, kullanici_IDTut);
                perManage.PersonelGorevYerleriListesi(gridControl3, personel_id);
                MessageBox.Show(mesajPersonel);
            }
        }
     
        private void toolStripGorevYeriGuncelle_Click(object sender, EventArgs e)
        {
            if (date_bitisTarihi.Visible == false)
            {
                mesajPersonel = perManage.PersonelGorevYerleriGuncelle(personelgorevyerleri_id, personel_id, date_baslangicTarihi.Value, null, gorev_id, sube_id, kullanici_IDTut);
                perManage.PersonelGorevYerleriListesi(gridControl3, personel_id);
                MessageBox.Show(mesajPersonel);
            }
            else if(date_bitisTarihi.Visible == true)
            {
                mesajPersonel = perManage.PersonelGorevYerleriGuncelle(personelgorevyerleri_id, personel_id, date_baslangicTarihi.Value, date_bitisTarihi.Value, gorev_id, sube_id, kullanici_IDTut);
                perManage.PersonelGorevYerleriListesi(gridControl3, personel_id);
                MessageBox.Show(mesajPersonel);
            }
        }

        private void toolStripGorevYeriSil_Click(object sender, EventArgs e)
        {
            mesajPersonel = perManage.PersonelGorevYerleriSil(personelgorevyerleri_id);
            perManage.PersonelGorevYerleriListesi(gridControl3, personel_id);
            MessageBox.Show(mesajPersonel);
        }
        #endregion

        #region Personel Maaşları

        private void toolStripButtonMaasKaydet_Click(object sender, EventArgs e)
        {
            mesajPersonel = perManage.PersonelMaasKaydet(date_mbaslangictarihi.Value, date_mbitistarihi.Value, Convert.ToDecimal(txt_maas.Text), personel_id, kullanici_IDTut);
            perManage.PersonelMaasListesi(gridControl4, personel_id);
            MessageBox.Show(mesajPersonel);
        }

        private void gridView4_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                personelmaaslari_id = Convert.ToInt32(gridView4.GetFocusedRowCellValue("PersonelMaaslarID").ToString());
                date_baslangicTarihi.Value = Convert.ToDateTime(gridView4.GetFocusedRowCellValue("MaasBaslangicTarihi").ToString());
                date_bitisTarihi.Value = Convert.ToDateTime(gridView4.GetFocusedRowCellValue("MaasBitisTarihi").ToString());
                txt_maas.Text = gridView4.GetFocusedRowCellValue("Maas").ToString();
                personel_id = Convert.ToInt32(gridView4.GetFocusedRowCellValue("PersonelID").ToString());
            }
            catch (Exception)
            {

               
            }

        }

        private void cm_gorevler_SelectedIndexChanged(object sender, EventArgs e)
        {
            gorev_id = (int)cm_gorevler.SelectedValue;
        }

        private void cmb_subeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            sube_id = (int)cmb_subeler.SelectedValue;
        }

        private void toolStripButtonMaasGuncelle_Click(object sender, EventArgs e)
        {
            mesajPersonel = perManage.PersonelMaasGuncelle(personelmaaslari_id,date_mbaslangictarihi.Value, date_mbitistarihi.Value, Convert.ToDecimal(txt_maas.Text), personel_id, kullanici_IDTut);
            perManage.PersonelMaasListesi(gridControl4, personel_id);
            MessageBox.Show(mesajPersonel);
        }

        private void toolStripButtonMaasSil_Click(object sender, EventArgs e)
        {
            mesajPersonel = perManage.PersonelMaasSil(personelmaaslari_id);
            perManage.PersonelMaasListesi(gridControl4, personel_id);
            MessageBox.Show(mesajPersonel);
        } 
        #endregion


    }
}
