using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaBiblitecarioManas.Entities.Entities;

namespace SistemaBibliotecarioManas.Infra.Mappings
{
    public class UsuarioMapConfig : IEntityTypeConfiguration<UsuarioEntity>
    {
        public void Configure(EntityTypeBuilder<UsuarioEntity> builder)
        {
            builder.ToTable("USUARIOS");

            builder.Property(u => u.NomeUsuario).HasColumnName("NomeUsuario").HasMaxLength(50).IsRequired();
            builder.Property(u => u.Senha).HasColumnName("Senha").IsRequired();
            builder.Property(u => u.Email).HasColumnName("Email").HasMaxLength(60).IsRequired();
        }
    }
}
