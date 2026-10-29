using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EJ9 : ControllerBase
{
    [HttpPost("PerimetroCuadrado")]
        public IActionResult PerimetroCuadrado([FromBody] modelEj9 ejer9)
        {
            float perimetro = ejer9.lado * 4;
            return Ok($"El perímetro del cuadrado es: {perimetro}");
        }
}
