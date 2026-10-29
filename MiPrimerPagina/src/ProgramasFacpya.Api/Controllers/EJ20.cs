using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EJ20 : ControllerBase
{
    [HttpPost("EurosADolares")]
        public IActionResult EurosADolares([FromBody] modelEj20 ejer20)
        {
            const float tipoCambio = 1.09f; // 1 EUR = 1.09 USD
            float resultado = ejer20.euros * tipoCambio;
            return Ok($"{ejer20.euros} euros equivalen a {resultado} dólares.");
        }
}
