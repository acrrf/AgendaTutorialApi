using AgendaTutorialApi.Data;
using AgendaTutorialApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class DisponibilidadesController : ControllerBase
{
        private readonly DataContext _context;

    public DisponibilidadesController(DataContext dataContext)
    {
        _context = dataContext;
    }

        public async Task<bool> DisponibilidadeExistente(DateTime disponibilidade)
    {
        if (await _context.Disponibilidades.AnyAsync(x => x.DataDisponibilidade == disponibilidade))
        {
            return true;
        }
        return false;
    }

    [HttpPost("NovaDisponibilidade")]
    public async Task<IActionResult> NovaDisponibilidade(Disponibilidade novaDisponibilidade)
    {
        try
        {
            if(await DisponibilidadeExistente(novaDisponibilidade.DataDisponibilidade))
               throw new System.Exception("Disponibilidade já cadastrada!");

            Usuario? u = await _context.Usuarios
                .FirstOrDefaultAsync(uBusca => uBusca.Id == novaDisponibilidade.UsuarioId);
            
            if(u == null)
                throw new System.Exception("Usuário não encontrado");

            Disciplina? d = await _context.Disciplinas
                .FirstOrDefaultAsync(d => d.Id == novaDisponibilidade.DisciplinaId);

            if(d == null)
                throw new System.Exception("Disciplina não encontrada.");

            novaDisponibilidade.Usuario = u;
            novaDisponibilidade.Disciplina = d;

            await _context.Disponibilidades.AddAsync(novaDisponibilidade);
            await _context.SaveChangesAsync();

            return Ok(novaDisponibilidade);  

            

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
            List<Disponibilidade>? lista = await _context.Disponibilidades.ToListAsync();

            return Ok(lista);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

       [HttpGet("{id}")]
    
    public async Task<IActionResult> GetSingle(int id)
    {
        try
        {
            Disponibilidade? d = await _context.Disponibilidades.FirstOrDefaultAsync(dBusca => dBusca.Id == id);

            return Ok(d);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);            
        }
    }

}