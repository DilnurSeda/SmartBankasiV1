using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankasi.BLL.Yetkiislemleri
{
    interface IYetki
    {
        void YetkiListesi(GridControl gridliste);
        string YetkiKaydet(string yetkiadi);
        string YetkiGuncelle(int yetkiid, string yetkiadi);
        string YetkiSil(int yetkiid);

    }
}
