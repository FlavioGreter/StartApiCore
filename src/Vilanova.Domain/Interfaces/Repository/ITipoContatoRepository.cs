using System.Collections.Generic;
using Vilanova.Domain.Entities;

namespace Vilanova.Domain.Interfaces.Repository
{
    public interface ITipoContatoRepository
    {
        ICollection<TipoContato> GetTipoContatos();
    }
}
