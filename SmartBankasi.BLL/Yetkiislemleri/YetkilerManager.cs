using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using SmartBankasi.DLL;
using System.Windows.Forms;

namespace SmartBankasi.BLL.Yetkiislemleri
{
    public class YetkilerManager : IYetki
    {
        SmartBankDBEntities db = new SmartBankDBEntities();

        public string YetkiGuncelle(int yetkiid, string yetkiadi)
        {
            try
            {
                var guncelle = db.Yetkiler.Where(k => k.YetkilerID == yetkiid).FirstOrDefault();
                guncelle.YetkiAdi = yetkiadi;

                if (!string.IsNullOrWhiteSpace(yetkiadi))
                {
                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        return "Güncelleme işlemi yapıldı";
                    }
                    return "Güncelleme yapılamadı";
                }
                return "Yetki adı boş bırakılamaz";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }
        }

        public string YetkiKaydet(string yetkiadi)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(yetkiadi))
                {
                    Yetkiler ekle = new Yetkiler();
                    ekle.YetkiAdi = yetkiadi;

                    db.Yetkiler.Add(ekle);
                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        return "Yetki kayıt edildi";
                    }
                    return "Kayıt yapılamadı";
                }
                return "Yetki adı boş bırakılamaz";
            }
            catch (Exception)
            {

                return "Hata Oluştu";
            }

            
        }

        public void YetkiListesi(GridControl gridliste)
        {
            gridliste.DataSource=db.Yetkiler.ToList();
        }

        public string YetkiSil(int yetkiid)
        {
            var sil = db.Yetkiler.Where(k => k.YetkilerID == yetkiid).FirstOrDefault();

            DialogResult onay = MessageBox.Show("Silmek istediğinize emin misiniz?", "SİLME ONAY PENCERESİ", MessageBoxButtons.OKCancel);
            if (onay == DialogResult.OK)
            {
                db.Yetkiler.Remove(sil);
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
