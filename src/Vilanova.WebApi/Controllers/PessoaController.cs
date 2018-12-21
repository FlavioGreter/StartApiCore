using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vilanova.Application.Interfaces;
using Vilanova.Domain.Entities;

namespace Vilanova.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaAppService _pessoaAppService;

        public PessoaController(IPessoaAppService pessoaAppService)
        {
            _pessoaAppService = pessoaAppService;
        }

        // GET: api/Pessoa
        [HttpGet]
        public IEnumerable<Pessoa> Get()
        {
            return _pessoaAppService.GetAll(); 
        }

        // GET: api/Pessoa/5
        [HttpGet("{id}", Name = "Get")]
        public Pessoa Get(int id)
        {
            return _pessoaAppService.GetById(id);
        }

        // POST: api/Pessoa
        [HttpPost]
        public void Post([FromBody] Pessoa pessoa)
        {
            _pessoaAppService.Add(pessoa);
        }

        // PUT: api/Pessoa/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pessoa pessoa)
        {
            _pessoaAppService.Update(pessoa);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _pessoaAppService.DeleteById(id);
        }
    }
}
