using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ejercicio6 : ControllerBase
{
    [HttpPost("Vocales")]
    public IActionResult VocaloNoVocal([FromBody] ejer6 letter)
    {
        string letra = letter.letra;

        if (string.IsNullOrEmpty(letra) || letra.Length != 1)
        {
            return BadRequest("Por favor, ingrese una sola letra.");
        }

        char caracter = char.ToLower(letra[0]);

        if ("aeiou".Contains(caracter))
        {
            return Ok($"La letra '{letra}' es una vocal.");
        }
        else
        {
            return Ok($"La letra '{letra}' no es una vocal.");
        }
    }
}
