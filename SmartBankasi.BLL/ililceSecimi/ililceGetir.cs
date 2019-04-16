using SmartBankasi.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBankasi.BLL.ililceSecimi
{
    public class ililceGetir
    {
        SmartBankDBEntities db = new SmartBankDBEntities();
        //***************************************************************

        public void illerListesi(ComboBox cmbiller)
        {            
            cmbiller.DisplayMember = "SehirAdi";
            cmbiller.ValueMember = "illerID";
            cmbiller.DataSource = db.iller.OrderBy(k => k.SehirAdi).ToList();
            //cmbiller.SelectedIndex = -1;
        }

        public void ilcelerListesi(ComboBox cmbiller, ComboBox cmbilceler)
        {
            cmbilceler.DisplayMember = "ilceAdi";
            cmbilceler.ValueMember = "ilcelerID";
            cmbilceler.DataSource=db.ilceler.Where(k => k.ilID == (int)cmbiller.SelectedValue).ToList();
        }
    }
}
