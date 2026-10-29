using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EJ14 : ControllerBase
{
    [HttpPost("Porcentaje")]
        public IActionResult Porcentaje([FromBody] modelEj14 ejer14)
        {
            float resultado = (ejer14.cantidad * ejer14.porcentaje) / 100;
            return Ok($"El {ejer14.porcentaje}% de {ejer14.cantidad} es: {resultado}");
        }
}
