namespace Vilanova.Domain.Entities
{
    public class Contato: EntityBase
    {
        public int PessoaId { get; set; }
        public int TipoContatoId { get; set; }
        public string Descricao { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual TipoContato TipoContato { get; set; }
    }
}