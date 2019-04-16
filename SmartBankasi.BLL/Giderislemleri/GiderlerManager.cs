using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using SmartBankasi.DLL;

namespace SmartBankasi.BLL.Giderislemleri
{
    public class GiderlerManager : IGiderler
    {
        SmartBankDBEntities db = new SmartBankDBEntities();


        public string GiderKaydet(int subegiderturuid, DateTime tarihi, decimal miktari, string aciklama, bool faizlimi, decimal faizorani, int kullaniciid)
        {
            try
            {
                Giderler ekle = new Giderler();
                ekle.SubeGiderTuruID = subegiderturuid;
                ekle.Tarihi = tarihi;
                ekle.Miktari = miktari;
                ekle.Aciklama = aciklama;
                ekle.Faizlimi = faizlimi;
                ekle.FaizOrani = faizorani;
                ekle.KullaniciID = kullaniciid;

                db.Giderler.Add(ekle);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Kayıt işlemi başarılı";
                }
                return "Kayıt yapılamadı";
            }
            catch (Exception)
            {

                return "Hata Oluştu!";
            }
        }

        public void GiderleriListele(GridControl gridliste)
        {
            gridliste.DataSource = db.Giderler.ToList();
        }

        public string GiderSil(int giderlerid)
        {
            var sil = db.Giderler.Where(k => k.GiderlerID == giderlerid).FirstOrDefault();

            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                db.Giderler.Remove(sil);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Silindi";
                }

            }
            return "Silme işlemi başarısız";
        }

        public string GiderGuncelle(int giderlerid, int subegiderturuid, DateTime tarihi, decimal miktari, string aciklama, bool faizlimi, decimal faizorani, int kullaniciid)
        {
            try
            {
                var guncelle = db.Giderler.Where(g => g.GiderlerID == giderlerid).FirstOrDefault();
                guncelle.SubeGiderTuruID = subegiderturuid;
                guncelle.Tarihi = tarihi;
                guncelle.Miktari = miktari;
                guncelle.Aciklama = aciklama;
                guncelle.Faizlimi = faizlimi;
                guncelle.FaizOrani = faizorani;
                guncelle.KullaniciID = kullaniciid;

                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Güncelleme başarılı";
                }
                return "Güncelleme yapılamadı";
            }
            catch (Exception)
            {

                return "Hata oluştu!";
            }
        }
    }
}
