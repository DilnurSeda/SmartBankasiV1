using SmartBankasi.BLL.Yetkiislemleri;
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
    public partial class Frm_Yetkiler : Form
    {
        public Frm_Yetkiler()
        {
            InitializeComponent();
        }
        YetkilerManager yManage = new YetkilerManager();
       
        private void Frm_Yetkiler_Load(object sender, EventArgs e)
        {
            yManage.YetkiListesi(gridControlYetki);
        }
        int yetki_id;
        string mesajYetki;
        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            mesajYetki = yManage.YetkiKaydet(txt_yetkiAdi.Text);
            yManage.YetkiListesi(gridControlYetki);
            MessageBox.Show(mesajYetki);
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            mesajYetki = yManage.YetkiGuncelle(yetki_id,txt_yetkiAdi.Text);
            yManage.YetkiListesi(gridControlYetki);
            MessageBox.Show(mesajYetki);
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            mesajYetki = yManage.YetkiSil(yetki_id);
            yManage.YetkiListesi(gridControlYetki);
            MessageBox.Show(mesajYetki);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                yetki_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("YetkilerID").ToString());
                txt_yetkiAdi.Text = gridView1.GetFocusedRowCellValue("YetkiAdi").ToString();
            }
            catch (Exception)
            {

               
            }
        }

       
    }
}
