using System.Collections.Generic;
using Vilanova.Domain.Entities;

namespace Vilanova.Domain.Interfaces.Services
{
    public interface IPessoaService: IService<Pessoa>
    {
        IEnumerable<Pessoa> GetAllWithInclude();
    }
}
