using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EJ6 : ControllerBase
{
    
    [HttpPost("Promedio")]
    public IActionResult Promedio([FromBody] modelEj6 ejer6)
    {

        float num1 = ejer6.num1;
        float num2 = ejer6.num2;
        float num3 = ejer6.num3;

        float promedio = (num1 + num2 + num3 ) / 3;

        if (promedio < 60)
        {
            return Ok($"El estudiante ha reprobado con un promedio de: {promedio}");
        }
        else if (promedio >= 60 && promedio < 100)
        {
            return Ok($"El estudiante ha aprobado con un promedio de: {promedio}");
        }
        else
        {
            return Ok($"El promedio ingresado no es válido: {promedio}");
        }
    }

}
