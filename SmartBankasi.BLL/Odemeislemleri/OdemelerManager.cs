using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using SmartBankasi.DLL;

namespace SmartBankasi.BLL.Odemeislemleri
{
    public class OdemelerManager : IOdemeler
    {
        SmartBankDBEntities db = new SmartBankDBEntities();

        #region Ödemeler
        public string OdemelerGuncelle(int musterituruid, int musteriid, int odemeplaniid, int kullaniciid)
        {
            try
            {
                var guncelle = db.Odemeler.Where(k => k.MusteriTuruID == musterituruid && k.MusteriID == musteriid && k.OdemePlaniID == odemeplaniid).FirstOrDefault();
                guncelle.MusteriTuruID = musterituruid;
                guncelle.MusteriID = musteriid;
                guncelle.OdemePlaniID = odemeplaniid;
                guncelle.KullaniciID = kullaniciid;

                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Odemeler kayıt edildi";
                }
                return "Kayıt yapılamadı";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
                      
        }

        public string OdemelerKaydet(int musterituruid, int musteriid, int odemeplaniid, int kullaniciid)
        {
            try
            {
                Odemeler ekle = new Odemeler();
                ekle.MusteriTuruID = musterituruid;
                ekle.MusteriID = musteriid;
                ekle.OdemePlaniID = odemeplaniid;
                ekle.KullaniciID = kullaniciid;

                db.Odemeler.Add(ekle);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Kayıt işlemi başarılı";
                }
                return "Kayıt yapılamadı";
            }
            catch (Exception)
            {

                return "Hata oluştu";
            }
        }

        public void OdemelerListesi(GridControl gridliste)
        {
            gridliste.DataSource = db.Odemeler.ToList();
        }
        
