﻿namespace Vilanova.ApplicationCore.Entities
{
    public abstract class Pessoa: EntityBase
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
    }
}
