// using ProgramasFacpya.Api.Servicios;
// using Microsoft.AspNetCore.Mvc;
// using ProgramasFacpya.Api.Models;

// namespace ProgramasFacpya.Api.Controllers;

// [ApiController]
// [Route("[controller]")]
// public class AlumnoController(AlumnosService service) : ControllerBase
// {

//     private readonly AlumnoService _service = service;

//     [HttpPost("ObtenerTodos")]
//     public async Task<IActionResult> ObtenerTodos()
//     {
//         var response = await _service.ObtenerTodos();
//         return Ok(await _service.ObtenerTodos());
//     }



//     // public IActionResult ObtenerTodos()
//     // {
//     //     string nombre, apellidoP, apellidoM, edad;

//     //     nombre = alumno.Nombre;
//     //     apellidoP = alumno.ApellidoP;
//     //     apellidoM = alumno.ApellidoM;
//     //     edad = alumno.Edad;

//     //     List<string> resultadosValidacion = BL_ALUMNO.listaValidaciones(new Alumno2(nombre, apellidoP, apellidoM, edad));
//     //     {
//     //         if (resultadosValidacion.Count == 0)
//     //         {
//     //             return Ok(new
//     //             {
//     //                 Code = "00",
//     //                 Values= "",
//     //                 Message = "Alumno registrado correctamente"
//     //             });
//     //         }
//     //         else
//     //         {
//     //             return Ok(new
//     //             {
//     //                 Code = "01",
//     //                 Values= resultadosValidacion,
//     //                 Message = "Error al registrar alumno"
//     //             });
//     //         }
//     //         }
//     //     }

//         // Lógica para registrar al alumno


//         public async Task<ApResponse<IEnumerable<Alumno>>> ObtenerTodos()
//         {
//             using var connection = _db.CreateConnection();
//             var sql = "@SELECT a.IdAlumno, a.Nombre, a.ApellidoP, a.ApellidoM, a.IdCarrera, a.FecRegistro, c.Descripcion AS Carrera FROM Alumno a INNER JOIN Carrera c ON a.IdCarrera = c.IdCarrera ORDER BY a.apellidoP, a.ApellidoM, a.Nombre";
//             var alumnos = await connection.QueryAsync<Alumno>(sql);
//             return ApiResponse<IEnumerable<Alumno>>.Ok(alumnos);
//         }
//     }
