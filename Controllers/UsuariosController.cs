using Microsoft.AspNetCore.Mvc;
using AgendaTutorialApi.Models;
using System.Collections.Generic;
using AgendaTutorialApi.Models.Enuns;
using AgendaTutorialApi.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using AgendaTutorialApi.Utils;

[ApiController]
[Route("[controller]")]
public class UsuariosController : ControllerBase
{

    private readonly DataContext _context;

    public UsuariosController(DataContext dataContext)
    {
        _context = dataContext;
    }

        public async Task<bool> LoginExistente(string login)
    {
        if (await _context.Usuarios.AnyAsync(x => x.Login.ToLower() == login.ToLower()))
        {
            return true;
        }
        return false;
    }

    [HttpGet("{id}")]
    
    public async Task<IActionResult> GetSingle(int id)
    {
        try
        {
            Usuario? u = await _context.Usuarios.FirstOrDefaultAsync(uBusca => uBusca.Id == id);

            return Ok(u);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);            
        }
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            List<Usuario>? lista = await _context.Usuarios.ToListAsync();

            return Ok(lista);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }



    [HttpPost("Registrar")]
    public async Task<IActionResult> AddUsuario(Usuario novoUsuario)
    {
        try
        {
            if(await LoginExistente(novoUsuario.Login))
                throw new System.Exception("Login de usuário já existe");

            Criptografia.CriarPasswordHash(novoUsuario.Senha, out byte[] hash, out byte[] salt);
            novoUsuario.Senha = string.Empty;
            novoUsuario.PasswordHash = hash;
            novoUsuario.PasswordSalt = salt;

            await _context.Usuarios.AddAsync(novoUsuario);
            await _context.SaveChangesAsync();

            return Ok(novoUsuario.Id);  
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("AlterarSenha")]
    public async Task<IActionResult> Update(Usuario usuario)
    {
        try
        {
            if (!await LoginExistente(usuario.Login))
            {
                throw new System.Exception("Login de usuário não existe");
            }

            Usuario? u = await _context.Usuarios.FirstOrDefaultAsync(u => u.Login == usuario.Login);

            Criptografia.CriarPasswordHash(usuario.Senha, out byte[] hash, out byte[] salt);
            u.Senha = string.Empty;
            u.PasswordHash = hash;
            u.PasswordSalt = salt;

            _context.Usuarios.Update(u);

            int linhasAfetadas = await _context.SaveChangesAsync();

            return Ok(linhasAfetadas);

        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("GetLogin/{login}")]
    public async Task<IActionResult> GetUsuario(string login)
    {
        try
        {
            Usuario? usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Login.ToLower() == login.ToLower());

            return Ok(usuario);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("AtualizarEmail")]
    public async Task<IActionResult> AtualizarEmail(Usuario u)
    {
        try
        {
            Usuario? usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == u.Id);

            usuario.Email = u.Email;

            var attach = _context.Attach(usuario);
            attach.Property(x => x.Id).IsModified = false;
            attach.Property(x => x.Email).IsModified = true;
            int linhasAfetadas = await _context.SaveChangesAsync();
            return Ok(linhasAfetadas);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}