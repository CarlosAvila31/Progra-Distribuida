using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EJ11 : ControllerBase
{
    [HttpPost("PerimetroCirculo")]
        public IActionResult PerimetroCirculo([FromBody] modelEj11 ejer11)
        {
            float perimetro = (float)(2 * Math.PI * ejer11.radio);
            return Ok($"El perímetro del círculo es: {perimetro}");
        }
}
