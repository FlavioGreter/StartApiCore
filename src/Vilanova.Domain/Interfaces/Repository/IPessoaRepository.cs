using System.Collections.Generic;
using Vilanova.Domain.Entities;

namespace Vilanova.Domain.Interfaces.Repository
{
    public interface IPessoaRepository: IRepository<Pessoa>
    {
        IEnumerable<Pessoa> GetAllWithInclude();
    }
}
