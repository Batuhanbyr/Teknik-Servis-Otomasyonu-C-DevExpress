﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikServis3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbTeknikServisEntities : DbContext
    {
        public DbTeknikServisEntities()
            : base("name=DbTeknikServisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBLADMIN> TBLADMIN { get; set; }
        public virtual DbSet<TBLARACLAR> TBLARACLAR { get; set; }
        public virtual DbSet<TBLARIZADETAY> TBLARIZADETAY { get; set; }
        public virtual DbSet<TBLCARI> TBLCARI { get; set; }
        public virtual DbSet<TBLDEPARTMAN> TBLDEPARTMAN { get; set; }
        public virtual DbSet<TBLFATURABILGI> TBLFATURABILGI { get; set; }
        public virtual DbSet<TBLFATURADETAY> TBLFATURADETAY { get; set; }
        public virtual DbSet<TBLGIDER> TBLGIDER { get; set; }
        public virtual DbSet<TBLHAKKIMIZDA> TBLHAKKIMIZDA { get; set; }
        public virtual DbSet<TBLİLETİSİM> TBLİLETİSİM { get; set; }
        public virtual DbSet<TBLKATEGORİ> TBLKATEGORİ { get; set; }
        public virtual DbSet<TBLNOTLARIM> TBLNOTLARIM { get; set; }
        public virtual DbSet<TBLPERSONEL> TBLPERSONEL { get; set; }
        public virtual DbSet<TBLURUN> TBLURUN { get; set; }
        public virtual DbSet<TBLURUNHAREKET> TBLURUNHAREKET { get; set; }
        public virtual DbSet<TBLURUNKABUL> TBLURUNKABUL { get; set; }
        public virtual DbSet<TBLURUNTAKIP> TBLURUNTAKIP { get; set; }
        public virtual DbSet<TBLILCELER> TBLILCELER { get; set; }
        public virtual DbSet<TBLILLER> TBLILLER { get; set; }
    
        public virtual ObjectResult<ürünkategori_Result> ürünkategori()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ürünkategori_Result>("ürünkategori");
        }
    
        public virtual ObjectResult<string> makskategoriurun()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("makskategoriurun");
        }
    
        public virtual ObjectResult<marksurunmarka_Result> marksurunmarka()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<marksurunmarka_Result>("marksurunmarka");
        }
    
        public virtual ObjectResult<string> maksurunmarka()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("maksurunmarka");
        }
    }
}
