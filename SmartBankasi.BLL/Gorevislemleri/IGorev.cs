using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankasi.BLL.Gorevislemleri
{
    interface IGorev
    {
        void GorevListesi(GridControl gridliste);

        string GorevKaydet(string gorevadi,string aciklama,int kullaniciid);

        string GorevGuncelle(int gorevlerid,string gorevadi, string aciklama, int kullaniciid);

        string GorevSil(int gorevlerid);
    }
}
