namespace ProgramasFacpya.Api.Features.Alumnos.Dominio.Entidad;

public class Alumno
{
    public int IdAlumno { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string ApellidoP { get; set; } = string.Empty;
    public string ApellidoM { get; set; } = string.Empty;
    public int IdCarrera { get; set; }
    public DateTime FecRegistro { get; set; }
    //Descripcion de la carrea viene en el join cin Carrera
    public string Carrera { get; set; } = string.Empty;
}
