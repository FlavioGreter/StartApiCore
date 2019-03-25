using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Vilanova.Application.Interfaces;
using Vilanova.Domain.Entities;

namespace Vilanova.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoAppService _enderecoAppService;

        public EnderecoController(IEnderecoAppService enderecoAppService)
        {
            _enderecoAppService = enderecoAppService;
        }


        // GET: api/Endereco
        [HttpGet]
        public IEnumerable<Endereco> Get()
        {
            try
            {

                return _enderecoAppService.GetAllWithInclude();
            }
            catch (Exception ex)
            {
                throw ex;
            }
       
        }

        // GET: api/Endereco/5
        [HttpGet("{id}")]
        public Endereco Get(int id)
        {
            return _enderecoAppService.GetById(id);
        }

        // POST: api/Endereco
        [HttpPost]
        public void CadastrarEndereco([FromBody] Endereco endereco)
        {
            _enderecoAppService.Add(endereco);
        }

        // PUT: api/Endereco/5
        [HttpPut("{id}")]
        public void AlterarEndereco(int id, [FromBody] Endereco endereco)
        {
            _enderecoAppService.Update(endereco);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeletarEndereco(int id)
        {
            _enderecoAppService.DeleteById(id);
        }
    }
}
