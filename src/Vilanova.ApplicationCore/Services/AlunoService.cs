using Vilanova.Domain.Entities;
using Vilanova.Domain.Interfaces.Repository;
using Vilanova.Domain.Interfaces.Services;

namespace Vilanova.Domain.Services
{
    public class AlunoService : Service<Aluno>, IAlunoService
    {
        
        public AlunoService(IAlunoRepository alunoRepository) : base(alunoRepository)
        {
        }
        
    }
}
