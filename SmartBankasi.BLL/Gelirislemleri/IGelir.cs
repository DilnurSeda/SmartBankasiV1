using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankasi.BLL.Gelirislemleri
{
    interface IGelir
    {
        void GelirListesi(GridControl gridliste);
        string GelirKaydet(DateTime gelirtarihi, TimeSpan gelirsaati, bool faizlimi, decimal faizorani, int parabirimiid, int odemeplaniid, decimal odememiktari, int kullaniciid);
        string GelirGuncelle(int gelirid,DateTime gelirtarihi, TimeSpan gelirsaati, bool faizlimi, decimal faizorani, int parabirimiid, int odemeplaniid, decimal odememiktari, int kullaniciid);
        string GelirSil(int gelirid);
    }
}
