using DevExpress.XtraGrid;
using SmartBankasi.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankasi.BLL.Personelislemleri
{
    interface IPersonel
    {
        #region Personel Bilgisi
        void PersonelListesi(GridControl gridliste);
        string PersonelKaydet(string tc, string adi, string soyadi, string cinsiyet, bool medenihali, string dogumyeri, string dogumtarihi, string resim, int kullaniciid);
        //***
        string PersonelGuncelle(int personellerid, string tc, string adi, string soyadi, string cinsiyet, bool medenihali, string dogumyeri, string dogumtarihi, string resim, int kullaniciid);
        //***
        string PersonelSil(int personellerid);

        #endregion

        #region Personel Detay
        void PersonelDetayListesi(GridControl gridliste, int personelid);

        string PersonelDetayKaydet(DateTime giristarihi, DateTime? cikistarihi, int personelid, int kullaniciid);

        string PersonelDetayGuncelle(int personeldetayid,DateTime giristarihi, DateTime? cikistarihi, int personelid, int kullaniciid);

        string PersonelDetaySil(int personeldetayid);

        #endregion

        #region Personel Görev Yerleri

        void PersonelGorevYerleriListesi(GridControl gridliste, int personelid);
        string PersonelGorevYerleriKaydet(int personelid, DateTime baslangictarihi, DateTime? bitistarihi, int gorevid, int subeid, int kullaniciid);
        string PersonelGorevYerleriGuncelle(int personelgorevyerleriid, int personelid, DateTime baslangictarihi, DateTime? bitistarihi, int gorevid, int subeid, int kullaniciid);
        string PersonelGorevYerleriSil(int personelgorevyerleriid);
        #endregion

        #region Personel Maasları
        void PersonelMaasListesi(GridControl gridliste, int personelid);
        string PersonelMaasKaydet(DateTime maasbaslangictarihi, DateTime maasbitistarihi, decimal maas, int personelid, int kullaniciid);
        string PersonelMaasGuncelle(int personelmaaslariid, DateTime maasbaslangictarihi, DateTime maasbitistarihi, decimal maas, int personelid, int kullaniciid);
        string PersonelMaasSil(int personelmaaslariid); 
        #endregion

    }
}
