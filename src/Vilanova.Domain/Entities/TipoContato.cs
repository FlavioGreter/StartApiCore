using System.Collections.Generic;

namespace Vilanova.Domain.Entities
{
    public class TipoContato: EntityBase
    {
        public string Descricao { get; set; }

        public ICollection<Contato> Contatos { get; set; }

        public TipoContato()
        {
           this.Contatos = new HashSet<Contato>();
        }
    }
}