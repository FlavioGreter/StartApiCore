using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Vilanova.ApplicationCore.Entities;
using Vilanova.ApplicationCore.Interfaces.Repository;

namespace Vilanova.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunosController(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        // GET: Alunoes
        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return _alunoRepository.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Aluno Get(int id)
        {
            return _alunoRepository.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Aluno aluno)
        {
            _alunoRepository.Add(aluno);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Aluno aluno)
        {
            _alunoRepository.Update(aluno);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _alunoRepository.DeleteById(id);
        }
    }
}
