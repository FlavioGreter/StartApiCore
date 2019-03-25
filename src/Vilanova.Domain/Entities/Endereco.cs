﻿namespace Vilanova.Domain.Entities
{
    public class Endereco: EntityBase
    {
        public int PessoaId { get; set; }
        public string Bairro { get; set; }
        public string Descricao { get; set; }

        public Pessoa Pessoa { get; set; }
        
    }
}