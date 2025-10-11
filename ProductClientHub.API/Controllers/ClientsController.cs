using Microsoft.AspNetCore.Mvc;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.Controllers
{
    // Informando que é um controller de API
    // Definindo como a url deve ser construída
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        // Definindo que o método responde a requisições POST (CREATE)
        [HttpPost]
        public IActionResult Register([FromBody] RequestClientJSON request)
        {
            return Ok();
        }

        // Definindo que o método responde a requisições PUT (UPDATE)
        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }

        // Definindo que o método responde a requisições GET de forma geral (READ)
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        // Definindo que o método responde a requisições GET com um parâmetro (READ)
        [HttpGet]
        // informa que o parâmetro da rota é "id"
        // Responsável por diferenciar os métodos GET
        [Route("{id}")]
        public IActionResult GetById([FromRoute]Guid id)
        {
            return Ok(); 
        }

        //  Definindo que o método responde a requisições DELETE (DELETE)
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}
