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
        }
    }
}
