using Vilanova.ApplicationCore.Entities;
using Vilanova.ApplicationCore.Interfaces.Repository;
using Vilanova.ApplicationCore.Interfaces.Services;

namespace Vilanova.ApplicationCore.Services
{
    public class AlunoService : Service<Aluno>, IAlunoService
    {
        
        public AlunoService(IAlunoRepository alunoRepository) : base(alunoRepository)
        {
        }
        
    }
}
