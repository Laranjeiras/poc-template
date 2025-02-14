using Microsoft.EntityFrameworkCore;
using ROJINE.Domain.Entities;

namespace ROJINE.Infrastructure.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Produto> Produtos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Nome).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Preco).HasPrecision(10, 2);
        });
    }
} 