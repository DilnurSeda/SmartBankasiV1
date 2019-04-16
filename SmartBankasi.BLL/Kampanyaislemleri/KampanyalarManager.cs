using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using SmartBankasi.DLL;

namespace SmartBankasi.BLL.Kampanyaislemleri
{
    public class KampanyalarManager : IKampanya
    {
        SmartBankDBEntities db = new SmartBankDBEntities();

        public string KampanyaKaydet(DateTime baslangictarihi, DateTime? bitistarihi, string kampanyaadi, string aciklama,int kullaniciid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(kampanyaadi))
                {
                    Kampanyalar ekle = new Kampanyalar();
                    ekle.BaslangicTarihi = baslangictarihi;
                    ekle.BirisTarihi = bitistarihi;
                    ekle.KampanyaAdi = kampanyaadi;
                    ekle.Aciklama = aciklama;
                    ekle.KullaniciID = kullaniciid;

                    db.Kampanyalar.Add(ekle);

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
        public string KampanyaGuncelle(int kampanyaid, DateTime baslangictarihi, DateTime? bitistarihi, string kampanyaadi, string aciklama, int kullaniciid)
        {
            try
            {
                var guncelle = db.Kampanyalar.Where(k => k.KampanyalarID == kampanyaid).FirstOrDefault();
                guncelle.BaslangicTarihi = baslangictarihi;
                guncelle.BirisTarihi = bitistarihi;
                guncelle.KampanyaAdi = kampanyaadi;
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

                return "Hata oluştu";
            }
        }

        public string KampanyaSil(int kampanyaid)
        {
            var sil = db.Kampanyalar.Where(k => k.KampanyalarID == kampanyaid).FirstOrDefault();

            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                db.Kampanyalar.Remove(sil);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Silindi";
                }

            }
            return "Silme işlemi başarısız";
        }


        public void KampanyaListesi(GridControl gridliste)
        {
            gridliste.DataSource = db.Kampanyalar.ToList();
        }
    }
}
