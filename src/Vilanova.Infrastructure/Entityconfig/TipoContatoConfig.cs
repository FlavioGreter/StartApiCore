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

            builder.HasMany(C => C.Contato)
                .WithOne(t => t.TipoContato)
                .HasForeignKey(c => c.TipoContatoId)
                .HasPrincipalKey(t => t.id);
                
        }
    }
}
