using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankasi.BLL.Urunislemleri
{
    interface IUrunler
    {
        #region Ürünler
        string UrunlerKaydet(string urunadi, int urunturuid, string aciklama, int kullaniciid);
        string UrunlerGuncelle(int urunlerid, string urunadi, int urunturuid, string aciklama, int kullaniciid);
        string UrunlerSil(int urunlerid);
        void UrunlerListesi(GridControl gridliste);
        #endregion

        #region Ürün Detayları
        string UrunlerDetayKaydet(string urundetaybilgisi, int urunid, int kullaniciid);
        string UrunlerDetayGuncelle(int urundetayid, string urundetaybilgisi, int urunid, int kullaniciid);
        string UrunlerDetaySil(int urundetayid);
        void UrunlerDetayListesi(GridControl gridliste,int urunid); 
        #endregion


    }
}
