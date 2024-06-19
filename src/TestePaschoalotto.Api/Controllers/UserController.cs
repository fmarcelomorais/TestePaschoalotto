using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;
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

    [HttpPost("criar-usuario")]
    public async Task<ActionResult> CriarUsuario(UsuarioDTOCreate usuario) 
    {
               
        return Ok();
    }

}
