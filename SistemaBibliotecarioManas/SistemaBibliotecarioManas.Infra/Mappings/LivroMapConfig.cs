using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaBiblitecarioManas.Entities.Entities;

namespace SistemaBibliotecarioManas.Infra.Mappings
{
    public class LivroMapConfig: IEntityTypeConfiguration<LivroEntity>
    {
        public void Configure(EntityTypeBuilder<LivroEntity> builder)
        {
            builder.ToTable("LIVROS");

            builder.Property(l => l.NomeLivro).HasColumnName("NomeLivro").HasMaxLength(30).IsRequired();
            builder.Property(l => l.NomeAutor).HasColumnName("NomeAutor").HasMaxLength(30).IsRequired();
            builder.Property(l => l.GeneroDoLivro).HasColumnName("Genero").IsRequired();
            builder.Property(l => l.Editora).HasColumnName("Editora").HasMaxLength(30).IsRequired();
            builder.Property(l => l.Paginas).HasColumnName("Paginas").IsRequired();
            builder.Property(l => l.Idioma).HasColumnName("Idioma").HasMaxLength(20).IsRequired();
            builder.Property(l => l.DataPublicacao).HasColumnName("DataPublicacao").IsRequired();
        }
    }
}
