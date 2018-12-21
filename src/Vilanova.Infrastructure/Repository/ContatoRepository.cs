using Vilanova.Domain.Entities;
using Vilanova.Domain.Interfaces.Repository;
using Vilanova.Infrastructure.Data;

namespace Vilanova.Infrastructure.Repository
{
    public class ContatoRepository : Repository<Contato>, IContatoRepository
    {
        public ContatoRepository(VilanovaContext db) : base(db)
        {
        }
    }
}
