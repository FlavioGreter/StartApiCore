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
        [ProducesResponseType(typeof(Pessoa), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IEnumerable<Pessoa> Get()
        {
            try
            {
                return _pessoaAppService.GetAllWithInclude();
                        
            }
            catch (Exception ex)
            {
                throw ex;
            }       
        }

        // GET: api/Pessoa/5
        [HttpGet("{id}", Name = "Get")]
        public Pessoa Get(int id)
        {
            try
            {
                var retorno = _pessoaAppService.GetById(id);
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }

           
        }

        // POST: api/Pessoa
        [HttpPost]
        public void Post([FromBody] Pessoa pessoa)
        {
            try
            {
                _pessoaAppService.Add(pessoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }

           
        }

        // PUT: api/Pessoa/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pessoa pessoa)
        {
            try
            {
                _pessoaAppService.Update(pessoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                _pessoaAppService.DeleteById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }
    }
}
