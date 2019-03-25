using System.Collections.Generic;
using Vilanova.Domain.Entities;
using Vilanova.Domain.Interfaces.Repository;
using Vilanova.Domain.Interfaces.Services;

namespace Vilanova.Domain.Services
{
    public class PessoaService: Service<Pessoa>, IPessoaService
    {
        private IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository): base(pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public IEnumerable<Pessoa> GetAllWithInclude()
        {
            return _pessoaRepository.GetAllWithInclude();
        }
    }
}
