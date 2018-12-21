using System.Collections.Generic;
using Vilanova.Domain.Entities;

namespace Vilanova.Domain.Interfaces.Services
{
    public interface ITipoContatoService
    {
        ICollection<TipoContato> GetTipoContatos();
    }
}
