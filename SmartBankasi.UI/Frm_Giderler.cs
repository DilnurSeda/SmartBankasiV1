using SmartBankasi.BLL.Giderislemleri;
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
    public partial class Frm_Giderler : Form
    {
        public Frm_Giderler()
        {
            InitializeComponent();
        }
        GiderlerManager giderManage = new GiderlerManager();
        string mesaj;
        int subegiderturu_id,gider_id;
        public int kullanici_IDTut;
        private void Frm_Giderler_Load(object sender, EventArgs e)
        {
            giderManage.GiderleriListele(gridControlGiderler);
        }

        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            mesaj = giderManage.GiderKaydet(subegiderturu_id, date_giderTarihi.Value, Convert.ToDecimal(mtb_miktar.Text), txt_aciklama.Text, FaizliMi(cmb_faizlimi), Convert.ToDecimal(mtb_faizorani.Text), kullanici_IDTut);
            giderManage.GiderleriListele(gridControlGiderler);
            MessageBox.Show(mesaj);
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            mesaj = giderManage.GiderGuncelle(gider_id, subegiderturu_id, date_giderTarihi.Value, Convert.ToDecimal(mtb_miktar.Text), txt_aciklama.Text, FaizliMi(cmb_faizlimi), Convert.ToDecimal(mtb_faizorani.Text), kullanici_IDTut);
            giderManage.GiderleriListele(gridControlGiderler);
            MessageBox.Show(mesaj);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gider_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("GiderlerID").ToString());
            subegiderturu_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("SubeGiderTuruID").ToString());
            date_giderTarihi.Value = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("Tarihi").ToString());
            mtb_miktar.Text = gridView1.GetFocusedRowCellValue("Miktari").ToString();
            txt_aciklama.Text= gridView1.GetFocusedRowCellValue("Aciklama").ToString();
            if (gridView1.GetFocusedRowCellValue("Faizlimi").ToString()=="True")
            {
                cmb_faizlimi.Text = "Evet";
            }
            if (gridView1.GetFocusedRowCellValue("Faizlimi").ToString() == "False")
            {
                cmb_faizlimi.Text = "Hayır";
            }
            //cmb_faizlimi.Text= gridView1.GetFocusedRowCellValue("Faizlimi").ToString();
            mtb_faizorani.Text= gridView1.GetFocusedRowCellValue("FaizOrani").ToString();

        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            mesaj = giderManage.GiderSil(gider_id);
            giderManage.GiderleriListele(gridControlGiderler);
            MessageBox.Show(mesaj);
        }
        private bool FaizliMi(ComboBox cmbfaizlimi)
        {
            if (cmbfaizlimi.Text=="Evet")
            {
                return true;
            }
            else if(cmbfaizlimi.Text=="Hayır")
            {
                return false;
            }
            return false;
        }
    }
}
