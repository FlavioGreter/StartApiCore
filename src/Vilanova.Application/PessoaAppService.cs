using System.Collections.Generic;
using Vilanova.Application.Interfaces;
using Vilanova.Domain.Entities;
using Vilanova.Domain.Interfaces.Services;

namespace Vilanova.Application
{
    public class PessoaAppService : AppService<Pessoa>, IPessoaAppService
    {
        private readonly IPessoaService _pessoaService;

        public PessoaAppService(IPessoaService pessoaService) : base(pessoaService)
        {
            _pessoaService = pessoaService;
        }

        public IEnumerable<Pessoa> GetAllWithInclude()
        {
            return _pessoaService.GetAllWithInclude();
        }
    }
}
