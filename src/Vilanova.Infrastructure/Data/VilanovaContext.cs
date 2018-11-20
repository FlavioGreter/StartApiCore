using Microsoft.EntityFrameworkCore;
using Vilanova.Domain.Entities;
using Vilanova.Infrastructure.Entityconfig;

namespace Vilanova.Infrastructure.Data
{
    public class VilanovaContext: DbContext
    {
        public VilanovaContext(DbContextOptions<VilanovaContext> options) : base(options) { }
        
        public DbSet<Aluno> Alunos { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoConfig());
        }

    }
}
