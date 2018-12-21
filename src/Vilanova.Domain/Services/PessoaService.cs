using Vilanova.Domain.Entities;
using Vilanova.Domain.Interfaces.Repository;
using Vilanova.Domain.Interfaces.Services;

namespace Vilanova.Domain.Services
{
    public class PessoaService: Service<Pessoa>, IPessoaService
    {
        public PessoaService(IPessoaRepository pessoaRepository): base(pessoaRepository)
        {

        }
    }
}
