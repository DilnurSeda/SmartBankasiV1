using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using SmartBankasi.DLL;
using System.Windows.Forms;

namespace SmartBankasi.BLL.Urunislemleri
{
    public class UrunlerManager : IUrunler
    {
        SmartBankDBEntities db = new SmartBankDBEntities();

        #region Ürünler
        public string UrunlerGuncelle(int urunlerid, string urunadi, int urunturuid, string aciklama, int kullaniciid)
        {
            try
            {
                var guncelle = db.Urunler.Where(k => k.UrunlerID == urunlerid).FirstOrDefault();

                guncelle.UrunAdi = urunadi;
                guncelle.UrunTuruID = urunturuid;
                guncelle.Aciklama = aciklama;
                guncelle.KullaniciID = kullaniciid;

                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Güncelleme işlemi başarılı";
                }
                else
                {
                    return "Güncelleme yapılamadı";
                }
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
        }

        public string UrunlerKaydet(string urunadi, int urunturuid, string aciklama, int kullaniciid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(urunadi))
                {
                    Urunler ekle = new Urunler();
                    ekle.UrunAdi = urunadi;
                    ekle.UrunTuruID = urunturuid;
                    ekle.Aciklama = aciklama;
                    ekle.KullaniciID = kullaniciid;

                    db.Urunler.Add(ekle);

                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        return "Kayıt işlemi başarılı";
                    }
                    else
                    {
                        return "Kayıt yapılamadı";
                    }

                }
                return "Lütfen ürün adı giriniz!";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
           
        }

        public void UrunlerListesi(GridControl gridliste)
        {
            gridliste.DataSource=db.Urunler.ToList();
        }

        public string UrunlerSil(int urunlerid)
        {
            try
            {
                var sil = db.Urunler.Where(p => p.UrunlerID == urunlerid).FirstOrDefault();

                DialogResult onay = MessageBox.Show("Silmek istediğinize emin misniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
                if (onay == DialogResult.OK)
                {
                    db.Urunler.Remove(sil);
                    int silSonuc = db.SaveChanges();
                    if (silSonuc > 0)
                    {
                        return " Urun silindi";
                    }
                }
                return "silme başarısız";
            }
            catch (Exception)
            {

                return "Bir hata oluştu tekrar deneyiniz.";
            }
        }
        public void UrunTuruListele(ComboBox cmb_urunturuid)
        {
            cmb_urunturuid.DisplayMember = "Adi";
            cmb_urunturuid.ValueMember = "UrunTurleriID";
            cmb_urunturuid.DataSource = db.UrunTurleri.ToList();
            //cmb_urunturuid.SelectedIndex = -1;
        }
        public string UrunTurAdi(int urunturid)
        {
            var urunturu = db.UrunTurleri.Where(k => k.UrunTurleriID == urunturid).FirstOrDefault();
            return urunturu.Adi;
        }
        #endregion

        #region Ürün Detayları

        public string UrunlerDetayGuncelle(int urundetayid, string urundetaybilgisi, int urunid, int kullaniciid)
        {
            try
            {
                var guncelle = db.UrunDetaylari.Where(k => k.UrunDetaylariID == urundetayid).FirstOrDefault();

                guncelle.DetayBilgisi = urundetaybilgisi;
                guncelle.UrunID = urunid;
                guncelle.KullaniciID = kullaniciid;

                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Güncelleme işlemi başarılı";
                }
                else
                {
                    return "Güncelleme yapılamadı";
                }
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
        }

        public string UrunlerDetayKaydet(string urundetaybilgisi, int urunid, int kullaniciid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(urundetaybilgisi))
                {
                    UrunDetaylari ekle = new UrunDetaylari();
                    ekle.DetayBilgisi = urundetaybilgisi;
                    ekle.UrunID = urunid;
                    ekle.KullaniciID = kullaniciid;

                    db.UrunDetaylari.Add(ekle);

                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        return "Kayıt işlemi başarılı";
                    }
                    else
                    {
                        return "Kayıt yapılamadı";
                    }

                }
                return "Lütfen ürün detay bilgisi giriniz!";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
        }

        public void UrunlerDetayListesi(GridControl gridliste,int urunid)
        {            
            gridliste.DataSource = db.UrunDetaylari.Where(k => k.UrunID == urunid).ToList();
        }

        public string UrunlerDetaySil(int urundetayid)
        {
            try
            {
                var sil = db.UrunDetaylari.Where(p => p.UrunDetaylariID == urundetayid).FirstOrDefault();

                DialogResult onay = MessageBox.Show("Silmek istediğinize emin misniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
                if (onay == DialogResult.OK)
                {
                    db.UrunDetaylari.Remove(sil);
                    int silSonuc = db.SaveChanges();
                    if (silSonuc > 0)
                    {
                        return " Urun detayı silindi";
                    }
                }
                return "silme başarısız";
            }
            catch (Exception)
            {

                return "Bir hata oluştu tekrar deneyiniz.";
            }
        } 
        #endregion
    }
}
