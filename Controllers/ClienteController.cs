using Microsoft.AspNetCore.Mvc;

namespace ApiComSwagger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            return "Minha primeira API com Swagger";
        }
    }
}