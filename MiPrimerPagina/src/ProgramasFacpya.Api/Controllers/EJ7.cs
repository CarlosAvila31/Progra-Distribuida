using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;


namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EJ7 : ControllerBase
{
     [HttpPost("Cuadrado")]
        public IActionResult Cuadrado([FromBody] modelEj7 ejer7)
        {
            float resultado = ejer7.numero * ejer7.numero;
            return Ok($"El cuadrado del número es: {resultado}");
        } 
}
