using SmartBankasi.BLL.ParaBirimiislemleri;
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
    public partial class Frm_ParaBirimleri : Form
    {
        ParaBirimleriManager parabirimManage = new ParaBirimleriManager();
        string mesajParaBirim;
        int parabirim_id;

        public Frm_ParaBirimleri()
        {
            InitializeComponent();
        }       

        private void Frm_ParaBirimleri_Load(object sender, EventArgs e)
        {
            parabirimManage.ParaBirimleriListele(gridControlParabirimleri);
        }

        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            mesajParaBirim = parabirimManage.ParaBirimiKaydet(txt_birimAdi.Text, txt_aciklama.Text);
            parabirimManage.ParaBirimleriListele(gridControlParabirimleri);
            MessageBox.Show(mesajParaBirim);
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            mesajParaBirim = parabirimManage.ParaBirimiGuncelle(parabirim_id,txt_birimAdi.Text, txt_aciklama.Text);
            parabirimManage.ParaBirimleriListele(gridControlParabirimleri);
            MessageBox.Show(mesajParaBirim);
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            mesajParaBirim = parabirimManage.ParaBirimiSil(parabirim_id);
            parabirimManage.ParaBirimleriListele(gridControlParabirimleri);
            MessageBox.Show(mesajParaBirim);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                parabirim_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ParaBirimleriID").ToString());
                txt_birimAdi.Text = gridView1.GetFocusedRowCellValue("BirimAdi").ToString();
                txt_aciklama.Text = gridView1.GetFocusedRowCellValue("Aciklama").ToString();
            }
            catch (Exception)
            {
                
            }
        }
    }
}
