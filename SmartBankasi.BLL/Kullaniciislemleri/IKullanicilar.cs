using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankasi.BLL.Kullaniciislemleri
{
    interface IKullanicilar
    {
        string kullaniciKaydet(string tc,string adi, string soyadi, string kullaniciadi, string sifre, int yetkiId, int kullanici_id);

        string kullaniciGuncelle(int kullaniciid, string tc, string adi, string soyadi, string kullaniciadi, string sifre, int yetkiId, int kullanici_id);

        string kullaniciSil(int kullaniciid);

        void kullaniciListesi(GridControl gridliste);
    }
}
