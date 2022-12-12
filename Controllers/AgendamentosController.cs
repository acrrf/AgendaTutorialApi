using AgendaTutorialApi.Data;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AgendamentosController : ControllerBase
{
        private readonly DataContext _context;

    public AgendamentosController(DataContext dataContext)
    {
        _context = dataContext;
    }

}