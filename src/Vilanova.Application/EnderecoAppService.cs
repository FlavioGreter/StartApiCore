using System.Collections.Generic;
using Vilanova.Application.Interfaces;
using Vilanova.Domain.Entities;
using Vilanova.Domain.Interfaces.Services;

namespace Vilanova.Application
{
    public class EnderecoAppService: AppService<Endereco>, IEnderecoAppService
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoAppService(IEnderecoService enderecoService) : base(enderecoService)
        {
            _enderecoService = enderecoService;
        }

        public IEnumerable<Endereco> GetAllWithInclude()
        {
            return _enderecoService.GetAllWithInclude();
        }
    }
}
