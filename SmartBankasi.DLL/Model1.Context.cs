﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartBankasi.DLL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SmartBankDBEntities : DbContext
    {
        public SmartBankDBEntities()
            : base("name=SmartBankDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BireyselMusteriler> BireyselMusteriler { get; set; }
        public DbSet<BireyselMusteriUrunleri> BireyselMusteriUrunleri { get; set; }
        public DbSet<Faturalar> Faturalar { get; set; }
        public DbSet<Gelirler> Gelirler { get; set; }
        public DbSet<Giderler> Giderler { get; set; }
        public DbSet<Gorevler> Gorevler { get; set; }
        public DbSet<ilceler> ilceler { get; set; }
        public DbSet<iller> iller { get; set; }
        public DbSet<Kampanyalar> Kampanyalar { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<KurumsalMusteriler> KurumsalMusteriler { get; set; }
        public DbSet<KurumsalMusteriUrunleri> KurumsalMusteriUrunleri { get; set; }
        public DbSet<KurumsalYetkililer> KurumsalYetkililer { get; set; }
        public DbSet<MusteriTurleri> MusteriTurleri { get; set; }
        public DbSet<Odemeler> Odemeler { get; set; }
        public DbSet<OdemePlanlari> OdemePlanlari { get; set; }
        public DbSet<OdemeTurleri> OdemeTurleri { get; set; }
        public DbSet<ParaBirimleri> ParaBirimleri { get; set; }
        public DbSet<PersonelDetay> PersonelDetay { get; set; }
        public DbSet<PersonelGorevYerleri> PersonelGorevYerleri { get; set; }
        public DbSet<Personeller> Personeller { get; set; }
        public DbSet<PersonelMaaslari> PersonelMaaslari { get; set; }
        public DbSet<SubeGiderTurleri> SubeGiderTurleri { get; set; }
        public DbSet<Subeler> Subeler { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<UrunDetaylari> UrunDetaylari { get; set; }
        public DbSet<Urunler> Urunler { get; set; }
        public DbSet<UrunTurleri> UrunTurleri { get; set; }
        public DbSet<Yetkiler> Yetkiler { get; set; }
    }
}
