using Microsoft.EntityFrameworkCore;
using PWFilmes.Data.Configuration;
using PWFilmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
            modelBuilder.
                ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.
                ApplyConfiguration(new FilmeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
