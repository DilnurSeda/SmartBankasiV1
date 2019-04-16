using SmartBankasi.BLL.Gorevislemleri;
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
    public partial class Frm_Gorevler : Form
    {
        public Frm_Gorevler()
        {
            InitializeComponent();
        }

        string mesaj;

        GorevlerManager gorevManage = new GorevlerManager();
        public int kullanici_IDTut;
        int gorev_id;
        private void Frm_Gorevler_Load(object sender, EventArgs e)
        {
            gorevManage.GorevListesi(gridControlGorevler);
        }

        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            mesaj = gorevManage.GorevKaydet(txt_gorevAdi.Text, txt_aciklama.Text, kullanici_IDTut);
            gorevManage.GorevListesi(gridControlGorevler);
            MessageBox.Show(mesaj);

        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            mesaj = gorevManage.GorevGuncelle(gorev_id,txt_gorevAdi.Text, txt_aciklama.Text, kullanici_IDTut);
            gorevManage.GorevListesi(gridControlGorevler);
            MessageBox.Show(mesaj);
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            mesaj = gorevManage.GorevSil(gorev_id);
            gorevManage.GorevListesi(gridControlGorevler);
            MessageBox.Show(mesaj);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                gorev_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("GorevlerID").ToString());
                txt_gorevAdi.Text = gridView1.GetFocusedRowCellValue("GorevAdi").ToString();
                txt_aciklama.Text = gridView1.GetFocusedRowCellValue("Aciklama").ToString();
            }
            catch (Exception)
            {

                
            }

        }

    }
}
