using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ejercicio1 : ControllerBase
{
    [HttpPost("Numero")]
    public IActionResult numero([FromBody] ejer1 ejer1)
    {
        int num = ejer1.Numero;

        if (num < 0)
        {
            return Ok($"El número ingresado es menor que cero: {num}");
        }

        else if (num == 0)
        {
            return Ok($"El número ingresado es cero: {num}");
        }

        else if (num > 0)
        {
            return Ok($"El número ingresado es mayor a cero: {num}");
        }
        else
        {
            return Ok("El número ingresado no es válido.");
        }

    }
}
