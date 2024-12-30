using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPI.Controllers
{
    [ApiController]
    [Route("Api/Demo")]
    public class TesteController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status200OK)] 
        public IActionResult Get()
        {
            return Ok(new Produto { Id = 1, Nome ="Teste"});
        }


        [HttpGet("{Id:int}")]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            return Ok(new Produto { Id = 1, Nome = "Teste"});
        }


        [HttpPost]
        public IActionResult Post(Produto produto)
        {
            return CreatedAtAction("Get", new {id = produto.Id}, produto);
        }


        [HttpPut("{Id:int}")]
        public IActionResult Put(int id, Produto produto)
        {
            if (id != produto.Id) return BadRequest();
            return NoContent();
        }

        [HttpDelete("{Id:int}")]
        public IActionResult Delete(int id)
        {
            //if (id != produto.Id) return BadRequest();
            return NoContent();
        }
    }
}
