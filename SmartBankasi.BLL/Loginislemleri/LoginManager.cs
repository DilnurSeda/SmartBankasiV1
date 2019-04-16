using SmartBankasi.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankasi.BLL.Loginislemleri
{
    public class LoginManager : ILogin
    {
        SmartBankDBEntities db = new SmartBankDBEntities();

        //************************************************
        public string kullaniciAdiSoyadi;
        public int yetki_IDclass;
        public int kullanici_id;
        //***************************************

        public bool Login(string kullaniciAdi, string kullanicisifre)
        {
            var giris = db.Kullanicilar.Where(k => k.KullaniciAdi == kullaniciAdi && k.KullaniciSifre == kullanicisifre).FirstOrDefault();
            if (giris != null)
            {
                kullaniciAdiSoyadi = giris.PersonelAdi + " " + giris.PersonelSoyadi;
                yetki_IDclass = (int)giris.YetkiID;
                kullanici_id = (int)giris.KullanicilarID;
                return true;
            }
            return false;
            
        }
    }
}
