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

            // Verificando se a validação falhou.
            if (result.IsValid == false)
            {
                throw new ArgumentException("Error on requests");
            }

            return new ResponseClientJSON();
        }
    }
}
