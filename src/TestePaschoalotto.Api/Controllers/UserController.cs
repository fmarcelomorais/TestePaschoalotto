using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using TestePaschoalotto.Api.Service;
using TestePaschoalotto.Application.DTOs;
using TestePaschoalotto.Application.Interface;

namespace TestePaschoalotto.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUsuarioService _usuarioService;
   
    public UserController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
        
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        //var usuarios = await _usuarioService()
        return Ok();
    }

    [HttpGet("criar-usuario")]
    public async Task<ActionResult> CriarUsuario() 
    {       
        var usuarioNovo = await RandomUserService.NovoUsuario(new HttpClient(), "https://randomuser.me/api/");
        
        return Ok(usuarioNovo);
    }

}
