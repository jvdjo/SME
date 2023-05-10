using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SME.Models;
using SME.Repository;

namespace SME.Controllers;

[ApiController]
[Route("[controller]")]
public class FrequenciaController : ControllerBase
{
    private readonly SmeDbContext _dbContext;

    public FrequenciaController(SmeDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    [HttpPost]
    public async Task<IActionResult> Create(Frequencia frequencia)
    {
        await _dbContext.Frequencias.AddAsync(frequencia);
        var result = await _dbContext.SaveChangesAsync();
        if(result > 0)
            return Ok();
        return BadRequest();
    }
    
    [HttpGet]
    public IActionResult GetFrequencia()
    {
        return Ok("123");
    }
}