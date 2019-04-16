using SmartBankasi.BLL.Kampanyaislemleri;
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
    public partial class Frm_Kampanyalar : Form
    {
        public Frm_Kampanyalar()
        {
            InitializeComponent();
        }
        KampanyalarManager kManage = new KampanyalarManager();
        public int kullanici_IDTut;
        int kampanya_id;
        string mesaj;
        private void Frm_Kampanyalar_Load(object sender, EventArgs e)
        {
            kManage.KampanyaListesi(gridControlKampanya);
        }

        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            if (date_bitisTarihi.Visible==false)
            {
                mesaj = kManage.KampanyaKaydet(date_baslangicTarihi.Value, null, txt_kmpnyaAdi.Text, txt_aciklama.Text, kullanici_IDTut);
                kManage.KampanyaListesi(gridControlKampanya);
                MessageBox.Show(mesaj);
            }
            if (date_bitisTarihi.Visible == true)
            {
                mesaj = kManage.KampanyaKaydet(date_baslangicTarihi.Value, date_bitisTarihi.Value, txt_kmpnyaAdi.Text, txt_aciklama.Text, kullanici_IDTut);
                kManage.KampanyaListesi(gridControlKampanya);
                MessageBox.Show(mesaj);
            }
           
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            if (date_bitisTarihi.Visible == false)
            {
                mesaj = kManage.KampanyaGuncelle(kampanya_id, date_baslangicTarihi.Value, null, txt_kmpnyaAdi.Text, txt_aciklama.Text, kullanici_IDTut);
                kManage.KampanyaListesi(gridControlKampanya);
                MessageBox.Show(mesaj);
            }
            if (date_bitisTarihi.Visible == true)
            {
                mesaj = kManage.KampanyaGuncelle(kampanya_id, date_baslangicTarihi.Value, date_bitisTarihi.Value, txt_kmpnyaAdi.Text, txt_aciklama.Text, kullanici_IDTut);
                kManage.KampanyaListesi(gridControlKampanya);
                MessageBox.Show(mesaj);
            }
            
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            mesaj = kManage.KampanyaSil(kampanya_id);
            kManage.KampanyaListesi(gridControlKampanya);
            MessageBox.Show(mesaj);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                kampanya_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("KampanyalarID").ToString());
                date_baslangicTarihi.Value = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("BaslangicTarihi").ToString());
                date_bitisTarihi.Value = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("BirisTarihi").ToString());
                txt_kmpnyaAdi.Text = gridView1.GetFocusedRowCellValue("KampanyaAdi").ToString();
                txt_aciklama.Text = gridView1.GetFocusedRowCellValue("Aciklama").ToString();
            }
            catch (Exception)
            {

                
            }

        }

        private void btnCikisTarihiEkle_Click(object sender, EventArgs e)
        {
            date_bitisTarihi.Visible = true;
            label10.Visible = true;
        }

        private void btnVazgecCikis_Click(object sender, EventArgs e)
        {
            date_bitisTarihi.Visible = false;
            label10.Visible = false;
        }
    }
}
