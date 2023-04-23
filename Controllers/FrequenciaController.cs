using Microsoft.AspNetCore.Mvc;

namespace SME.Controllers;

[ApiController]
[Route("[controller]")]
public class FrequenciaController : ControllerBase
{
    [HttpPost]
    public IActionResult Update()
    {
        return Ok();
    }
    
    [HttpGet]
    public IActionResult GetFrequencia()
    {
        return Ok("123");
    }
}