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
    public class CategoriaConfiguration :
        IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Descricao)
                .HasMaxLength(200)
                .IsRequired();

            builder.ToTable("TB_Categoria");
        }
    }
}
