using System.Collections.Generic;
using System.Linq;
using Vilanova.Domain.Entities;
using Vilanova.Domain.Interfaces.Repository;
using Vilanova.Infrastructure.Data;

namespace Vilanova.Infrastructure.Repository
{
    public class TipoContatoRepository : ITipoContatoRepository
    {
        private readonly VilanovaContext _db;

        public TipoContatoRepository(VilanovaContext db)
        {
            _db = db;
        }

        public ICollection<TipoContato> GetTipoContatos()
        {
            return _db.TipoContato.ToList();
        }
    }
}
