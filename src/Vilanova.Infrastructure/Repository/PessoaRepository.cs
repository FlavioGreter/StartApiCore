using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Vilanova.Domain.Entities;
using Vilanova.Domain.Interfaces.Repository;
using Vilanova.Infrastructure.Data;

namespace Vilanova.Infrastructure.Repository
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(VilanovaContext db) : base(db)
        {
        }

        public IEnumerable<Pessoa> GetAllWithInclude()
        {
            var retorno = _db.Pessoas.Include(e => e.Enderecos).Include(c => c.Contatos);

            return retorno;
        }
    }
}
