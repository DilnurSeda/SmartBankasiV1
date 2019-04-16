using SmartBankasi.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBankasi.BLL.MusteriTurleriislemleri
{
    public class MusteriTurleriManager
    {
        SmartBankDBEntities db = new SmartBankDBEntities();
        //***************************************************

        public void MusteriTurleri(ComboBox comboMusteriTurleri)
        {
            comboMusteriTurleri.DisplayMember = "TurAdi";
            comboMusteriTurleri.ValueMember = "MusteriTurleriID";
            comboMusteriTurleri.DataSource = db.MusteriTurleri.ToList();
            //***************************************************

        }
        public void Musteriler(ComboBox comboMusteriler)
        {
            comboMusteriler.DisplayMember = "TC";
            comboMusteriler.ValueMember = "BireyselMustrilerID";
            comboMusteriler.DataSource = db.BireyselMusteriler.ToList();
            //***************************************************

        }
        //--------------------------
        public string isim;
        public string soyisim;
        //----------------------------
        public void KurumsalMusteriGetir(string tc)
        {
            var kurMusteri = db.KurumsalYetkililer.Where(k => k.TC == tc).FirstOrDefault();
            isim=kurMusteri.Adi;
            soyisim=kurMusteri.Soyadi;
        }
        public void BireyselMusteriGetir(string tc)
        {
            var birMusteri = db.BireyselMusteriler.Where(k => k.TC == tc).FirstOrDefault();
            isim = birMusteri.Adi;
            soyisim = birMusteri.Soyadi;
        }
        public void BireyselMusteriGetir(ComboBox cmbmusteri)
        {
            cmbmusteri.DisplayMember = "TC";
            cmbmusteri.ValueMember = "BireyselMustrilerID";
            cmbmusteri.DataSource = db.BireyselMusteriler.ToList();
        }
        public void KurumsalMusteriGetir(ComboBox cmbmusteri)
        {
            cmbmusteri.DisplayMember = "TC";
            cmbmusteri.ValueMember = "KurumsalYetkililerID";
            cmbmusteri.DataSource = db.KurumsalYetkililer.ToList();
        }



    }
}
