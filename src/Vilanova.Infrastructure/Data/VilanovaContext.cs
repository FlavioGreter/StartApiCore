using Microsoft.EntityFrameworkCore;
using Vilanova.Domain.Entities;
using Vilanova.Infrastructure.Entityconfig;


namespace Vilanova.Infrastructure.Data
{
    public class VilanovaContext: DbContext
    {
        public VilanovaContext(DbContextOptions<VilanovaContext> options) : base(options) { }
        
        
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<TipoContato> TipoContato { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaConfig());
            modelBuilder.ApplyConfiguration(new EnderecoConfig());
            modelBuilder.ApplyConfiguration(new ContatoConfig());
            modelBuilder.ApplyConfiguration(new TipoContatoConfig());
           
        }

    }
}
