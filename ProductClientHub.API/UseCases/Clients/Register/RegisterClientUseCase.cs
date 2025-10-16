using ProductClientHub.Communication.Requests;
using ProductClientHub.Communication.Responses;
namespace ProductClientHub.API.UseCases.Clients.Register
{
    public class RegisterClientUseCase
    {
        public ResponseClientJSON Execute(RequestClientJSON request)
        {
            // Criando uma instância da classe Validadora.
            var validator = new RegisterClientValidator();

            var result = validator.Validate(request);

            return new ResponseClientJSON();
        }
    }
}
