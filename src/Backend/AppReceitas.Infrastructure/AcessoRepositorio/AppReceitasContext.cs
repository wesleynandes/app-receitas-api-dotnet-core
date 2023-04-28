using AppReceitas.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AppReceitas.Infrastructure.AcessoRepositorio;

public class AppReceitasContext : DbContext
{
    public AppReceitasContext(DbContextOptions<AppReceitasContext> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppReceitasContext).Assembly);
    }
}
