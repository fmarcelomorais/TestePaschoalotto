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
        var usuarios = await _usuarioService.ObterUsuarios();
        return Ok(usuarios);
    }

    [HttpGet("{filtro}")]
    public async Task<ActionResult<UsuarioDTO>> GetUser(string filtro)
    {
        var usuario = await _usuarioService.ObterUsuario(filtro);
        return Ok(usuario);
    }

    [HttpPost]
    public async Task<ActionResult> CriarUsuario(UsuarioDTO usuario) 
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        try
        {
            await _usuarioService.CadastraUsuario(usuario);       
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

}
