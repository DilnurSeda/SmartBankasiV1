using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankasi.BLL.ParaBirimiislemleri
{
    interface IParaBirimi
    {
        void ParaBirimleriListele(GridControl gridliste);

        string ParaBirimiKaydet(string birimadi,string aciklama);

        string ParaBirimiGuncelle(int parabirimleriid,string birimadi, string aciklama);

        string ParaBirimiSil(int parabirimleriid);
    }
}
