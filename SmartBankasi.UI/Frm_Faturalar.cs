using SmartBankasi.BLL.Faturaislemleri;
using SmartBankasi.BLL.MusteriTurleriislemleri;
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
    public partial class Frm_Faturalar : Form
    {
        public Frm_Faturalar()
        {
            InitializeComponent();
        }
        FaturalarManager fManage = new FaturalarManager();
        MusteriTurleriManager mtmanage = new MusteriTurleriManager();
        string mesaj;
        public int kullanici_IDTut;
        int musterituru_id, musteri_id, odemeplani_id,fatura_id;
        private void Frm_Faturalar_Load(object sender, EventArgs e)
        {
            fManage.FaturaListesi(gridControlFaturalar);            
            cmbx_musterituru.DisplayMember = "TurAdi";
            cmbx_musterituru.ValueMember = "MusteriTurleriID";
            cmbx_musterituru.DataSource = fManage.MusteriTurleriListesi();
            mtmanage.MusteriTurleri(cmbx_musterituru);
            cmb_odemeler.DisplayMember = "OdemePlanlariID";
            cmb_odemeler.ValueMember = "OdemePlanlariID";
            fManage.OdemePlanlariListesi(cmb_odemeler);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                fatura_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("FaturalarID").ToString());
                date_faturaTarihi.Value = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("FaturaTarihi").ToString());
                time_faturasaati.Value = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("FaturaSaati").ToString());
                musterituru_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("MusteriTuruID").ToString());
                cmbx_musterituru.Text = fManage.MusteriTuruAdi(musterituru_id);
                musteri_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("MusteriID").ToString());
                cmb_musteri.Text = fManage.MusteriAdi(musteri_id, musterituru_id);
                odemeplani_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("OdemePlaniID").ToString());
                txt_aciklama.Text = gridView1.GetFocusedRowCellValue("Aciklama").ToString();
            }
            catch (Exception)
            {

                
            }
        }

        private void cmbx_musterituru_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                musterituru_id = (int)cmbx_musterituru.SelectedValue;
            }
            catch (Exception)
            { }
                if (cmbx_musterituru.Text == "Bireysel")
                {
                    cmb_musteri.DataSource = fManage.BireyselMusteriListesi();
                    cmb_musteri.DisplayMember = "Adi";
                    cmb_musteri.ValueMember = "BireyselMustrilerID";
                }
                else if (cmbx_musterituru.Text == "Kurumsal")
                {
                    cmb_musteri.DataSource = fManage.KurumsalMusteriListesi();
                    cmb_musteri.DisplayMember = "KurumAdi";
                    cmb_musteri.ValueMember = "KurumsalMusterilerID";

                }
                else
                {
                    cmb_musteri.DataSource = fManage.BireyselMusteriListesi();
                    cmb_musteri.DisplayMember = "Adi";
                    cmb_musteri.ValueMember = "BireyselMustrilerID";

                }

        }

        private void cmb_musteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                musteri_id = (int)cmb_musteri.SelectedValue;
            }
            catch (Exception)
            {


            }
        }

        private void cmb_odemeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                odemeplani_id = (int)cmb_odemeler.SelectedValue;
            }
            catch (Exception)
            {

            }
        }

        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            mesaj = fManage.FaturaKaydet(date_faturaTarihi.Value, TimeSpan.Parse(time_faturasaati.Text), musterituru_id, musteri_id, odemeplani_id, txt_aciklama.Text, kullanici_IDTut);
            fManage.FaturaListesi(gridControlFaturalar);
            MessageBox.Show(mesaj);
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            mesaj = fManage.FaturaGuncelle(fatura_id,date_faturaTarihi.Value, TimeSpan.Parse(time_faturasaati.Text), musterituru_id, musteri_id, odemeplani_id, txt_aciklama.Text, kullanici_IDTut);
            fManage.FaturaListesi(gridControlFaturalar);
            MessageBox.Show(mesaj);
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            mesaj = fManage.FaturaSil(fatura_id);
            MessageBox.Show(mesaj);
        }

     
    }
}
