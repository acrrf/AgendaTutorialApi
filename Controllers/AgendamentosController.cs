using AgendaTutorialApi.Data;
using AgendaTutorialApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class AgendamentosController : ControllerBase
{
        private readonly DataContext _context;

    public AgendamentosController(DataContext dataContext)
    {
        _context = dataContext;
    }

        public async Task<bool> AgendamentoExistente(DateTime agendamento)
    {
        if (await _context.Agendamentos.AnyAsync(x => x.DataAgendamento == agendamento))
        {
            return true;
        }
        return false;
    }

    [HttpPost("NovoAgendamento")]
    public async Task<IActionResult> NovoAgendamento(Agendamento novoAgendamento)
    {
        try
        {
            if(await AgendamentoExistente(novoAgendamento.DataAgendamento))
               throw new System.Exception("Agendamento já cadastrado!");

            Usuario? u = await _context.Usuarios
              .FirstOrDefaultAsync(uBusca => uBusca.Id == novoAgendamento.UsuarioId);
            
            if(u == null)
                throw new System.Exception("Usuário não encontrado");

            Disciplina? d = await _context.Disciplinas
                .FirstOrDefaultAsync(d => d.Id == novoAgendamento.DisciplinaId);

            if(d == null)
                throw new System.Exception("Disciplina não encontrada.");

            novoAgendamento.Usuario = u;
            novoAgendamento.Disciplina = d;

            await _context.Agendamentos.AddAsync(novoAgendamento);
            await _context.SaveChangesAsync();

            return Ok(novoAgendamento);  
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
            List<Agendamento>? lista = await _context.Agendamentos.ToListAsync();

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
            Agendamento? a = await _context.Agendamentos.FirstOrDefaultAsync(aBusca => aBusca.Id == id);

            return Ok(a);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);            
        }
    }

}

