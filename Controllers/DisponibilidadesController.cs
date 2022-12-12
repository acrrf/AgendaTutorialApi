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

            await _context.Disponibilidades.AddAsync(novaDisponibilidade);
            await _context.SaveChangesAsync();

            return Ok(novaDisponibilidade);  
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

}