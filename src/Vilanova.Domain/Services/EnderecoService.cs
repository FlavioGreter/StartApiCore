using Vilanova.Domain.Entities;
using Vilanova.Domain.Interfaces.Repository;
using Vilanova.Domain.Interfaces.Services;

namespace Vilanova.Domain.Services
{
    public class EnderecoService : Service<Endereco>, IEnderecoService
    {
        public EnderecoService(IEnderecoReposiroty repository) : base(repository)
        {
        }
    }
}
