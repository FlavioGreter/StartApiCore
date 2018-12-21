using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Vilanova.Application.Interfaces;
using Vilanova.Domain.Entities;

namespace Vilanova.WebApi.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class AlunosController : ControllerBase
    //{
    //    private readonly IAlunoAppService _alunoAppService;

    //    public AlunosController(IAlunoAppService alunoAppService)
    //    {
    //        _alunoAppService = alunoAppService;
    //    }

    //    // GET: Alunoes
    //    [HttpGet]
    //    public IEnumerable<Aluno> Get()
    //    {
    //        return _alunoAppService.GetAll();
    //    }

    //    // GET api/Alunos/5
    //    [HttpGet("{id}")]
    //    public Aluno Get(int id)
    //    {
    //        return _alunoAppService.GetById(id);
    //    }

    //    // POST api/Alunos
    //    [HttpPost]
    //    public void Post([FromBody] Aluno aluno)
    //    {


    //        _alunoAppService.Add(aluno);
         
    //    }

    //    // PUT api/Alunos/5
    //    [HttpPut("{id}")]
    //    public void Put(int id, [FromBody] Aluno aluno)
    //    {
    //        _alunoAppService.Update(aluno);
    //    }

    //    // DELETE api/values/5
    //    [HttpDelete("{id}")]
    //    public void Delete(int id)
    //    {
    //        _alunoAppService.DeleteById(id);
    //    }
    //}
}
