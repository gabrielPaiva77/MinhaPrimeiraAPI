using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.API.Controllers.ControllerPadrao;
using MinhaPrimeiraAPI.Application.UseCases.UsuarioUseCase;
using MinhaPrimeiraAPI.Communication.Usuario.Requests;
using MinhaPrimeiraAPI.Communication.Usuario.Responses;

namespace MinhaPrimeiraAPI.API.Controllers;

public class UsuarioController : PadraoController
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseUsuarioJson), StatusCodes.Status201Created)]
    public IActionResult Registrar(RequestUsuarioJson request)
    {
        ValidacaoUsuario validacao = new();
        var resultado = validacao.Executar(request);



        return Created(string.Empty,resultado);
    }

}

