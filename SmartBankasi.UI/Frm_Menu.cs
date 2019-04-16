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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }
        Frm_Personeller frmPersonel;
        public int kullaniciIDMenu;
        private void btn_Personeller_CheckedChanged(object sender, EventArgs e)
        {
            if (frmPersonel==null || frmPersonel.IsDisposed==true )
            {
                frmPersonel = new Frm_Personeller();
                frmPersonel.kullanici_IDTut = Convert.ToInt32(label1.Text);
                frmPersonel.MdiParent = this;
                frmPersonel.Show();
            }
        }
        Frm_Urunler frm_urunler;
        private void btn_Urunler_CheckedChanged(object sender, EventArgs e)
        {
            if (frm_urunler==null || frm_urunler.IsDisposed==true)
            {
                frm_urunler = new Frm_Urunler();
                frm_urunler.kullanici_IDTut = Convert.ToInt32(label1.Text);
                frm_urunler.MdiParent = this;
                frm_urunler.Show();
            }
        }

        Frm_BireyselMusteriler frm_bireyselMusteri;
        private void btn_Musteriler_CheckedChanged(object sender, EventArgs e)
        {
            if (frm_bireyselMusteri==null || frm_bireyselMusteri.IsDisposed==true)
            {
                frm_bireyselMusteri = new Frm_BireyselMusteriler();
                frm_bireyselMusteri.kullanici_IDTut = Convert.ToInt32(label1.Text);
                frm_bireyselMusteri.MdiParent = this;
                frm_bireyselMusteri.Show();
            }
        }
        Frm_KurumsalMusteriler frm_kurumsalMusteri;
        private void btn_kurumsalmusteriler_CheckedChanged(object sender, EventArgs e)
        {
            if (frm_kurumsalMusteri == null || frm_kurumsalMusteri.IsDisposed == true)
            {
                frm_kurumsalMusteri = new Frm_KurumsalMusteriler();
                frm_kurumsalMusteri.kullanici_IDTut = Convert.ToInt32(label1.Text);
                frm_kurumsalMusteri.MdiParent = this;
                frm_kurumsalMusteri.Show();
            }
        }
        Frm_Kullanicilar frm_kullanicilar;
        private void btn_kullanicilar_CheckedChanged(object sender, EventArgs e)
        {
            if (frm_kullanicilar == null || frm_kullanicilar.IsDisposed == true)
            {
                frm_kullanicilar = new Frm_Kullanicilar();
                frm_kullanicilar.kullanici_IDTut = Convert.ToInt32(label1.Text);
                frm_kullanicilar.MdiParent = this;
                frm_kullanicilar.Show();
            }
        }
        Frm_Subeler frm_subeler;
        private void btn_Subeler_CheckedChanged(object sender, EventArgs e)
        {

            if (frm_subeler == null || frm_subeler.IsDisposed == true)
            {
                frm_subeler = new Frm_Subeler();
                frm_subeler.kullanici_IDTut = Convert.ToInt32(label1.Text);
                frm_subeler.MdiParent = this;
                frm_subeler.Show();
            }
        }

        Frm_ParaBirimleri frm_parabirimleri;
        private void btn_paraBirimleri_CheckedChanged(object sender, EventArgs e)
        {

            if (frm_parabirimleri == null || frm_parabirimleri.IsDisposed == true)
            {
                frm_parabirimleri = new Frm_ParaBirimleri();
                frm_parabirimleri.MdiParent = this;
                frm_parabirimleri.Show();
            }
        }
        Frm_Giderler frm_gider;
        private void btn_Gider_CheckedChanged(object sender, EventArgs e)
        {
            if (frm_gider == null || frm_gider.IsDisposed == true)
            {
                frm_gider = new Frm_Giderler();
                frm_gider.kullanici_IDTut = Convert.ToInt32(label1.Text);
                frm_gider.MdiParent = this;
                frm_gider.Show();
            }
        }
        Frm_Yetkiler frm_yetki;
        private void btn_Ayarlar_CheckedChanged(object sender, EventArgs e)
        {
            if (frm_yetki == null || frm_yetki.IsDisposed == true)
            {
                frm_yetki = new Frm_Yetkiler();
                frm_yetki.MdiParent = this;
                frm_yetki.Show();
            }
        }
        Frm_Odemeler frm_odemeler;
        private void btn_odemeler_CheckedChanged(object sender, EventArgs e)
        {
            if (frm_odemeler == null || frm_odemeler.IsDisposed == true)
            {
                frm_odemeler = new Frm_Odemeler();
                frm_odemeler.kullanici_IDTut = Convert.ToInt32(label1.Text);
                frm_odemeler.MdiParent = this;
                frm_odemeler.Show();
            }

        }
        Frm_Kampanyalar frm_kampanya;
        private void btn_kampanyalar_CheckedChanged(object sender, EventArgs e)
        {
            if (frm_subeler == null || frm_subeler.IsDisposed == true)
            {
                frm_kampanya = new Frm_Kampanyalar();
                frm_kampanya.kullanici_IDTut = Convert.ToInt32(label1.Text);
                frm_kampanya.MdiParent = this;
                frm_kampanya.Show();
            }
        }
        Frm_Gorevler frm_gorev;
        private void btn_Gorevler_CheckedChanged(object sender, EventArgs e)
        {
            if (frm_gorev == null || frm_gorev.IsDisposed == true)
            {
                frm_gorev = new Frm_Gorevler();
                frm_gorev.kullanici_IDTut = Convert.ToInt32(label1.Text);
                frm_gorev.MdiParent = this;
                frm_gorev.Show();
            }
        }
        Frm_Faturalar frm_fatura;
        private void btn_Faturalar_CheckedChanged(object sender, EventArgs e)
        {
            if (frm_fatura == null || frm_fatura.IsDisposed == true)
            {
                frm_fatura = new Frm_Faturalar();
                frm_fatura.kullanici_IDTut = Convert.ToInt32(label1.Text);
                frm_fatura.MdiParent = this;
                frm_fatura.Show();
            }
        }
    }
}
