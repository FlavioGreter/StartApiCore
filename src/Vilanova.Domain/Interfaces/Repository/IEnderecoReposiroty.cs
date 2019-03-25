using System.Collections.Generic;
using Vilanova.Domain.Entities;

namespace Vilanova.Domain.Interfaces.Repository
{
    public interface IEnderecoReposiroty: IRepository<Endereco>
    {
        IEnumerable<Endereco> GetAllWithInclude();
    }
}
