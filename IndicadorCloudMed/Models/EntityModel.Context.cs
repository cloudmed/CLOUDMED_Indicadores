﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IndicadorGedWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IndicadorCloudMedEntities : DbContext
    {
        public IndicadorCloudMedEntities()
            : base("name=IndicadorCloudMedEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Autorizacoes> Autorizacoes { get; set; }
        public DbSet<Documentos> Documentos { get; set; }
        public DbSet<Orcamentos> Orcamentos { get; set; }
        public DbSet<Protocolos> Protocolos { get; set; }
        public DbSet<Validacoes> Validacoes { get; set; }
    }
}
