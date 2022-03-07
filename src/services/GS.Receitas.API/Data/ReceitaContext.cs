using GS.Core.Data;
using GS.Receitas.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GS.Receitas.API.Data
{
    public class ReceitaContext : DbContext, IUnitOfWork
    {
        public ReceitaContext(DbContextOptions<ReceitaContext> options) : base(options)
        {
        }

        public DbSet<Receita> Receitas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                      e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ReceitaContext).Assembly);
        }
        public async Task<bool> CommitAsync()
        {
            var sucesso = await base.SaveChangesAsync() > 0;

            return sucesso;
        }


    }
}
