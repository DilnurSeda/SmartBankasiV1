using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using SmartBankasi.DLL;
using System.Windows.Forms;

namespace SmartBankasi.BLL.Faturaislemleri
{
    public class FaturalarManager : IFatura
    {
        SmartBankDBEntities db = new SmartBankDBEntities();

        public string FaturaGuncelle(int faturaid, DateTime faturatarihi, TimeSpan faturasaati, int musterituruid, int musteriid, int odemeplaniid, string aciklama, int kullaniciid)
        {
            try
            {
                var guncelle = db.Faturalar.Where(f => f.FaturalarID == faturaid).FirstOrDefault();

                guncelle.FaturaTarihi = faturatarihi;
                guncelle.FaturaSaati = faturasaati;
                guncelle.MusteriTuruID = musterituruid;
                guncelle.MusteriID = musteriid;
                guncelle.OdemePlaniID = odemeplaniid;
                guncelle.Aciklama = aciklama;
                guncelle.KullaniciID = kullaniciid;

                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Güncelleme işlemi başarılı";
                }
                return "Güncelleme yapılamadı";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
        }

        public string FaturaKaydet(DateTime faturatarihi, TimeSpan faturasaati, int musterituruid, int musteriid, int odemeplaniid, string aciklama, int kullaniciid)
        {
            try
            {
                Faturalar ekle = new Faturalar();
                ekle.FaturaTarihi = faturatarihi;
                ekle.FaturaSaati = faturasaati;
                ekle.MusteriTuruID = musterituruid;
                ekle.MusteriID = musteriid;
                ekle.OdemePlaniID = odemeplaniid;
                ekle.Aciklama = aciklama;
                ekle.KullaniciID = kullaniciid;

                db.Faturalar.Add(ekle);

                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Kayıt işlemi başarılı";
                }
                return "KAyıt yapılamadı";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }

        }

        public void FaturaListesi(GridControl gridliste)
        {
            gridliste.DataSource = db.Faturalar.ToList();
        }

        public string FaturaSil(int faturaid)
        {
            var sil = db.Faturalar.Where(k => k.FaturalarID == faturaid).FirstOrDefault();

            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                db.Faturalar.Remove(sil);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Silindi";
                }

            }
            return "Silme işlemi başarısız";
        }


        public List<MusteriTurleri> MusteriTurleriListesi()
        {
            return db.MusteriTurleri.ToList();
        }

        public string MusteriTuruAdi(int musterituruid)
        {
            var musterituruadi = db.MusteriTurleri.Where(k => k.MusteriTurleriID == musterituruid).FirstOrDefault();
            return musterituruadi.TurAdi;
        }
        public string MusteriAdi(int musteriid, int musterituruid)
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
        public void OdemePlanlariListesi(ComboBox cmbodemeplani)
        {
            cmbodemeplani.DataSource = db.OdemePlanlari.ToList();
        }
        public List<BireyselMusteriler> BireyselMusteriListesi()
        {
            return db.BireyselMusteriler.ToList();
        }
        public List<KurumsalMusteriler> KurumsalMusteriListesi()
        {
            return db.KurumsalMusteriler.ToList();
        }
    }
}
