using Vilanova.Domain.Entities;
using Vilanova.Domain.Interfaces.Repository;
using Vilanova.Infrastructure.Data;

namespace Vilanova.Infrastructure.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoReposiroty
    {
        public EnderecoRepository(VilanovaContext db) : base(db)
        {
        }
    }
}
