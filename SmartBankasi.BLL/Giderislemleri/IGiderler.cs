using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankasi.BLL.Giderislemleri
{
    interface IGiderler
    {
        void GiderleriListele(GridControl gridliste);

        string GiderKaydet(int subegiderturuid,DateTime tarihi, Decimal miktari, string aciklama,bool faizlimi,Decimal faizorani, int kullaniciid);

        string GiderGuncelle(int giderlerid,int subegiderturuid, DateTime tarihi, Decimal miktari, string aciklama, bool faizlimi, Decimal faizorani, int kullaniciid);

        string GiderSil(int giderlerid);

    }
}
