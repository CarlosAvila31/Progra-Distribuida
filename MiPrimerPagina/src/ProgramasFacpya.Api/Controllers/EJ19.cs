using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EJ19 : ControllerBase
{
    [HttpPost("EurosAPesos")]
        public IActionResult EurosAPesos([FromBody] modelEj19 ejer19)
        {
            const float tipoCambio = 19.5f; // 1 EUR = 19.5 MXN
            float resultado = ejer19.euros * tipoCambio;
            return Ok($"{ejer19.euros} euros equivalen a {resultado} pesos.");
        }
}
