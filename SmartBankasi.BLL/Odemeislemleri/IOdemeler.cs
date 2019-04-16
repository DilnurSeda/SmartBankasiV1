using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankasi.BLL.Odemeislemleri
{
    interface IOdemeler
    {
        #region Ödemeler
        void OdemelerListesi(GridControl gridliste);
        string OdemelerKaydet(int musterituruid, int musteriid, int odemeplaniid, int kullaniciid);
        string OdemelerGuncelle(int musterituruid, int musteriid, int odemeplaniid, int kullaniciid);
        string OdemelerSil(int musterituruid, int musteriid, int odemeplaniid); 
        #endregion

        #region Ödeme Türleri
        void OdemeTurleriListesi(GridControl gridliste);

        string OdemeTurleriKaydet(string turadi, int parabirimiid, string aciklama, int kullaniciid);

        string OdemeTurleriGuncelle(int odemeturleriid, string turadi, int parabirimiid, string aciklama, int kullaniciid);

        string OdemeTurleriSil(int odemeturleriid);
        #endregion

        #region Ödeme Planları
        void OdemePlanlariListesi(GridControl gridliste);

        string OdemePlanlariKaydet(decimal taksit1, DateTime? t1tarihi, decimal taksit2, DateTime? t2tarihi, decimal taksit3, DateTime? t3tarihi, decimal taksit4, DateTime? t4tarihi, decimal taksit5, DateTime? t5tarihi, decimal taksit6, DateTime? t6tarihi, decimal taksit7, DateTime? t7tarihi, decimal taksit8, DateTime? t8tarihi, decimal taksit9, DateTime? t9tarihi, decimal taksit10, DateTime? t10tarihi, decimal taksit11, DateTime? t11tarihi, decimal taksit12, DateTime? t12tarihi, int kullaniciid);

        string OdemePlanlariGuncelle(int odemeplanlariid, decimal taksit1, DateTime? t1tarihi, decimal taksit2, DateTime? t2tarihi, decimal taksit3, DateTime? t3tarihi, decimal taksit4, DateTime? t4tarihi, decimal taksit5, DateTime? t5tarihi, decimal taksit6, DateTime? t6tarihi, decimal taksit7, DateTime? t7tarihi, decimal taksit8, DateTime? t8tarihi, decimal taksit9, DateTime? t9tarihi, decimal taksit10, DateTime? t10tarihi, decimal taksit11, DateTime? t11tarihi, decimal taksit12, DateTime? t12tarihi, int kullaniciid);

        string OdemePlanlariSil(int odemeplanlariid); 
        #endregion
    }
}
