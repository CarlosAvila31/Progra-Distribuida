using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EJ16 : ControllerBase
{
    [HttpPost("DolaresAEuros")]
        public IActionResult DolaresAEuros([FromBody] modelEj16 ejer16)
        {
            const float tipoCambio = 0.92f; // 1 USD = 0.92 EUR
            float resultado = ejer16.dolares * tipoCambio;
            return Ok($"{ejer16.dolares} dólares equivalen a {resultado} euros.");
        }
}
