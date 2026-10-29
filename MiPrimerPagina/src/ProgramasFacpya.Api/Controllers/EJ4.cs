using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EJ4 : ControllerBase
{
     [HttpPost("Ej4")]
    public IActionResult Promedio([FromBody] DosNumeros modelEJ4)
    {

        float num1 = modelEJ4.num1;
        float num2 = modelEJ4.num2;
       

        float resta = num1 - num2;

        return Ok($"La resta de ambos numeros es: {resta}");

    }
}