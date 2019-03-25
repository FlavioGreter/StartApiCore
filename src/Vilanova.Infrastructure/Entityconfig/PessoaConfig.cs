using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vilanova.Domain.Entities;

namespace Vilanova.Infrastructure.Entityconfig
{
    public class PessoaConfig : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoas");

            builder.HasKey(k => k.id);

            builder.Property(k => k.id)
                .HasColumnName("PessoaId");

            builder.Property(n => n.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasMaxLength(255);

            builder.Property(n => n.SobreNome)
                .IsRequired()
                .HasColumnName("SobreNome")
                .HasMaxLength(255);

            builder.Property(n => n.Rg)
                .HasColumnName("Rg")
                .HasMaxLength(8);

            builder.Property(n => n.Cpf)
                .HasColumnName("Cpf")
                .HasMaxLength(11);

            builder.Property(n => n.DataNascimento)
                .HasColumnName("DataNascimento");

            //Mapeamento dos relacionamentos
          

            builder.HasMany(e => e.Enderecos)
                .WithOne(p => p.Pessoa)
                .HasForeignKey(e => e.PessoaId)
                .HasPrincipalKey(p => p.id);

            builder.HasMany(c => c.Contatos)
                .WithOne(p => p.Pessoa)
                .HasForeignKey(c => c.PessoaId)
                .HasPrincipalKey(p => p.id);
        }
    }
}
