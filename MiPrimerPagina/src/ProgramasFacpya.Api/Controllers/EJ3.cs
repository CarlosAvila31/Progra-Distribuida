using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EJ3 : ControllerBase
{
     [HttpPost("Ej3")]
    public IActionResult Promedio([FromBody] DosNumeros modelEJ3)
    {

        float num1 = modelEJ3.num1;
        float num2 = modelEJ3.num2;
       

        float suma = num1 + num2;

        return Ok($"La suma de ambos numeros es: {suma}");

    }
}
