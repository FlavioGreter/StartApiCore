using System.Collections.Generic;
using Vilanova.Domain.Entities;

namespace Vilanova.Application.Interfaces
{
    public interface ITipoContatoAppService
    {
        ICollection<TipoContato> GetTipoContatos();
    }
}
