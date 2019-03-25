using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Endereco> GetAllWithInclude()
        {
            var retorno = _db.Enderecos.Include(p => p.Pessoa).Include(c => c.Pessoa.Contatos).ToList();

            return retorno;
        }
    }
}
