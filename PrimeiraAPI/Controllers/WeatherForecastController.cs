using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPI.Controllers
{
    [ApiController] //Marcação
    [Route("api/minha-controller")] //Rota
    public class WeatherForecastController : ControllerBase 
    {
        [HttpGet]
        public IActionResult Get() 
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Get3()
        {
            return Ok();
        }

        [HttpGet("{id:int}/dado/{id2:int}")] //documentação para melhor entendimento https://learn.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-8.0
        public IActionResult Get(int id,int id2)
        {
            return Ok();
        }


    }
}
