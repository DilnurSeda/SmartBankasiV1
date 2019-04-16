using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using SmartBankasi.DLL;
using System.Windows.Forms;

namespace SmartBankasi.BLL.Gelirislemleri
{
    public class GelirlerManager : IGelir
    {
        SmartBankDBEntities db = new SmartBankDBEntities();

        public string GelirSil(int gelirid)
        {
            var sil = db.Gelirler.Where(k => k.GelirlerID == gelirid).FirstOrDefault();

            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                db.Gelirler.Remove(sil);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Silindi";
                }

            }
            return "Silme işlemi başarısız";
        }

        public string GelirKaydet(DateTime gelirtarihi, TimeSpan gelirsaati, bool faizlimi, decimal faizorani, int parabirimiid, int odemeplaniid, decimal odememiktari, int kullaniciid)
        {
            try
            {
                Gelirler ekle = new Gelirler();
                ekle.GelirTarihi = gelirtarihi;
                ekle.GelirSaati = gelirsaati;
                ekle.Faizlimi = faizlimi;
                ekle.FaizOrani = faizorani;
                ekle.ParaBirimiID = parabirimiid;
                ekle.OdemePlaniID = odemeplaniid;
                ekle.OdemeMiktari = odememiktari;
                ekle.KullaniciID = kullaniciid;

                db.Gelirler.Add(ekle);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Kayıt işlemi başarılı";
                }
                return "Kayıt yapılamadı";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
            
        }

        public string GelirGuncelle(int gelirid, DateTime gelirtarihi, TimeSpan gelirsaati, bool faizlimi, decimal faizorani, int parabirimiid, int odemeplaniid, decimal odememiktari, int kullaniciid)
        {
            try
            {
                var guncelle = db.Gelirler.Where(k => k.GelirlerID == gelirid).FirstOrDefault();
                guncelle.GelirTarihi = gelirtarihi;
                guncelle.GelirSaati = gelirsaati;
                guncelle.Faizlimi = faizlimi;
                guncelle.FaizOrani = faizorani;
                guncelle.ParaBirimiID = parabirimiid;
                guncelle.OdemePlaniID = odemeplaniid;
                guncelle.OdemeMiktari = odememiktari;
                guncelle.KullaniciID = kullaniciid;

                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Kayıt işlemi başarılı";
                }
                return "Güncelleme işlemi başarılı";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
        }

        public void GelirListesi(GridControl gridliste)
        {
            gridliste.DataSource = db.Gelirler.ToList();
        }
    }
}
