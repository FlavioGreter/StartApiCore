using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vilanova.ApplicationCore.Entities;

namespace Vilanova.Infrastructure.Entityconfig
{
    public class AlunoConfig : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Alunos");

            builder.HasKey(k => k.id);

            builder.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(p => p.SobreNome)
                .HasColumnName("SobreNome")
                .HasMaxLength(150)
                .IsRequired();
            
        }
    }
}
