using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vilanova.Domain.Entities;

namespace Vilanova.Infrastructure.Entityconfig
{
    public class TipoContatoConfig : IEntityTypeConfiguration<TipoContato>
    {
        public void Configure(EntityTypeBuilder<TipoContato> builder)
        {
            builder.ToTable("TipoContatos");

            builder.HasKey(k => k.id).HasName("TipoContato");

            builder.Property(t => t.Descricao)
                .IsRequired()
                .HasColumnName("Descricao")
                .HasMaxLength(255);

            builder.HasMany(e => e.Contatos)
                .WithOne(p => p.TipoContato)
                .HasForeignKey(e => e.TipoContatoId)
                .HasPrincipalKey(p => p.id);

        }
    }
}