        public string OdemelerSil(int musterituruid, int musteriid, int odemeplaniid)
        {
            var sil = db.Odemeler.Where(k => k.MusteriTuruID == musterituruid && k.MusteriID==musteriid && k.OdemePlaniID==odemeplaniid).FirstOrDefault();

            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                db.Odemeler.Remove(sil);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Silindi";
                }

            }
            return "Silme işlemi başarısız";
        }
        public string MusteriTuruAdi(int musterituruid)
        {
            var musterituruadi = db.MusteriTurleri.Where(k => k.MusteriTurleriID == musterituruid).FirstOrDefault();
            return musterituruadi.TurAdi;
        }
        public string MusteriAdi(int musteriid,int musterituruid)
        {

            if (MusteriTuruAdi(musterituruid) == "Bireysel")
            {
               var musteriadi = db.BireyselMusteriler.Where(k => k.BireyselMustrilerID == musteriid).FirstOrDefault();
                return musteriadi.Adi;
            }
            else if (MusteriTuruAdi(musterituruid) == "Kurumsal")
            {
                var musteriadi = db.KurumsalMusteriler.Where(k => k.KurumsalMusterilerID == musteriid).FirstOrDefault();
                return musteriadi.KurumAdi;
            }
            
            return "";
        }
        
        public List<MusteriTurleri> MusteriTurleriListesi()
        {
            return db.MusteriTurleri.ToList();
        }
        public List<BireyselMusteriler> BireyselMusteriListesi()
        {
            return db.BireyselMusteriler.ToList();
        }
        public List<KurumsalMusteriler> KurumsalMusteriListesi()
        {
            return db.KurumsalMusteriler.ToList();
        }

        
        #endregion

        #region Ödeme Türleri
        public string OdemeTurleriGuncelle(int odemeturleriid, string turadi, int parabirimiid, string aciklama, int kullaniciid)
        {

            try
            {
                var guncelle = db.OdemeTurleri.Where(k => k.OdemeTurleriID == odemeturleriid).FirstOrDefault();
                guncelle.TurAdi = turadi;
                guncelle.ParaBirimiID = parabirimiid;
                guncelle.Aciklama = aciklama;

                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Güncelleme işlemi başarılı";
                }
                return "Güncelleme yapılamadı";
            }
            catch (Exception)
            {

                return "Hata oluştu";
            }
        }

        public string OdemeTurleriKaydet(string turadi, int parabirimiid, string aciklama, int kullaniciid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(turadi))
                {
                    OdemeTurleri ekle = new OdemeTurleri();
                    ekle.TurAdi = turadi;
                    ekle.ParaBirimiID = parabirimiid;
                    ekle.Aciklama = aciklama;
                    ekle.KullaniciID = kullaniciid;

                    db.OdemeTurleri.Add(ekle);

                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        return "Kayıt işlemi başarılı";
                    }
                }
                return "Kayıt yapılamadı";
            }
            catch (Exception)
            {

                return "Hata oluştu!";
            }
        }

        public void OdemeTurleriListesi(GridControl gridliste)
        {
            gridliste.DataSource = db.OdemeTurleri.ToList();
        }
        public void OdemeTurleriParaBirimiListesi(ComboBox cmbparabirimi)
        {
            cmbparabirimi.DataSource = db.ParaBirimleri.ToList();
        }
        public string OdemeTurleriParaBirimiTuruAdi(int parabirimiid)
        {
            var parabirimiadi = db.ParaBirimleri.Where(k => k.ParaBirimleriID == parabirimiid).FirstOrDefault();
            return parabirimiadi.BirimAdi;
        }
        public string OdemeTurleriSil(int odemeturleriid)
        {
            try
            {
                var sil = db.OdemeTurleri.Where(k => k.OdemeTurleriID == odemeturleriid).FirstOrDefault();

                DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
                if (onay == DialogResult.OK)
                {
                    db.OdemeTurleri.Remove(sil);
                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        return "Silindi";
                    }

                }
                return "Silme işlemi başarısız";
            }
            catch (Exception)
            {

                return "HAta Oluştu";
            }
        }
        #endregion

        #region Ödeme Planları
        public string OdemePlanlariGuncelle(int odemeplanlariid, decimal taksit1, DateTime? t1tarihi, decimal taksit2, DateTime? t2tarihi, decimal taksit3, DateTime? t3tarihi, decimal taksit4, DateTime? t4tarihi, decimal taksit5, DateTime? t5tarihi, decimal taksit6, DateTime? t6tarihi, decimal taksit7, DateTime? t7tarihi, decimal taksit8, DateTime? t8tarihi, decimal taksit9, DateTime? t9tarihi, decimal taksit10, DateTime? t10tarihi, decimal taksit11, DateTime? t11tarihi, decimal taksit12, DateTime? t12tarihi, int kullaniciid)
        {
            try
            {
                OdemePlanlari guncelle = new OdemePlanlari();
                guncelle.Taksit1 = taksit1;
                guncelle.Taksit1Tarihi = t1tarihi;
                guncelle.Taksit2 = taksit2;
                guncelle.Taksit2Tarihi = t2tarihi;
                guncelle.Taksit3 = taksit3;
                guncelle.Taksit3Tarihi = t3tarihi;
                guncelle.Taksit4 = taksit4;
                guncelle.Taksit4Tarihi = t4tarihi;
                guncelle.Taksit5 = taksit5;
                guncelle.Taksit5Tarihi = t5tarihi;
                guncelle.Taksit6 = taksit6;
                guncelle.Taksit6Tarihi = t6tarihi;
                guncelle.Taksit7 = taksit7;
                guncelle.Taksit7Tarihi = t7tarihi;
                guncelle.Taksit8 = taksit8;
                guncelle.Taksit8Tarihi = t8tarihi;
                guncelle.Taksit9 = taksit9;
                guncelle.Taksit9Tarihi = t9tarihi;
                guncelle.Taksit10 = taksit10;
                guncelle.Taksit10Tarihi = t10tarihi;
                guncelle.Taksit11 = taksit11;
                guncelle.Taksit11Tarihi = t11tarihi;
                guncelle.Taksit12 = taksit12;
                guncelle.Taksit12Tarihi = t12tarihi;
                guncelle.KullaniciID = kullaniciid;               

                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Taksitler güncellendi";
                }
                return "Güncelleme yapılamadı";
            }
            catch (Exception)
            {

                return "Hata Oluştu";

            }
        }

        public string OdemePlanlariKaydet(decimal taksit1, DateTime? t1tarihi, decimal taksit2, DateTime? t2tarihi, decimal taksit3, DateTime? t3tarihi, decimal taksit4, DateTime? t4tarihi, decimal taksit5, DateTime? t5tarihi, decimal taksit6, DateTime? t6tarihi, decimal taksit7, DateTime? t7tarihi, decimal taksit8, DateTime? t8tarihi, decimal taksit9, DateTime? t9tarihi, decimal taksit10, DateTime? t10tarihi, decimal taksit11, DateTime? t11tarihi, decimal taksit12, DateTime? t12tarihi, int kullaniciid)
        {
            try
            {
                OdemePlanlari ekle = new OdemePlanlari();
                ekle.Taksit1 = taksit1;
                ekle.Taksit1Tarihi = t1tarihi;
                ekle.Taksit2 = taksit2;
                ekle.Taksit2Tarihi = t2tarihi;
                ekle.Taksit3 = taksit3;
                ekle.Taksit3Tarihi = t3tarihi;
                ekle.Taksit4 = taksit4;
                ekle.Taksit4Tarihi = t4tarihi;
                ekle.Taksit5 = taksit5;
                ekle.Taksit5Tarihi = t5tarihi;
                ekle.Taksit6 = taksit6;
                ekle.Taksit6Tarihi = t6tarihi;
                ekle.Taksit7 = taksit7;
                ekle.Taksit7Tarihi = t7tarihi;
                ekle.Taksit8 = taksit8;
                ekle.Taksit8Tarihi = t8tarihi;
                ekle.Taksit9 = taksit9;
                ekle.Taksit9Tarihi = t9tarihi;
                ekle.Taksit10 = taksit10;
                ekle.Taksit10Tarihi = t10tarihi;
                ekle.Taksit11 = taksit11;
                ekle.Taksit11Tarihi = t11tarihi;
                ekle.Taksit12 = taksit12;
                ekle.Taksit12Tarihi = t12tarihi;
                ekle.KullaniciID = kullaniciid;

                db.OdemePlanlari.Add(ekle);

                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Taksitler kayıt edildi";
                }
                return "Kayıt yapılamadı";
            }
            catch (Exception)
            {

                return "Hata Oluştu";

            }

        }

        public void OdemePlanlariListesi(GridControl gridliste)
        {
            gridliste.DataSource = db.OdemePlanlari.ToList();
        }
        public void OdemePlanlariListesi(ComboBox cmbodemeplani)
        {
            cmbodemeplani.DataSource = db.OdemePlanlari.ToList();
        }

        public string OdemePlanlariSil(int odemeplanlariid)
        {
            try
            {
                var sil = db.OdemePlanlari.Where(k => k.OdemePlanlariID == odemeplanlariid).FirstOrDefault();

                DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
                if (onay == DialogResult.OK)
                {
                    db.OdemePlanlari.Remove(sil);
                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        return "Silindi";
                    }

                }
                return "Silme işlemi başarısız";
            }
            catch (Exception)
            {
                return "HAta Oluştu";
            }
        } 
        #endregion

        


    }
}
