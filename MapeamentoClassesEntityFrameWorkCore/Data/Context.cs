using MapeamentoClassesEntityFrameWorkCore.Application;
using MapeamentoClassesEntityFrameWorkCore.Domain;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.EntityFrameworkCore;

namespace MapeamentoClassesEntityFrameWorkCore.Data
{
    public class Context : DbContext
    {
        private DbSet<Categoria> Categoria { get; set; }
        private DbSet<Produtos> Produtos { get; set; }

        public Context(){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MapeamentoClassesEntityFrameWorkCore;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}