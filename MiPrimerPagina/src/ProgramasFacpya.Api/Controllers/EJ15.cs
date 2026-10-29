using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EJ15 : ControllerBase
{
    [HttpPost("DolaresAPesos")]
        public IActionResult DolaresAPesos([FromBody] modelEj15 ejer15)
        {
            const float tipoCambio = 18f; 
            float resultado = ejer15.dolares * tipoCambio;
            return Ok($"{ejer15.dolares} dólares equivalen a {resultado} pesos.");
        }
    
}
