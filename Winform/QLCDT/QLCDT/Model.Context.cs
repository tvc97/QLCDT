﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLCDT
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLCDTEntities : DbContext
    {
        public QLCDTEntities()
            : base("name=QLCDTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHITIETSD> CHITIETSDs { get; set; }
        public virtual DbSet<GIACUOC> GIACUOCs { get; set; }
        public virtual DbSet<HDDK> HDDKs { get; set; }
        public virtual DbSet<HDTC> HDTCs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<THONGTINSIM> THONGTINSIMs { get; set; }
    }
}
