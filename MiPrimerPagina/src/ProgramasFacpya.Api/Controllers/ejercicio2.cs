using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;
namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ejercicio2 : ControllerBase
{
    [HttpPost("Promedio")]
    public IActionResult Promedio([FromBody] ejer2 ejer2)
    {

        float num1 = ejer2.num1;
        float num2 = ejer2.num2;
        float num3 = ejer2.num3;
        float num4 = ejer2.num4;
        float num5 = ejer2.num5;

        float promedio = (num1 + num2 + num3 + num4 + num5) / 5;

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
