using AgendaTutorialApi.Data;
using AgendaTutorialApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class DisciplinasController : ControllerBase
{
        private readonly DataContext _context;

    public DisciplinasController(DataContext dataContext)
    {
        _context = dataContext;
    }

    public async Task<bool> DisciplinaExistente(string disciplina)
    {
        if (await _context.Disciplinas.AnyAsync(x => x.Nome.ToLower() == disciplina.ToLower()))
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
            Disciplina? d = await _context.Disciplinas.FirstOrDefaultAsync(dBusca => dBusca.Id == id);

            return Ok(d);
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
            List<Disciplina>? lista = await _context.Disciplinas.ToListAsync();

            return Ok(lista);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("AddDisciplina")]
    public async Task<IActionResult> AddDisciplina(Disciplina novaDisciplina)
    {
        try
        {
            if(await DisciplinaExistente(novaDisciplina.Nome))
               throw new System.Exception("Disciplina já cadastrada!");

            await _context.Disciplinas.AddAsync(novaDisciplina);
            await _context.SaveChangesAsync();

            return Ok(novaDisciplina.Id);  
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("AlterarDisciplina")]
    public async Task<IActionResult> AtualizarDisciplina(Disciplina disciplina)
    {
        try
        {
            if (!await DisciplinaExistente(disciplina.Nome))
            {
                throw new System.Exception("Disciplina não existente!");
            }

            Disciplina? d = await _context.Disciplinas.FirstOrDefaultAsync(x => x.Nome == disciplina.Nome);

            d.Nome = disciplina.Nome;
            d.Descricao = disciplina.Descricao;


            int linhasAfetadas = await _context.SaveChangesAsync();
            return Ok(linhasAfetadas);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

}