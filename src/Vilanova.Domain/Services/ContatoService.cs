using Vilanova.Domain.Entities;
using Vilanova.Domain.Interfaces.Repository;
using Vilanova.Domain.Interfaces.Services;

namespace Vilanova.Domain.Services
{
    public class ContatoService : Service<Contato>, IContatoService
    {
        public ContatoService(IContatoRepository repository) : base(repository)
        {
        }
    }
}
