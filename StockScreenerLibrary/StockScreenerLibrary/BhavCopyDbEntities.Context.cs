﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockScreenerLibrary
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BhavCopiesDbEntities : DbContext
    {
        public BhavCopiesDbEntities()
            : base("name=BhavCopiesDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BhavCopy> BhavCopies { get; set; }
        public virtual DbSet<BhavCopyUploadLog> BhavCopyUploadLogs { get; set; }
        public virtual DbSet<Housebreak> Housebreaks { get; set; }
        public virtual DbSet<Ticker> Tickers { get; set; }
        public virtual DbSet<Nifty_50> Nifty_50 { get; set; }
        public virtual DbSet<Nifty_Auto> Nifty_Auto { get; set; }
        public virtual DbSet<Nifty_Bank> Nifty_Bank { get; set; }
        public virtual DbSet<Nifty_Finance> Nifty_Finance { get; set; }
        public virtual DbSet<Nifty_Fmcg> Nifty_Fmcg { get; set; }
        public virtual DbSet<Nifty_IT> Nifty_IT { get; set; }
        public virtual DbSet<Nifty_Media> Nifty_Media { get; set; }
        public virtual DbSet<Nifty_Metal> Nifty_Metal { get; set; }
        public virtual DbSet<Nifty_Next_50> Nifty_Next_50 { get; set; }
        public virtual DbSet<Nifty_Pharma> Nifty_Pharma { get; set; }
        public virtual DbSet<Nifty_Private_Bank> Nifty_Private_Bank { get; set; }
        public virtual DbSet<Nifty_PSU_Bank> Nifty_PSU_Bank { get; set; }
        public virtual DbSet<Nifty_Realty> Nifty_Realty { get; set; }
        public virtual DbSet<Indicator> Indicators { get; set; }
    }
}
