using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EJ17 : ControllerBase
{
    [HttpPost("PesosADolares")]
        public IActionResult PesosADolares([FromBody] modelEj17 ejer17)
        {
            const float tipoCambio = 1f / 18f; // 1 MXN = 0.055 USD
            float resultado = ejer17.pesos * tipoCambio;
            return Ok($"{ejer17.pesos} pesos equivalen a {resultado} dólares.");
        }
}
