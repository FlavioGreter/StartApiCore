using System.Collections.Generic;
using Vilanova.Domain.Entities;

namespace Vilanova.Application.Interfaces
{
    public interface IEnderecoAppService: IAppService<Endereco>
    {
        IEnumerable<Endereco> GetAllWithInclude();
    }
}
