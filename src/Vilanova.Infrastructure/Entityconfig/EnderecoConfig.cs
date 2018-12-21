using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vilanova.Domain.Entities;

namespace Vilanova.Infrastructure.Entityconfig
{
    public class EnderecoConfig : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Enderecos");

            builder.HasKey(k => k.id);

            builder.Property(k => k.id)
                .HasColumnName("EnderecoId");

            builder.Property(e => e.Bairro)
                .HasColumnName("Bairro")
                .HasMaxLength(255);

            builder.Property(e => e.Descricao)
                .HasColumnName("Descricao")
                .HasMaxLength(255);

            builder.HasOne(p => p.Pessoa)
                .WithMany(e => e.Endereco)
                .HasForeignKey(fk => fk.PessoaId)
                .HasForeignKey(e => e.id);
               

            //builder.HasMany(e => e.Endereco)
            //   .WithOne(p => p.Pessoa)
            //   .HasForeignKey(e => e.PessoaId)
            //   .HasPrincipalKey(p => p.id);
        }
    }
}
