using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EJ5 : ControllerBase
{
     [HttpPost("Ej5")]
    public IActionResult Promedio([FromBody] DosNumeros modelEJ4)
    {

        float num1 = modelEJ4.num1;
        float num2 = modelEJ4.num2;
       

        float multiplicacion = num1 * num2;

        return Ok($"La multiplicación de ambos numeros es: {multiplicacion}");

    }
}