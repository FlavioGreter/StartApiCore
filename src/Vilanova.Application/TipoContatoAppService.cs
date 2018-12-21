using System.Collections.Generic;
using Vilanova.Application.Interfaces;
using Vilanova.Domain.Entities;

namespace Vilanova.Application
{
    public class TipoContatoAppService : ITipoContatoAppService
    {
        private readonly ITipoContatoAppService _tipoContatoAppService;

        public TipoContatoAppService(ITipoContatoAppService tipoContatoAppService)
        {
            _tipoContatoAppService = tipoContatoAppService;
        }

        public ICollection<TipoContato> GetTipoContatos()
        {
            return _tipoContatoAppService.GetTipoContatos();
        }
    }
}
