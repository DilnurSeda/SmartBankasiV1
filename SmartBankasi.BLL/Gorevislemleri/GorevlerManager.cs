using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using SmartBankasi.DLL;
using SmartBankasi.BLL.Loginislemleri;

namespace SmartBankasi.BLL.Gorevislemleri
{
    public class GorevlerManager : IGorev
    {
        SmartBankDBEntities db = new SmartBankDBEntities();
        

        public string GorevKaydet(string gorevadi, string aciklama, int kullaniciid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(gorevadi))
                {
                    Gorevler ekle = new Gorevler();
                    ekle.GorevAdi = gorevadi;
                    ekle.Aciklama = aciklama;
                    ekle.KullaniciID = kullaniciid;

                    db.Gorevler.Add(ekle);
                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        return "Kayıt işlemi başarılı";
                    }
                }
                return "Görev adı boş geçilemez!";
            }
            catch (Exception)
            {

                return "Hata oluştu";
            }
        }

        public void GorevListesi(GridControl gridliste)
        {
            gridliste.DataSource = db.Gorevler.ToList();
        }

        public string GorevGuncelle(int gorevlerid, string gorevadi, string aciklama, int kullaniciid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(gorevadi))
                {
                    var guncelle = db.Gorevler.Where(k => k.GorevlerID == gorevlerid).FirstOrDefault();
                    guncelle.GorevAdi = gorevadi;
                    guncelle.Aciklama = aciklama;
                    guncelle.KullaniciID = kullaniciid;

                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        return "Güncelleme işlemi başarılı";
                    }
                }
                return "Görev adı boş geçilemez!";
            }
            catch (Exception)
            {

                return "Hata oluştu";
            }

        }

        public string GorevSil(int gorevlerid)
        {
            var sil = db.Gorevler.Where(k => k.GorevlerID == gorevlerid).FirstOrDefault();

            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                db.Gorevler.Remove(sil);
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
