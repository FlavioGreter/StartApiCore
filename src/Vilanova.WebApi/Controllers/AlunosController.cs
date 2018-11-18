using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Vilanova.ApplicationCore.Entities;
using Vilanova.ApplicationCore.Interfaces.Repository;
using Vilanova.ApplicationCore.Interfaces.Services;

namespace Vilanova.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunosController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        // GET: Alunoes
        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return _alunoService.GetAll();
        }

        // GET api/Alunos/5
        [HttpGet("{id}")]
        public Aluno Get(int id)
        {
            return _alunoService.GetById(id);
        }

        // POST api/Alunos
        [HttpPost]
        public void Post([FromBody] Aluno aluno)
        {

     
            _alunoService.Add(aluno);
         
        }

        // PUT api/Alunos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Aluno aluno)
        {
            _alunoService.Update(aluno);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _alunoService.DeleteById(id);
        }
    }
}
