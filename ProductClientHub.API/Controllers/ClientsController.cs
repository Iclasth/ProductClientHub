using Microsoft.AspNetCore.Mvc;
using ProductClientHub.Communication.Requests;
using ProductClientHub.Communication.Responses;
using ProductClientHub.API.UseCases.Clients.Register;
using ProductClientHub.Exceptions.ExceptionsBase;

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
        // Retorna o status code 201 (Created) quando a criação for bem sucedida
        [ProducesResponseType(typeof(ResponseClientJSON), StatusCodes.Status201Created)]
        // Retorna o status code 400 (Bad Request) quando houver erro na requisição
        [ProducesResponseType(typeof(ResponseClientJSON), StatusCodes.Status400BadRequest)]

        public IActionResult Register([FromBody] RequestClientJSON request)
        {
            try
            {
                var useCase = new RegisterClientUseCase();

                var response = useCase.Execute(request);

                return Created(string.Empty, response);
            }
            catch (ProductClientHubException ex)
            {
               var errors = ex.GetErrors();
                return BadRequest(new ResponseErrorMessagesJSON(errors));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResponseErrorMessagesJSON("Unknow error"));
            }

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
