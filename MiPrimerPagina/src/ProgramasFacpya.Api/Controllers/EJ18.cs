using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EJ18 : ControllerBase
{
    [HttpPost("PesosAEuros")]
        public IActionResult PesosAEuros([FromBody] modelEj18 ejer18)
        {
            const float tipoCambio = 1f / 19.5f; // 1 MXN = 0.051 EUR
            float resultado = ejer18.pesos * tipoCambio;
            return Ok($"{ejer18.pesos} pesos equivalen a {resultado} euros.");
        }
}
