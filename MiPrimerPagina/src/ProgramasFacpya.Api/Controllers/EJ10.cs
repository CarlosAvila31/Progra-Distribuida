using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EJ10 : ControllerBase
{
    [HttpPost("AreaCirculo")]
        public IActionResult AreaCirculo([FromBody] modelEj10 ejer10)
        {
            float area = (float)(Math.PI * Math.Pow(ejer10.radio, 2));
            return Ok($"El área del círculo es: {area}");
        }
}
