using efp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace efp.DataAccesLayer
{
    public class SalesContext : DbContext
    {
        public SalesContext() : base("SalesDatabase") { }

        public DbSet<Product> Products { get; set; }


        // Türkçe isimlendirme yaparsak Tablolarda çoğul eklerde s ies takıları sırasında Türkçe olacağı sorun çıkmaması için
        // aşağıdaki methodu override ederek oluşturulan Türkçe tabloların sonuna "s" takısı gelmiyor.
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}

    }
}