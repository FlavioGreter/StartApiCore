using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Vilanova.Domain.Entities;

namespace Vilanova.Infrastructure.Entityconfig
{
    public class ContatoConfig : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("Contatos");

            builder.HasKey(k => k.id);
            builder.Property(k => k.id)
                .HasColumnName("ContatoId");

            builder.Property(c => c.Descricao)
                .HasColumnName("Descricao")
                .HasMaxLength(255);

            builder.Property(c => c.TipoContatoId)
               .HasColumnName("TipoContatoId");

            builder.HasOne(tc => tc.TipoContato)
             .WithMany(e => e.Contatos)
             .HasForeignKey(fk => fk.TipoContatoId)
             .HasPrincipalKey(e => e.id);

            builder.HasOne(p => p.Pessoa)
              .WithMany(e => e.Contatos)
              .HasForeignKey(fk => fk.PessoaId)
              .HasPrincipalKey(e => e.id);

        }
    }
}
