using ProductClientHub.Communication.Requests;
using ProductClientHub.Communication.Responses;
using ProductClientHub.Exceptions.ExceptionsBase;
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
                var errors = result.Errors.Select(failure => failure.ErrorMessage).ToList();

                throw new ErrorOnvValidationException(errors);
            }

            return new ResponseClientJSON();
        }
    }
}
