﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolMgtSys.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class schoolMgtDbEntities : DbContext
    {
        public schoolMgtDbEntities()
            : base("name=schoolMgtDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<batch> batches { get; set; }
        public virtual DbSet<course> courses { get; set; }
        public virtual DbSet<registration> registrations { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}