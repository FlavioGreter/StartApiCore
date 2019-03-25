using System.Collections.Generic;
using Vilanova.Domain.Entities;
using Vilanova.Domain.Interfaces.Repository;
using Vilanova.Domain.Interfaces.Services;

namespace Vilanova.Domain.Services
{
    public class EnderecoService : Service<Endereco>, IEnderecoService
    {
        private IEnderecoReposiroty _enderecoRepository;

        public EnderecoService(IEnderecoReposiroty repository) : base(repository)
        {
             _enderecoRepository = repository;
        }

        public IEnumerable<Endereco> GetAllWithInclude()
        {
            return _enderecoRepository.GetAllWithInclude();
        }
    }
}
