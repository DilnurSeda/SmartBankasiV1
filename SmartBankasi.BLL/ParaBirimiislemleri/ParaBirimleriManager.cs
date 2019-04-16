using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using SmartBankasi.DLL;

namespace SmartBankasi.BLL.ParaBirimiislemleri
{
    public class ParaBirimleriManager : IParaBirimi
    {
        SmartBankDBEntities db = new SmartBankDBEntities();

        public string ParaBirimiKaydet(string birimadi, string aciklama)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(birimadi))
                {
                    ParaBirimleri ekle = new ParaBirimleri();
                    ekle.BirimAdi = birimadi;
                    ekle.Aciklama = aciklama;

                    db.ParaBirimleri.Add(ekle);
                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        return "Kayıt Başarılı";
                    }
                    
                }
                return "Birim adı boş geçilemez!";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
            
        }

        public string ParaBirimiGuncelle(int parabirimleriid, string birimadi, string aciklama)
        {

            try
            {
                var guncelle = db.ParaBirimleri.Where(k => k.ParaBirimleriID == parabirimleriid).FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(birimadi))
                {
                    guncelle.BirimAdi = birimadi;
                    guncelle.Aciklama = aciklama;

                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        return "Güncelleme işlemi başarılı";
                    }
                }
                return "Birim adı boş geçilemez!";
            }
            catch (Exception)
            {

                return "Hata oluştu!";
            }
        }

        public string ParaBirimiSil(int parabirimleriid)
        {
            var sil = db.ParaBirimleri.Where(k => k.ParaBirimleriID == parabirimleriid).FirstOrDefault();

            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                db.ParaBirimleri.Remove(sil);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    return "Silindi";
                }

            }
            return "Silme işlemi başarısız";
        }

        public void ParaBirimleriListele(GridControl gridliste)
        {
            gridliste.DataSource = db.ParaBirimleri.ToList();
        }
    }
}
