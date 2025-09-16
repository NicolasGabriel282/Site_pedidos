

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedidos_view.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Pedidos_view.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext((DbContextOptions)options)
    {
        public DbSet<Pedidos> Pedidoss { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedidos>((Action<EntityTypeBuilder<Pedidos>>)(entity => entity.ToView<Pedidos>("pedidos_portal").HasNoKey()));
        }
    }
}
