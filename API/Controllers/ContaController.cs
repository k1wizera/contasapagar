using Microsoft.AspNetCore.Mvc;
using Core.Interface;
using Core.Entities;

namespace API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private readonly IConta _conta;
        public ContaController( IConta conta)
        {
            _conta = conta;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Conta>>> Get()
        {
            return Ok(await _conta.GetContas());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Conta>> GetById(int id)
        {
            var conta = await _conta.GetContasById(id);
            if(conta == null)
            {
                return NotFound();

            }
            return conta;
        }

        [HttpPost]
        public async Task<ActionResult<Conta>> Create (Conta conta)
        {
            return Ok(await _conta.CreateContas(conta));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Conta conta)
        {
            if (id != conta.Id)
            {
                return BadRequest();
            }
            await _conta.UpdateContas(conta);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Conta>> Delete(int id)
        {
            var conta = await _conta.DeleteContas(id);
            if (conta == null)
            {
                return NotFound();
            }
            return conta;
        }
    }
}
