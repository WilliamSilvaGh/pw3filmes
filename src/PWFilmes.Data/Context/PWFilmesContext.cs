using Microsoft.EntityFrameworkCore;
using PWFilmes.Data.Configuration;
using PWFilmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PWFilmes.Data.Context
{
    public class PWFilmesContext : DbContext
    {
        public DbSet<Categoria> CategoriaSet { get; set; }
        public DbSet<Filme> FilmeSet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.
            //    ApplyConfiguration(new CategoriaConfiguration());
            //modelBuilder.
            //    ApplyConfiguration(new FilmeConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string conexao = "server=localhost;port=3306;database=PWFilmes;uid=root"; //;password=123456 -> Caso tivesse!
            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
            base.OnConfiguring(optionsBuilder);
        }

    }
}
