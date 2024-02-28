using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PWFilmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWFilmes.Data.Configuration
{
    public class FilmeConfiguration
        : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .HasMaxLength(300)
                .IsRequired();

            builder.Property(p => p.Diretor)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.Atores)
                .HasMaxLength(2000)
                .IsRequired();

            builder.Property(p => p.AnoLancamento)
                .IsRequired();

            builder.Property(p => p.Categoria)
                .IsRequired();

            builder.ToTable("TB_Filme");
        }
    }
}
