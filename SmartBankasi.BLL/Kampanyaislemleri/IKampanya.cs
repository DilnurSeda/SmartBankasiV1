using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankasi.BLL.Kampanyaislemleri
{
    interface IKampanya
    {
        void KampanyaListesi(GridControl gridliste);

        string KampanyaKaydet(DateTime baslangictarihi,DateTime? bitistarihi,string kampanyaadi,string aciklama,int kullaniciid);

        string KampanyaGuncelle(int kampanyaid,DateTime baslangictarihi, DateTime? bitistarihi, string kampanyaadi, string aciklama, int kullaniciid);

        string KampanyaSil(int kampanyaid);
    }
}
