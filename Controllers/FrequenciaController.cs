using Microsoft.AspNetCore.Mvc;

namespace SME.Controllers;

[ApiController]
[Route("[controller]")]
public class FrequenciaController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("gay");
    }
    
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("gay");
    }
}