using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPI.Controllers
{
    [ApiController]
    [Route("Api/Demo")]
    public class TesteController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status200OK)] //Formatadores de resposta*
        public IActionResult Get()
        {
            return Ok(new Produto { Id = 1, Nome ="Teste"});
        }


        [HttpGet("{Id:int}")]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status200OK)] 
        [ProducesResponseType(StatusCodes.Status404NotFound)] 
        public IActionResult Get(int id)
        {
            return Ok(new Produto { Id = 1, Nome = "Teste"});
        }


        [HttpPost]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post(Produto produto)
        {
            return CreatedAtAction("Get", new {id = produto.Id}, produto);
        }


        [HttpPut("{Id:int}")]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult Put(int id, Produto produto)
        {
            if (id != produto.Id) return BadRequest();
            return NoContent();
        }


        [HttpDelete("{Id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete(int id)
        {
            //if (id != produto.Id) return BadRequest();
            return NoContent();
        }
    }
}
