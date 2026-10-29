using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EJ13 : ControllerBase
{
    [HttpPost("AreaTriangulo")]
        public IActionResult AreaTriangulo([FromBody] modelEj13 ejer13)
        {
            float area = (ejer13.baseTri * ejer13.altura) / 2;
            return Ok($"El área del triángulo es: {area}");
        }
}
