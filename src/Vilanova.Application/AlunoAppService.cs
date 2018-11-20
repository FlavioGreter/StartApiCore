using Vilanova.Application.Interfaces;
using Vilanova.Domain.Entities;
using Vilanova.Domain.Interfaces.Services;

namespace Vilanova.Application
{
    public class AlunoAppService: AppService<Aluno>, IAlunoAppService
    {
        private readonly IAlunoService _alunoService;
        
        public AlunoAppService(IAlunoService alunoService): base(alunoService)
        {
            _alunoService = alunoService;
        }

    }
}
