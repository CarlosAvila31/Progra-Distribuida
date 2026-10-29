using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ejercicio5 : ControllerBase
{
    [HttpPost("NumeroParImpar")]
    public IActionResult NumParImpar([FromBody] ejer5 datos)
    {
        int num = datos.Numero;

        if (num % 2 == 0)
        {
            return Ok($"El número {num} es par.");
        }
        else
        {
            return Ok($"El número {num} es impar.");
        }
    }
}


