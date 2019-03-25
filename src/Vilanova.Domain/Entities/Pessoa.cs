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

        public  ICollection<Endereco> Enderecos { get; set; }
        public  ICollection<Contato> Contatos { get; set; }

        public Pessoa()
        {
            this.Enderecos = new HashSet<Endereco>();
            this.Contatos = new HashSet<Contato>();
            this.DataCadastro = DateTime.Now;
        }
    }
}
