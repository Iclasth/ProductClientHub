using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.UseCases.Clients.Register
{

    public class RegisterClientValidator : AbstractValidator<RequestClientJSON>
    {
        // Definindo as regras de validação para o RequestClientJSON 
        // Utilizando a biblioteca FluentValidation
        public RegisterClientValidator()
        {
            RuleFor(client => client.Name)
                .NotEmpty().WithMessage("O nome do cliente é obrigatório.")
                .MaximumLength(100).WithMessage("O nome do cliente não pode exceder 100 caracteres.");

            RuleFor(client => client.Email)
                .NotEmpty().WithMessage("O email do cliente é obrigatório.")
                .EmailAddress().WithMessage("O email do cliente deve ser um endereço de email válido.")
                .MaximumLength(100).WithMessage("O email do cliente não pode exceder 100 caracteres.");
        }
    }
}
