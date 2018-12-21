namespace Vilanova.Domain.Entities
{
    public class Endereco: EntityBase
    {
        public int PessoaId { get; set; }
        public int Bairro { get; set; }
        public string Descricao { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        
    }
}