using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EJ8 : ControllerBase
{
     [HttpPost("AreaCuadrado")]
        public IActionResult AreaCuadrado([FromBody] modelEj8 ejer8)
        {
            float area = ejer8.lado * ejer8.lado;
            return Ok($"El área del cuadrado es: {area}");
        }
}
