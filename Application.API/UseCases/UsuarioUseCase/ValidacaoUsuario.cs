using MinhaPrimeiraAPI.Communication.Usuario.Requests;
using MinhaPrimeiraAPI.Communication.Usuario.Responses;
using System.ComponentModel.DataAnnotations;

namespace MinhaPrimeiraAPI.Application.UseCases.UsuarioUseCase;

public class ValidacaoUsuario
{
    public ResponseUsuarioJson Executar(RequestUsuarioJson request)
    {
        Validar(request);




        return new ResponseUsuarioJson()
        {
            Nome = request.Nome
        };
    }


    private void Validar(RequestUsuarioJson request)
    {
        ValidacaoFluent validationRules = new();
        var resultado = validationRules.Validate(request);

        if (resultado.IsValid == false)
        {
            
            throw new ValidationException(resultado.Errors.ToString());
        }
        
        
        
        
        

    }



}


