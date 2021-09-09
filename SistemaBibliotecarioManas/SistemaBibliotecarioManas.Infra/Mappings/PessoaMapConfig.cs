using SistemaBiblitecarioManas.Entities.Entities;

namespace SistemaBibliotecarioManas.Infra.Mappings
{
    public class PessoaMapConfig: IEntityTypeConfiguration<PessoaEntity>
    {
        public void Configure(EntityTypeBuilder<PessoaEntity> builder)
        {
            builder.ToTable("PESSOAS");

            builder.Property(p => p.NomePessoa).HasColumnName("NomePessoa").HasMaxLength(50).HasRequired();
            builder.Property(p => p.Email).HasColumnNane("Email").HasMaxLenght(70).HasRequired();
            builder.Property(p => p.CPF).HasColumnName("CPF").HasFixedLenght(18).IsRequired();
            builder.Property(p => p.DataNascimento).HasColumnName("Data_Nascimento").IsRequired();
            builder.Property(p => p.Telefone).HasColumnName("Telefone").IsFixedLength().HasMaxLength(11).IsRequired();
            builder.Property(p => p.TipoPessoa).HasColumnName("TipoPessoa").IsRequired();

            builder.OwnsOne(p => p.Endereco, endereco =>
            {
                endereco.Property(p => p.Rua)
                    .IsRequired()
                    .HasColumnName("Pessoa_Rua")
                    .HasColumnType("varchar(80)");

                endereco.Property(p => p.Bairro)
                    .IsRequired()
                    .HasColumnName("Pessoa_Bairro")
                    .HasColumnType("varchar(50)");

                endereco.Property(p => p.CEP)
                    .IsRequired()
                    .HasColumnName("Pessoa_CEP")
                    .HasColumnType("varchar(8)");

                endereco.Property(p => p.Cidade)
                    .IsRequired()
                    .HasColumnName("Pessoa_Cidade")
                    .HasColumnType("varchar(40)");

                endereco.Property(p => p.Complemento)
                    .IsRequired()
                    .HasColumnName("Pessoa_Complemento")
                    .HasColumnType("varchar(70)");

                endereco.Property(p =>p.Numero)
                    .IsRequired()
                    .HasColumnName("Pessoa_Numero")
                    .HasColumnType("varchar(6)");

                endereco.Property(p => p.UF)
                    .IsRequired()
                    .HasColumnName("Pessoa_UF")
                    .HasMaxLength(3);
            });
        }
    }
}
