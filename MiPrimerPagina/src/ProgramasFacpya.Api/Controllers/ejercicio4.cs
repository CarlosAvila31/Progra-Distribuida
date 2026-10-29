using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ejercicio4 : ControllerBase
{
    [HttpPost("NumMenor")]
        public IActionResult NumeroMenor([FromBody] ejer4 ejer4)
        {
            int num1 = ejer4.num1;
            int num2 = ejer4.num2;
            int num3  = ejer4.num3;

            if (num1 == num2 || num1 == num3 || num2 == num3)
            {
                return BadRequest("Los números ingresados son iguales.");
            }
            else if (num1 < num2 && num1 < num3)
            {
                return Ok($"El número menor es: {num1}");
            }
            else if (num2 < num1 && num2 < num3)
            {
                return Ok($"El número menor es: {num2}");
            }
            else if (num3 < num1 && num3 < num2)
            {
                return Ok($"El número menor es: {num3}");
            }
            
            else
            {
                return BadRequest("Los números ingresados son iguales o no son válidos.");
            }   
        }
    
}
