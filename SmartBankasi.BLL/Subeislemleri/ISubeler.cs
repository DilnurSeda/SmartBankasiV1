using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankasi.BLL.Subeislemleri
{
    interface ISubeler
    {
        string SubeKaydet(string subeadi, string subekodu, string tel1,string tel2, int ilid,int ilceid, string adres,int kullaniciid);
        string SubeGuncelle(int subelerid,string subeadi, string subekodu, string tel1, string tel2, int ilid, int ilceid, string adres,int kullaniciid);
        string SubeSil(int subelerid);
        void SubeListele(GridControl gridliste);

    }
}
