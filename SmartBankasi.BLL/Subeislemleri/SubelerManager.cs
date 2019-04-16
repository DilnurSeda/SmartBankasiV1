using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using SmartBankasi.DLL;
using System.Windows.Forms;

namespace SmartBankasi.BLL.Subeislemleri
{
    public class SubelerManager : ISubeler
    {
        SmartBankDBEntities db = new SmartBankDBEntities();

        public string SubeGuncelle(int subelerid, string subeadi, string subekodu, string tel1, string tel2, int ilid, int ilceid, string adres,int kullaniciid)
        {
            try
            {
                var guncelle = db.Subeler.Where(k => k.SubelerID == subelerid).FirstOrDefault();

                guncelle.SubeAdi = subeadi;
                guncelle.SubeKodu = subekodu;
                guncelle.Telefon1 = tel1;
                guncelle.Telefon2 = tel2;
                guncelle.ilID = ilid;
                guncelle.ilceID = ilceid;
                guncelle.Adres = adres;
                guncelle.KullaniciID = kullaniciid;

                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Güncelleme başarılı";
                }
                return "Günceleme yapılamadı.";
            }
            catch (Exception)
            {

                return "Hata oluştu";
            }
        }

        public string SubeKaydet(string subeadi, string subekodu, string tel1, string tel2, int ilid, int ilceid, string adres,int kullaniciid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(subeadi))
                {
                    Subeler ekle = new Subeler();
                    ekle.SubeAdi = subeadi;
                    ekle.SubeKodu = subekodu;
                    ekle.Telefon1 = tel1;
                    ekle.Telefon2 = tel2;
                    ekle.ilID = ilid;
                    ekle.ilceID = ilceid;
                    ekle.Adres = adres;
                    ekle.KullaniciID = kullaniciid;

                    db.Subeler.Add(ekle);

                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        return "Kayıt işlemi başarılı.";
                    }
                    return "Kayıt işlemi yapılamadı.";

                }
                return "Şube adı girmeniz gerekiyor";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
         
        }

        public void SubeListele(GridControl gridliste)
        {
            gridliste.DataSource = db.Subeler.ToList();
        }

        public string SubeSil(int subelerid)
        {
            try
            {
                var sil = db.Subeler.Where(p => p.SubelerID == subelerid).FirstOrDefault();

            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                db.Subeler.Remove(sil);
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
        public string SubeilAdi(int ilid)
        {
            var il_adi = db.iller.Where(k => k.illerID == ilid).FirstOrDefault();
            return il_adi.SehirAdi;
        }
        public string SubeilceAdi(int ilceid)
        {
            var ilce_adi = db.ilceler.Where(k => k.ilcelerID == ilceid).FirstOrDefault();
            return ilce_adi.ilceAdi;
        }

    }
}
