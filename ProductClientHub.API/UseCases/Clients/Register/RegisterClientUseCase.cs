using ProductClientHub.API.Entities;
using ProductClientHub.API.Infraestructure;
using ProductClientHub.Communication.Requests;
using ProductClientHub.Communication.Responses;
using ProductClientHub.Exceptions.ExceptionsBase;
namespace ProductClientHub.API.UseCases.Clients.Register
{
    public class RegisterClientUseCase
    {
        public ResponseClientJSON Execute(RequestClientJSON request)
        {
            Validate(request);
            // Criando uma instância da classe Validadora.

            var dbContext = new ProductClientHubDbContext();

            var entity = new Client
            {
                
                Name = request.Name,
                Email = request.Email
            };

            dbContext.Clients.Add(entity);

            dbContext.SaveChanges();


            return new ResponseClientJSON();
        }

        private void Validate(RequestClientJSON request)
        {
            var validator = new RegisterClientValidator();

            var result = validator.Validate(request);

            // Verificando se a validação falhou.
            if (result.IsValid == false)
            {
                var errors = result.Errors.Select(failure => failure.ErrorMessage).ToList();

                throw new ErrorOnvValidationException(errors);
            }
        }
    }
}
