using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using SmartBankasi.DLL;
using System.Windows.Forms;

namespace SmartBankasi.BLL.Personelislemleri
{
    public class PersonelManager : IPersonel
    {
        SmartBankDBEntities db = new SmartBankDBEntities();



        #region Personel Bilgileri
        public string PersonelGuncelle(int personellerid, string tc, string adi, string soyadi, string cinsiyet, bool medenihali, string dogumyeri, string dogumtarihi, string resim,int kullaniciid)
        {
            try
            {
                var guncelle = db.Personeller.Where(k => k.PersonellerID == personellerid).FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(adi))
                {
                    guncelle.TC = tc;
                    guncelle.Adi = adi;
                    guncelle.Soyadi = soyadi;
                    guncelle.Cinsiyet = cinsiyet;
                    guncelle.MedeniHali = medenihali;
                    guncelle.DogumYeri = dogumyeri;
                    guncelle.DogumTarihi = Convert.ToDateTime(dogumtarihi);
                    guncelle.Resim = resim;
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

        public string PersonelKaydet(string tc, string adi, string soyadi, string cinsiyet, bool medenihali, string dogumyeri, string dogumtarihi, string resim, int kullaniciid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(adi))
                {
                    Personeller ekle = new Personeller();
                    ekle.TC = tc;
                    ekle.Adi = adi;
                    ekle.Soyadi = soyadi;
                    ekle.Cinsiyet = cinsiyet;
                    ekle.MedeniHali = medenihali;
                    ekle.DogumYeri = dogumyeri;
                    ekle.DogumTarihi = Convert.ToDateTime(dogumtarihi);
                    ekle.Resim = resim;
                    ekle.KullaniciID = kullaniciid;

                    db.Personeller.Add(ekle);
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

        public string PersonelSil(int personellerid)
        {
            try
            {
                var sil = db.Personeller.Where(p => p.PersonellerID == personellerid).FirstOrDefault();

                DialogResult onay = MessageBox.Show("Silmek istediğinize emin misniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
                if (onay == DialogResult.OK)
                {
                    db.Personeller.Remove(sil);
                    int silSonuc = db.SaveChanges();
                    if (silSonuc > 0)
                    {
                        return sil.Adi + " adlı personel silindi";
                    }
                }
                return "silme başarısız";
            }
            catch (Exception)
            {

                return "Bir hata oluştu tekrar deneyiniz.";
            }
        }

        public void PersonelListesi(GridControl gridliste)
        {
            gridliste.DataSource = db.Personeller.ToList();
        } 
        #endregion       

        #region Personel Detay
        public void PersonelDetayListesi(GridControl gridliste,int personelid)
        {
            gridliste.DataSource = db.PersonelDetay.Where(p => p.PersonelID == personelid).ToList();
        }

        public string PersonelDetayKaydet(DateTime giristarihi, DateTime? cikistarihi, int personelid, int kullaniciid)
        {
            try
            {               
                PersonelDetay ekle = new PersonelDetay();
                ekle.GirisTarihi = giristarihi;
                ekle.CikisTarihi = cikistarihi.ToString();
                ekle.PersonelID = personelid;
                ekle.KullaniciID = kullaniciid;

                db.PersonelDetay.Add(ekle);
                int sonucKaydet = db.SaveChanges();
                if (sonucKaydet > 0)
                {
                    return "Kayıt işlemi Başarılı!";
                }
               
            return "Kayıt Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }

        }

        public string PersonelDetayGuncelle(int personeldetayid, DateTime giristarihi, DateTime? cikistarihi, int personelid, int kullaniciid)
        {
            try
            {
                var guncelle = db.PersonelDetay.Where(k => k.PersonelDetaylariID == personeldetayid).FirstOrDefault();
                
                guncelle.GirisTarihi = giristarihi;
                guncelle.CikisTarihi = cikistarihi.ToString();
                guncelle.PersonelID = personelid;
                guncelle.KullaniciID = kullaniciid;
              

                int sonucKaydet = db.SaveChanges();
                if (sonucKaydet > 0)
                {
                    return "Güncelleme işlemi Başarılı!";
                }
                
                return "Güncelleme Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }

        public string PersonelDetaySil(int personeldetayid)
        {
            try
            {
                var sil = db.PersonelDetay.Where(p => p.PersonelDetaylariID == personeldetayid).FirstOrDefault();

                DialogResult onay = MessageBox.Show("Silmek istediğinize emin misniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
                if (onay == DialogResult.OK)
                {
                    db.PersonelDetay.Remove(sil);
                    int silSonuc = db.SaveChanges();
                    if (silSonuc > 0)
                    {
                        return " adlı personel silindi";
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

        #region Personel Görev Yerleri
        public void PersonelGorevYerleriListesi(GridControl gridliste,int personelid)
        {
            gridliste.DataSource = db.PersonelGorevYerleri.Where(p=>p.PersonelID==personelid).ToList();
        }
        public string PersonelGorevYerleriKaydet(int personelid, DateTime baslangictarihi, DateTime? bitistarihi, int gorevid, int subeid, int kullaniciid)
        {

            try
            {
                PersonelGorevYerleri ekle = new PersonelGorevYerleri();
                ekle.PersonelID = personelid;
                ekle.BaslangicTarihi = baslangictarihi;
                ekle.BitisTarihi = bitistarihi;
                ekle.GorevID = gorevid;
                ekle.SubeID = subeid;
                ekle.KullaniciID = kullaniciid;             

                db.PersonelGorevYerleri.Add(ekle);
                int sonucKaydet = db.SaveChanges();
                if (sonucKaydet > 0)
                {
                    return "Kayıt işlemi Başarılı!";
                }

                return "Kayıt Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }

        public string PersonelGorevYerleriGuncelle(int personelgorevyerleriid, int personelid, DateTime baslangictarihi, DateTime? bitistarihi, int gorevid, int subeid, int kullaniciid)
        {
            try
            {
                var guncelle = db.PersonelGorevYerleri.Where(k => k.PersonelGorevYerleriID == personelgorevyerleriid).FirstOrDefault();

                guncelle.BaslangicTarihi = baslangictarihi;
                guncelle.BitisTarihi = bitistarihi;
                guncelle.PersonelID = personelid;
                guncelle.GorevID = gorevid;
                guncelle.SubeID = subeid;
                guncelle.KullaniciID = kullaniciid;

                int sonucKaydet = db.SaveChanges();
                if (sonucKaydet > 0)
                {
                    return "Güncelleme işlemi Başarılı!";
                }

                return "Güncelleme Yapılamadı!";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }

        public string PersonelGorevYerleriSil(int personelgorevyerleriid)
        {
            try
            {
                var sil = db.PersonelGorevYerleri.Where(p => p.PersonelGorevYerleriID == personelgorevyerleriid).FirstOrDefault();

                DialogResult onay = MessageBox.Show("Silmek istediğinize emin misniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
                if (onay == DialogResult.OK)
                {
                    db.PersonelGorevYerleri.Remove(sil);
                    int silSonuc = db.SaveChanges();
                    if (silSonuc > 0)
                    {
                        return " Silme işlemi başarılı";
                    }
                }
                return "silme başarısız";
            }
            catch (Exception)
            {

                return "Bir hata oluştu tekrar deneyiniz.";
            }

        }
        public void gorevListesi(ComboBox cmbGorevler)
        {
            cmbGorevler.DataSource = db.Gorevler.ToList();
        }
        public string GorevAdi(int gorevid)
        {
            var gorevadi = db.Gorevler.Where(k => k.GorevlerID == gorevid).FirstOrDefault();
            return gorevadi.GorevAdi;
        }
        public void subeListesi(ComboBox cmbsubeler)
        {
            cmbsubeler.DataSource = db.Subeler.ToList();
        }
        public string SubeAdi(int subeid)
        {
            var subeadi = db.Subeler.Where(k => k.SubelerID == subeid).FirstOrDefault();
            return subeadi.SubeAdi;
        }
        #endregion

        #region Personel Maaşları
        public void PersonelMaasListesi(GridControl gridliste,int personelid)
        {
            gridliste.DataSource = db.PersonelMaaslari.Where(p=>p.PersonelID==personelid).ToList();
        }

        public string PersonelMaasKaydet(DateTime maasbaslangictarihi, DateTime maasbitistarihi, decimal maas, int personelid, int kullaniciid)
        {
            try
            {
                PersonelMaaslari ekle = new PersonelMaaslari();
                ekle.MaasBaslangicTarihi = maasbaslangictarihi;
                ekle.MaasBitisTarihi = maasbitistarihi;
                ekle.Maas = maas;
                ekle.PersonelID = personelid;
                ekle.KullaniciID = kullaniciid;

                db.PersonelMaaslari.Add(ekle);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Maaş ekleme başarılı";
                }
                return "Maaş ekleme yapılamadı";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
        }

        public string PersonelMaasGuncelle(int personelmaaslariid, DateTime maasbaslangictarihi, DateTime maasbitistarihi, decimal maas, int personelid, int kullaniciid)
        {
            try
            {
                var guncelle = db.PersonelMaaslari.Where(k => k.PersonelMaaslarID == personelmaaslariid).FirstOrDefault();
                guncelle.MaasBaslangicTarihi = maasbaslangictarihi;
                guncelle.MaasBitisTarihi = maasbitistarihi;
                guncelle.Maas = maas;
                guncelle.PersonelID = personelid;
                guncelle.KullaniciID = kullaniciid;

                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Maaş güncelleme başarılı";
                }
                return "Güncelleme yapılamadı";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
        }

        public string PersonelMaasSil(int personelmaaslariid)
        {
            var sil = db.PersonelMaaslari.Where(k => k.PersonelMaaslarID == personelmaaslariid).FirstOrDefault();

            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                db.PersonelMaaslari.Remove(sil);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Silindi";
                }

            }
            return "Silme işlemi başarısız";
        } 
        #endregion
    }
}
