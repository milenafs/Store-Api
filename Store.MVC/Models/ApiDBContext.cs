
using Microsoft.EntityFrameworkCore;
using Store.MVC.Maps;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using StoreModel = Store.MVC.Models.Store;

namespace Store.MVC.Models
{
#pragma warning disable CS1591
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
        : base(options)
        {

        }
        public DbSet<Store> Stores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new StoreMap(modelBuilder.Entity<Store>());
        }
    }
#pragma warning restore CS1591
}