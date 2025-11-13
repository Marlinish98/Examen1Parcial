using System.IO.Compression;

public class Alumno
{
    public string? Nombre { get; set; }
    public string? NumeroCuenta { get; set; }
    public string? Email { get; set; }

    public void infoAlumno()
    {
        Console.WriteLine("***** BIENVENIDO *****");
        Console.WriteLine($"{Nombre}");
        Console.WriteLine($"Numero de Cuenta: {NumeroCuenta}");
        Console.WriteLine($"Correo Institucional: {Email}");
        Console.WriteLine("************************");
        Console.WriteLine("");
    }

}