using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankasi.BLL.Musteriislemleri
{
    interface IMusteriler
    {
        #region Bireysel Müşteriler
        void BireyselMusteriListesi(GridControl gridliste);

        string BireyselMusteriKaydet(string tc, string adi, string soyadi, string cinsiyet, bool medenihali, string dogumyeri, string dogumtarihi, string email, string telefon, string meslek, decimal aylikkazanc, decimal maas, string adres,int musteriturid, int kullaniciid);

        string BireyselMusteriGuncelle(int bireyselmusteriid, string tc, string adi, string soyadi, string cinsiyet, bool medenihali, string dogumyeri, string dogumtarihi, string email, string telefon, string meslek, decimal aylikkazanc, decimal maas, string adres, int musteriturid, int kullaniciid);

        string BireyselMusteriSil(int bireyselmusteriid);
        #endregion

        #region Bireysel Müşteri Ürünleri
        void BireyselMusteriUrunleriListesi(GridControl gridliste, int bmusteriid);
        string BireyselMusteriUrunleriKaydet(int urunid, string iban, string hesapno, int bireyselmusteriid, int kullaniciid);
        string BireyselMusteriUrunleriGuncelle(int bireyselmusteriurunid, int urunid, string iban, string hesapno, int bireyselmusteriid, int kullaniciid);
        string BireyselMusteriUrunleriSil(int bireyselmusteriurunid);
        #endregion

        #region Kurumsal Müşteriler
        void KurumsalMusteriListesi(GridControl gridliste);

        string KurumsalMusteriKaydet(string kurumadi, string kurumadres, string tel1, string tel2, string email, string aciklama, int musteriturid, int kullaniciid);

        string KurumsalMusteriGuncelle(int kurumsalmusteriid, string kurumadi, string kurumadres, string tel1, string tel2, string email, string aciklama, int musteriturid, int kullaniciid);

        string KurumsalMusteriSil(int kurumsalmusteriid);
        #endregion

        #region Kurumsal Yetkililer
        void KurumsalYetkiliListesi(GridControl gridliste, int kurumsalmusteriid);
        string KurumsalYetkiliKaydet(string tc, string adi, string soyadi, string gorevi, string tel1, string tel2, string email, int kurumsalmusteriid, int kullaniciid);
        string KurumsalYetkiliGuncelle(int kurumsalyetkiliid, string tc, string adi, string soyadi, string gorevi, string tel1, string tel2, string email, int kurumsalmusteriid, int kullaniciid);
        string KurumsalYetkiliSil(int kurumsalyetkiliid); 
        #endregion

        #region Kurumsal Müşteri Ürünleri
        string KurumsalMusteriUrunleriGuncelle(int kurumsalmusteriurunid, int urunid, int kurumsalyetkiliid, string iban, string hesapno, int kullaniciid);
        string KurumsalMusteriUrunleriKaydet(int urunid, int kurumsalyetkiliid, string iban, string hesapno, int kullaniciid);
        void KurumsalMusteriUrunleriListesi(GridControl gridliste, int kurumsalyetkiliid);
        string KurumsalMusteriUrunleriSil(int kurumsalmusteriurunid); 
        #endregion

    }
}
