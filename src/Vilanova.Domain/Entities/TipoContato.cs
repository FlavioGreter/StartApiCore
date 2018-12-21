using System.Collections.Generic;

namespace Vilanova.Domain.Entities
{
    public class TipoContato: EntityBase
    {
        public string Descricao { get; set; }

        public virtual ICollection<Contato> Contato { get; set; }
    }
}