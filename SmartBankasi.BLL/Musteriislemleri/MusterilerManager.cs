using DevExpress.XtraGrid;
using SmartBankasi.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBankasi.BLL.Musteriislemleri
{
    public class MusterilerManager : IMusteriler
    {
        SmartBankDBEntities db = new SmartBankDBEntities();

        #region Bireysel Müşteriler
        public string BireyselMusteriGuncelle(int bireyselmusteriid, string tc, string adi, string soyadi, string cinsiyet, bool medenihali, string dogumyeri, string dogumtarihi, string email, string telefon, string meslek, decimal aylikkazanc, decimal maas, string adres, int musteriturid, int kullaniciid)
        {
            try
            {
                var guncelle = db.BireyselMusteriler.Where(k => k.BireyselMustrilerID == bireyselmusteriid).FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(adi))
                {
                    guncelle.TC = tc;
                    guncelle.Adi = adi;
                    guncelle.Soyadi = soyadi;
                    guncelle.Cinsiyet = cinsiyet;
                    guncelle.MedeniHali = medenihali;
                    guncelle.DogumYeri = dogumyeri;
                    guncelle.DogumTarihi = Convert.ToDateTime(dogumtarihi);
                    guncelle.Email = email;
                    guncelle.Telefon = telefon;
                    guncelle.Meslek = meslek;
                    guncelle.AylikKazanci = aylikkazanc;
                    guncelle.Maas = maas;
                    guncelle.Adres = adres;
                    guncelle.MusteriTurID = musteriturid;
                    guncelle.KullaniciID = kullaniciid;

                    int sonucKaydet = db.SaveChanges();
                    if (sonucKaydet > 0)
                    {
                        return "Güncelleme işlemi Başarılı!";
                    }
                }
                return "Güncelleme Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }

        public string BireyselMusteriKaydet(string tc, string adi, string soyadi, string cinsiyet, bool medenihali, string dogumyeri, string dogumtarihi, string email, string telefon, string meslek, decimal aylikkazanc, decimal maas, string adres, int musteriturid, int kullaniciid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(adi) && !string.IsNullOrWhiteSpace(tc))
                {
                    BireyselMusteriler ekle = new BireyselMusteriler();
                    ekle.TC = tc;
                    ekle.Adi = adi;
                    ekle.Soyadi = soyadi;
                    ekle.Cinsiyet = cinsiyet;
                    ekle.MedeniHali = medenihali;
                    ekle.DogumYeri = dogumyeri;
                    ekle.DogumTarihi = Convert.ToDateTime(dogumtarihi);
                    ekle.Email=email;
                    ekle.Telefon = telefon;
                    ekle.Meslek = meslek;
                    ekle.AylikKazanci = aylikkazanc;
                    ekle.Maas = maas;
                    ekle.Adres = adres;
                    ekle.MusteriTurID = musteriturid;
                    ekle.KullaniciID = kullaniciid;

                    db.BireyselMusteriler.Add(ekle);
                    int sonucKaydet = db.SaveChanges();
                    if (sonucKaydet > 0)
                    {
                        return "Kayıt işlemi Başarılı!";
                    }
                }
                return "Kayıt Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }

        public void BireyselMusteriListesi(GridControl gridliste)
        {
            gridliste.DataSource = db.BireyselMusteriler.ToList();
        }

        public string BireyselMusteriSil(int bireyselmusteriid)
        {
            try
            {
                var sil = db.BireyselMusteriler.Where(p => p.BireyselMustrilerID == bireyselmusteriid).FirstOrDefault();

                DialogResult onay = MessageBox.Show("Silmek istediğinize emin misniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
                if (onay == DialogResult.OK)
                {
                    db.BireyselMusteriler.Remove(sil);
                    int silSonuc = db.SaveChanges();
                    if (silSonuc > 0)
                    {
                        return sil.Adi + " adlı müşteri silindi";
                    }
                }
                return "silme başarısız";
            }
            catch (Exception)
            {

                return "Bir hata oluştu tekrar deneyiniz.";
            }
        }
        public void AdaGoreAra(GridControl GridAdAra, string isim)
        {
            //Contains ile arama yapıyoruz
            GridAdAra.DataSource = db.BireyselMusteriler.Where(x => x.Adi.Contains(isim)).ToList();
        }
        public void TCGoreAra(GridControl GridAdAra, string isim)
        {
            //Contains ile arama yapıyoruz
            GridAdAra.DataSource = db.BireyselMusteriler.Where(x => x.TC.Contains(isim)).ToList();
        }


        #endregion

        #region Bireysel Müşteri Ürünleri
        public string BireyselMusteriUrunleriGuncelle(int bireyselmusteriurunid, int urunid, string iban, string hesapno, int bireyselmusteriid, int kullaniciid)
        {
            try
            {
                var guncelle = db.BireyselMusteriUrunleri.Where(k => k.BireyselMusteriUrunleriID == bireyselmusteriurunid).FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(iban))
                {
                    guncelle.UrunID = urunid;
                    guncelle.IBAN = iban;
                    guncelle.HesapNumarasi = hesapno;
                    guncelle.BireyselMusteriID= bireyselmusteriid;
                    guncelle.KullaniciID = kullaniciid;

                    int sonucKaydet = db.SaveChanges();
                    if (sonucKaydet > 0)
                    {
                        return "Güncelleme işlemi Başarılı!";
                    }
                }
                return "Güncelleme Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }

        public string BireyselMusteriUrunleriKaydet(int urunid, string iban, string hesapno, int bireyselmusteriid, int kullaniciid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(iban) && !string.IsNullOrWhiteSpace(hesapno))
                {
                    BireyselMusteriUrunleri ekle = new BireyselMusteriUrunleri();
                    ekle.UrunID = urunid;
                    ekle.IBAN = iban;
                    ekle.HesapNumarasi = hesapno;
                    ekle.BireyselMusteriID = bireyselmusteriid;
                    ekle.KullaniciID = kullaniciid;

                    db.BireyselMusteriUrunleri.Add(ekle);
                    int sonucKaydet = db.SaveChanges();
                    if (sonucKaydet > 0)
                    {
                        return "Kayıt işlemi Başarılı!";
                    }
                }
                return "Kayıt Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }
        public void BireyselMusteriUrunleriListesi(GridControl gridliste,int bmusteriid)
        {
            gridliste.DataSource = db.BireyselMusteriUrunleri.Where(k => k.BireyselMusteriID == bmusteriid).ToList();
        }

        public string BireyselMusteriUrunleriSil(int bireyselmusteriurunid)
        {
            try
            {
                var sil = db.BireyselMusteriUrunleri.Where(p => p.BireyselMusteriUrunleriID == bireyselmusteriurunid).FirstOrDefault();

                DialogResult onay = MessageBox.Show("Silmek istediğinize emin misniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
                if (onay == DialogResult.OK)
                {
                    db.BireyselMusteriUrunleri.Remove(sil);
                    int silSonuc = db.SaveChanges();
                    if (silSonuc > 0)
                    {
                        return "Müşteri ürün silindi";
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

        #region Kurumsal Müşteriler

        public void KurumsalMusteriListesi(GridControl gridliste)
        {
            gridliste.DataSource = db.KurumsalMusteriler.ToList();
        }

        public string KurumsalMusteriKaydet(string kurumadi, string kurumadres, string tel1, string tel2, string email, string aciklama,int musteriturid,int kullaniciid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(kurumadi) && !string.IsNullOrWhiteSpace(tel1))
                {
                    KurumsalMusteriler ekle = new KurumsalMusteriler();
                    ekle.KurumAdi = kurumadi;
                    ekle.KurumAdres = kurumadres;
                    ekle.Telefon1 = tel1;
                    ekle.Telefon2 = tel2;                   
                    ekle.Email = email;                    
                    ekle.Aciklama = aciklama;
                    ekle.MusteriTurID = musteriturid;
                    ekle.KullaniciID = kullaniciid;

                    db.KurumsalMusteriler.Add(ekle);
                    int sonucKaydet = db.SaveChanges();
                    if (sonucKaydet > 0)
                    {
                        return "Kayıt işlemi Başarılı!";
                    }
                }
                return "Kayıt Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }

        public string KurumsalMusteriGuncelle(int kurumsalmusteriid, string kurumadi, string kurumadres, string tel1, string tel2, string email, string aciklama, int musteriturid, int kullaniciid)
        {
            try
            {
                var guncelle = db.KurumsalMusteriler.Where(k => k.KurumsalMusterilerID == kurumsalmusteriid).FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(kurumadi))
                {
                    guncelle.KurumAdi = kurumadi;
                    guncelle.KurumAdres = kurumadres;
                    guncelle.Telefon1 = tel1;
                    guncelle.Telefon2 = tel2;               
                    guncelle.Email = email;
                    guncelle.Aciklama = aciklama;
                    guncelle.MusteriTurID = musteriturid;
                    guncelle.KullaniciID = kullaniciid;
                    

                    int sonucKaydet = db.SaveChanges();
                    if (sonucKaydet > 0)
                    {
                        return "Güncelleme işlemi Başarılı!";
                    }
                }
                return "Güncelleme Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }

        public string KurumsalMusteriSil(int kurumsalmusteriid)
        {
            try
            {
                var sil = db.KurumsalMusteriler.Where(p => p.KurumsalMusterilerID == kurumsalmusteriid).FirstOrDefault();

                DialogResult onay = MessageBox.Show("Silmek istediğinize emin misniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
                if (onay == DialogResult.OK)
                {
                    db.KurumsalMusteriler.Remove(sil);
                    int silSonuc = db.SaveChanges();
                    if (silSonuc > 0)
                    {
                        return sil.KurumAdi + " na ait müşteri silindi";
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

        #region Kurumsal Yetkililer
        public void KurumsalYetkiliListesi(GridControl gridliste,int kurumsalmusteriid)
        {
            gridliste.DataSource = db.KurumsalYetkililer.Where(k => k.KurumsalMusteriID == kurumsalmusteriid).ToList();
        }
        public string KurumsalYetkiliKaydet(string tc, string adi, string soyadi, string gorevi, string tel1, string tel2, string email, int kurumsalmusteriid, int kullaniciid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(adi) && !string.IsNullOrWhiteSpace(gorevi))
                {
                    KurumsalYetkililer ekle = new KurumsalYetkililer();
                    ekle.TC = tc;
                    ekle.Adi = adi;
                    ekle.Soyadi = soyadi;
                    ekle.Gorevi = gorevi;
                    ekle.Telefon1 = tel1;
                    ekle.Telefon2 = tel2;
                    ekle.Email = email;
                    ekle.KurumsalMusteriID = kurumsalmusteriid;
                    ekle.KullaniciID = kullaniciid;

                    db.KurumsalYetkililer.Add(ekle);
                    int sonucKaydet = db.SaveChanges();
                    if (sonucKaydet > 0)
                    {
                        return "Kayıt işlemi Başarılı!";
                    }
                }
                return "Kayıt Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }
        public string KurumsalYetkiliGuncelle(int kurumsalyetkiliid, string tc, string adi, string soyadi, string gorevi, string tel1, string tel2, string email, int kurumsalmusteriid, int kullaniciid)
        {

            try
            {
                var guncelle = db.KurumsalYetkililer.Where(k => k.KurumsalYetkililerID == kurumsalyetkiliid).FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(adi))
                {
                    guncelle.TC = tc;
                    guncelle.Adi = adi;
                    guncelle.Soyadi = soyadi;
                    guncelle.Gorevi = gorevi;
                    guncelle.Telefon1 = tel1;
                    guncelle.Telefon2 = tel2;
                    guncelle.Email = email;
                    guncelle.KurumsalMusteriID = kurumsalmusteriid;
                    guncelle.KullaniciID = kullaniciid;
                    

                    int sonucKaydet = db.SaveChanges();
                    if (sonucKaydet > 0)
                    {
                        return "Güncelleme işlemi Başarılı!";
                    }
                }
                return "Güncelleme Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }
        public string KurumsalYetkiliSil(int kurumsalyetkiliid)
        {
            try
            {
                var sil = db.KurumsalYetkililer.Where(p => p.KurumsalYetkililerID == kurumsalyetkiliid).FirstOrDefault();

                DialogResult onay = MessageBox.Show("Silmek istediğinize emin misniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
                if (onay == DialogResult.OK)
                {
                    db.KurumsalYetkililer.Remove(sil);
                    int silSonuc = db.SaveChanges();
                    if (silSonuc > 0)
                    {
                        return sil.Adi + " na ait yetkili silindi";
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

        #region Kurumsal Müşteri Ürünleri
        public string KurumsalMusteriUrunleriGuncelle(int kurumsalmusteriurunid, int urunid, int kurumsalyetkiliid, string iban, string hesapno, int kullaniciid)
        {
            try
            {
                var guncelle = db.KurumsalMusteriUrunleri.Where(k => k.KurumsalMusteriUrunleriID == kurumsalmusteriurunid).FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(iban))
                {
                    guncelle.UrunID = urunid;
                    guncelle.KurumsalYetkiliID = kurumsalyetkiliid;
                    guncelle.IBAN = iban;
                    guncelle.HesapNumarasi = hesapno;
                    guncelle.KullaniciID = kullaniciid;

                    int sonucKaydet = db.SaveChanges();
                    if (sonucKaydet > 0)
                    {
                        return "Güncelleme işlemi Başarılı!";
                    }
                }
                return "Güncelleme Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }

        public string KurumsalMusteriUrunleriKaydet(int urunid, int kurumsalyetkiliid, string iban, string hesapno, int kullaniciid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(iban) && !string.IsNullOrWhiteSpace(hesapno))
                {
                    KurumsalMusteriUrunleri ekle = new KurumsalMusteriUrunleri();
                    ekle.UrunID = urunid;
                    ekle.KurumsalYetkiliID = kurumsalyetkiliid;
                    ekle.IBAN = iban;
                    ekle.HesapNumarasi = hesapno;
                    ekle.KullaniciID = kullaniciid;


                    db.KurumsalMusteriUrunleri.Add(ekle);
                    int sonucKaydet = db.SaveChanges();
                    if (sonucKaydet > 0)
                    {
                        return "Kayıt işlemi Başarılı!";
                    }
                }
                return "Kayıt Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }
        public void KurumsalMusteriUrunleriListesi(GridControl gridliste, int kurumsalyetkiliid)
        {
            gridliste.DataSource = db.KurumsalMusteriUrunleri.Where(k => k.KurumsalYetkiliID == kurumsalyetkiliid).ToList();            
        }

        public string KurumsalMusteriUrunleriSil(int kurumsalmusteriurunid)
        {
            try
            {
                var sil = db.KurumsalMusteriUrunleri.Where(p => p.KurumsalMusteriUrunleriID == kurumsalmusteriurunid).FirstOrDefault();

                DialogResult onay = MessageBox.Show("Silmek istediğinize emin misniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
                if (onay == DialogResult.OK)
                {
                    db.KurumsalMusteriUrunleri.Remove(sil);
                    int silSonuc = db.SaveChanges();
                    if (silSonuc > 0)
                    {
                        return "Müşteri ürün silindi";
                    }
                }
                return "silme başarısız";
            }
            catch (Exception)
            {

                return "Bir hata oluştu tekrar deneyiniz.";
            }
        } 
        public void GorevlerListesi(ComboBox cmbgorevler)
        {
            cmbgorevler.DataSource = db.Gorevler.ToList();
        }
        #endregion


    }
}
