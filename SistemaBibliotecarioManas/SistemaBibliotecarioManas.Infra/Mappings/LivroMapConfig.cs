﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaBiblitecarioManas.Entities.Entities;

namespace SistemaBibliotecarioManas.Infra.Mappings
{
    public class LivroMapConfig: IEntityTypeConfiguration<LivroEntity>
    {
        public void Configure(EntityTypeBuilder<LivroEntity> builder)
        {
            builder.ToTable("LIVROS");

            builder.Property(l => l.NomeLivro).HasColumnName("NomeLivro").HasMaxLength(50).IsRequired();
            builder.Property(l => l.NomeAutor).HasColumnName("NomeAutor").HasMaxLength(40).IsRequired();
            builder.Property(l => l.GeneroDoLivro).HasColumnName("Genero").IsRequired();
        }
    }
}
