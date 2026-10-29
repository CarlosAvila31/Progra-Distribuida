using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ejercicio3 : ControllerBase

{
    [HttpPost("NumMayor")]
    public IActionResult NumeroMayor([FromBody] ejer3 ejer3)
    {
        float num1 = ejer3.numero1;
        float num2 = ejer3.numero2;
        float num3  = ejer3.numero3;

        if (num1 == num2 || num1 == num3 || num2 == num3)
        {
            return BadRequest("Los números ingresados son iguales.");
        }
        else if (num1 > num2 && num1 > num3)
        {
            return Ok($"El número mayor es: {num1}");
        }
        else if (num2 > num1 && num2 > num3)
        {
            return Ok($"El número mayor es: {num2}");
        }
        else if (num3 > num1 && num3 > num2)
        {
            return Ok($"El número mayor es: {num3}");
        }
        
        else
        {
            return BadRequest("Los números ingresados son iguales o no son válidos.");
        }   
    }
}
