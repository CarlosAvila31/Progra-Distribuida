using ProgramasFacpya.Api.Models;

namespace ProgramasFacpya.Api.Servicios;

public class BL_ALUMNO
{

    public static bool validarNombre(string texto)
    {
        bool esValido = false;

        foreach(char letra in texto)
        {
            if (char.IsLetter(letra))
            {
                esValido = true;
                break;
            }

        }
        return esValido;
    }

    public static List<string> listaValidaciones(Alumno2 alumno)
    {
        List<string> listResultados = [];

        if (string.IsNullOrWhiteSpace(alumno.Nombre))
        {
            listResultados.Add("El nombre es obligatorio.");
        }

        if (string.IsNullOrWhiteSpace(alumno.ApellidoP))
        {
            listResultados.Add("El apellido paterno es obligatorio.");
        }

        if (string.IsNullOrWhiteSpace(alumno.ApellidoM))
        {
            listResultados.Add("El apellido materno es obligatorio.");
        }

        if (string.IsNullOrWhiteSpace(alumno.Edad))
        {
            listResultados.Add("La edad es obligatoria.");
        }
        else if (!int.TryParse(alumno.Edad, out int edad) || edad < 0)
        {
            listResultados.Add("La edad debe ser un número válido mayor o igual a cero.");
        }

        return listResultados;
    }

    public static bool validarEdad(string edad)
    {
        if (int.TryParse(edad, out int edadNumerica))
        {
            return edadNumerica >= 0;
        }
        return false;
    }
}