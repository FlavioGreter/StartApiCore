using System;
using System.Collections.Generic;

namespace Vilanova.Domain.Entities
{
    public class Pessoa: EntityBase
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual ICollection<Endereco> Endereco { get; set; }
        public virtual ICollection<Contato> Contato { get; set; }

        public Pessoa()
        {
            this.Endereco = new HashSet<Endereco>();
            this.Contato = new HashSet<Contato>();
            this.DataCadastro = DateTime.Now;
        }
    }
}
