using Vilanova.Domain.Entities;
using Vilanova.Domain.Interfaces.Repository;
using Vilanova.Infrastructure.Data;

namespace Vilanova.Infrastructure.Repository
{
    public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {
        
        public AlunoRepository(VilanovaContext db) : base(db)
        {
        }

        //Implementação de métodos Específicos do repostório de alunos.
    }
}
