using System.Collections.Generic;
using Vilanova.Domain.Entities;
using Vilanova.Domain.Interfaces.Repository;
using Vilanova.Domain.Interfaces.Services;

namespace Vilanova.Domain.Services
{
    public class TipoContatoService : ITipoContatoService
    {
        private readonly ITipoContatoRepository _tipoContatoRepository;

        public TipoContatoService(ITipoContatoRepository tipoContatoRepository )
        {

            _tipoContatoRepository = tipoContatoRepository;

        }

        public ICollection<TipoContato> GetTipoContatos()
        {

            return _tipoContatoRepository.GetTipoContatos();

        }
    }
}
