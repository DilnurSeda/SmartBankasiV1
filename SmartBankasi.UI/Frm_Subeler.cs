using SmartBankasi.BLL.ililceSecimi;
using SmartBankasi.BLL.Loginislemleri;
using SmartBankasi.BLL.Subeislemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBankasi.UI
{
    public partial class Frm_Subeler : Form
    {
        public Frm_Subeler()
        {
            InitializeComponent();
        }
        string mesajSube;
        int sube_id,il_id, ilce_id;

        SubelerManager subeManage = new SubelerManager();
        ililceGetir il_ilceGetir = new ililceGetir();
        //LoginManager logManager = new LoginManager();
        public int kullanici_IDTut;

        private void Frm_Subeler_Load(object sender, EventArgs e)
        {
            subeManage.SubeListele(gridControlSubeler);
            il_ilceGetir.illerListesi(cmbiller);
        }

        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            mesajSube = subeManage.SubeKaydet(txt_subeAdi.Text, mtb_subekodu.Text, mtb_tel1.Text, mtb_tel2.Text, (int)cmbiller.SelectedValue, (int)cmbilceler.SelectedValue, txt_adres.Text, kullanici_IDTut);
            subeManage.SubeListele(gridControlSubeler);
            MessageBox.Show(mesajSube);
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            mesajSube = subeManage.SubeGuncelle(sube_id,txt_subeAdi.Text, mtb_subekodu.Text, mtb_tel1.Text, mtb_tel2.Text, (int)cmbiller.SelectedValue, (int)cmbilceler.SelectedValue, txt_adres.Text, kullanici_IDTut);
            subeManage.SubeListele(gridControlSubeler);
            MessageBox.Show(mesajSube);
        }

        private void cmb_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            il_ilceGetir.ilcelerListesi(cmbiller,cmbilceler);            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                sube_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("SubelerID").ToString());
                txt_subeAdi.Text = gridView1.GetFocusedRowCellValue("SubeAdi").ToString();
                mtb_subekodu.Text = gridView1.GetFocusedRowCellValue("SubeKodu").ToString();
                mtb_tel1.Text = gridView1.GetFocusedRowCellValue("Telefon1").ToString();
                mtb_tel2.Text = gridView1.GetFocusedRowCellValue("Telefon2").ToString();
                il_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ilID").ToString());
                cmbiller.Text = subeManage.SubeilAdi(il_id);
                ilce_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ilceID").ToString());
                cmbilceler.Text = subeManage.SubeilceAdi(ilce_id);
                txt_adres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
                //logManager.kullanici_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("KullaniciID").ToString());
            }
            catch (Exception)
            {

                
            }
        }


        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            mesajSube = subeManage.SubeSil(sube_id);
            subeManage.SubeListele(gridControlSubeler);
            MessageBox.Show(mesajSube);
        }
    }
}
