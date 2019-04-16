using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using SmartBankasi.DLL;
using System.Windows.Forms;

namespace SmartBankasi.BLL.Kullaniciislemleri
{
    public class KullanicilarManager : IKullanicilar
    {
        SmartBankDBEntities db = new SmartBankDBEntities();

        public string kullaniciGuncelle(int kullaniciid, string tc, string adi, string soyadi, string kullaniciadi, string sifre, int yetkiId, int kullanici_id)
        {
            try
            {
                var guncelle = db.Kullanicilar.Where(k => k.KullanicilarID == kullaniciid).FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(adi) && !string.IsNullOrWhiteSpace(kullaniciadi) && !string.IsNullOrWhiteSpace(sifre))
                {
                    guncelle.TC = tc;
                    guncelle.PersonelAdi = adi;
                    guncelle.PersonelSoyadi = soyadi;
                    guncelle.KullaniciAdi = kullaniciadi;
                    guncelle.KullaniciSifre = sifre;
                    guncelle.YetkiID = yetkiId;
                    guncelle.KullaniciID = kullanici_id;

                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        return "Kullanıcı guncellendi";
                    }
                }
                return "Kullanıcı guncelleme başarısız";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
        }
        int varOlanTC;
        public string kullaniciKaydet(string tc, string adi, string soyadi, string kullaniciadi, string sifre, int yetkiId, int kullanici_id)
        {
            try
            {
                //try
                //{
                //    varOlanTC = Convert.ToInt32(db.Personeller.Where(k => k.TC == tc).FirstOrDefault());
                //}
                //catch (Exception)
                //{

                //    varOlanTC = 0;
                //}

                //if (varOlanTC>=0)
                //{
                //    return "Aynı TC eklenemez";
                //}
                //else
                //{
                    if (!string.IsNullOrWhiteSpace(adi) && !string.IsNullOrWhiteSpace(kullaniciadi) && !string.IsNullOrWhiteSpace(sifre))
                    {

                        Kullanicilar ekle = new Kullanicilar();
                        ekle.TC = tc;
                        ekle.PersonelAdi = adi;
                        ekle.PersonelSoyadi = soyadi;
                        ekle.KullaniciAdi = kullaniciadi;
                        ekle.KullaniciSifre = sifre;
                        ekle.YetkiID = yetkiId;
                        ekle.KullaniciID = kullanici_id;

                        db.Kullanicilar.Add(ekle);
                        int sonuc = db.SaveChanges();
                        if (sonuc > 0)
                        {
                            return "Kullanıcı eklendi";
                        }


                    }
               //}
                
                return "Kullanıcı ekleme başarısız";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
        }

        public void kullaniciListesi(GridControl gridliste)
        {
            gridliste.DataSource = db.Kullanicilar.ToList();
        }

        public string kullaniciSil(int kullaniciid)
        {
            var sil = db.Kullanicilar.Where(k => k.KullanicilarID == kullaniciid).FirstOrDefault();

            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                db.Kullanicilar.Remove(sil);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Silindi";
                }

            }
            return "Silme işlemi başarısız";
        }
        
    }
}
