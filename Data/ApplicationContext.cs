using CursoEFCore.Configurations;
using CursoEFCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CursoEFCore.Date
{
    public class ApplicationContext : DbContext
    {
        //Utilizando DbSet para criar as instancias
        // public DbSet<Pedido> Pedidos { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Initial Catalog=CursoEFCore1; Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoItemConfiguration());
        }
    }
}