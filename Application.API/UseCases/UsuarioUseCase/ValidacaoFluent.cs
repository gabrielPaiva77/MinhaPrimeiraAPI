using FluentValidation;
using MinhaPrimeiraAPI.Communication.Usuario.Requests;

namespace MinhaPrimeiraAPI.Application.UseCases.UsuarioUseCase;

public class ValidacaoFluent : AbstractValidator<RequestUsuarioJson>
{
    public ValidacaoFluent()
    {
        RuleFor(nome => nome.Nome).NotEmpty().WithMessage("O Nome não pode ser vazio");
        RuleFor(nome => nome.Nome.Length).LessThanOrEqualTo(100).WithMessage("O nome não pode ser maior que 100 caracteres ");



        RuleFor(email => email.Email).EmailAddress().WithMessage("O Email não é valido");
        RuleFor(email => email.Email).NotEmpty().WithMessage("O Email não pode ser vazio");


        RuleFor(senha => senha.Senha).NotEmpty().WithMessage("A Senha não pode ser vazia");
        RuleFor(senha => senha.Senha.Length).GreaterThan(6).WithMessage("A Senha não pode ser menor que 6 caracteres");
        RuleFor(senha => senha.Senha.Length).LessThanOrEqualTo(400).WithMessage("A Senha não pode ser maior que 400 caracteres");

    }


      
}


