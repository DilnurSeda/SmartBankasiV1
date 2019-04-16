using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankasi.BLL.Faturaislemleri
{
    interface IFatura
    {
        void FaturaListesi(GridControl gridliste);
        string FaturaKaydet(DateTime faturatarihi, TimeSpan faturasaati, int musterituruid, int musteriid, int odemeplaniid, string aciklama, int kullaniciid);
        string FaturaGuncelle(int faturaid, DateTime faturatarihi, TimeSpan faturasaati, int musterituruid, int musteriid, int odemeplaniid, string aciklama, int kullaniciid);
        string FaturaSil(int faturaid);
    }
}
