using SmartBankasi.BLL.Kullaniciislemleri;
using SmartBankasi.BLL.Loginislemleri;
using SmartBankasi.DLL;
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
    public partial class Frm_Kullanicilar : Form
    {
        public Frm_Kullanicilar()
        {
            InitializeComponent();
        }
        SmartBankDBEntities db = new SmartBankDBEntities();
        KullanicilarManager kullanicimng = new KullanicilarManager();
        //LoginManager logManager = new LoginManager();
        //*********************
        int yetki_id;
        int kullaniciid;
        public int kullanici_IDTut;
        //**********************

        private void FrmKullanicilar_Load(object sender, EventArgs e)
        {
            kullanicimng.kullaniciListesi(gridControlKullanici);
        }
        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            string sonuc = kullanicimng.kullaniciKaydet(mtb_tc.Text, txt_Adi.Text, txt_soyadi.Text, txt_kullaniciAdi.Text, txt_sifresi.Text, yetki_id, kullanici_IDTut);
            MessageBox.Show(sonuc);
            kullanicimng.kullaniciListesi(gridControlKullanici);
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            string sonuc = kullanicimng.kullaniciGuncelle(kullaniciid,mtb_tc.Text, txt_Adi.Text, txt_soyadi.Text, txt_kullaniciAdi.Text, txt_sifresi.Text, yetki_id, kullanici_IDTut);
            MessageBox.Show(sonuc);
            kullanicimng.kullaniciListesi(gridControlKullanici);
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            string sonuc = kullanicimng.kullaniciSil(kullaniciid);
            MessageBox.Show(sonuc);
            kullanicimng.kullaniciListesi(gridControlKullanici);
        }


        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                kullaniciid = Convert.ToInt32(gridView1.GetFocusedRowCellValue("KullanicilarID").ToString());
                mtb_tc.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
                txt_Adi.Text = gridView1.GetFocusedRowCellValue("PersonelAdi").ToString();
                txt_soyadi.Text = gridView1.GetFocusedRowCellValue("PersonelSoyadi").ToString();
                txt_kullaniciAdi.Text = gridView1.GetFocusedRowCellValue("KullaniciAdi").ToString();
                txt_sifresi.Text = gridView1.GetFocusedRowCellValue("KullaniciSifre").ToString();
                yetki_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("YetkiID").ToString());
                //logManager.kullanici_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("KullaniciID").ToString());
            }
            catch (Exception)
            {

          
            }
        }
    }
}
