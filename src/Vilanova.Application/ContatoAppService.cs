using Vilanova.Application.Interfaces;
using Vilanova.Domain.Entities;
using Vilanova.Domain.Interfaces.Services;

namespace Vilanova.Application
{
    public class ContatoAppService : AppService<Contato>, IContatoAppService
    {
        private readonly IContatoService _contatoService;

        public ContatoAppService(IContatoService contatoService) : base(contatoService)
        {
            _contatoService = contatoService;
        }
    }
}
