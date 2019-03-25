using System.Collections.Generic;
using Vilanova.Domain.Entities;

namespace Vilanova.Application.Interfaces
{
    public interface IPessoaAppService:IAppService<Pessoa>
    {
        IEnumerable<Pessoa> GetAllWithInclude();
    }
}
