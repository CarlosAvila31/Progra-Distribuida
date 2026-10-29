using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EJ12 : ControllerBase
{
    [HttpPost("AreaRectangulo")]
        public IActionResult AreaRectangulo([FromBody] modelEj12 ejer12)
        {
            float area = ejer12.baseRect * ejer12.altura;
            return Ok($"El área del rectángulo es: {area}");
        }
}
