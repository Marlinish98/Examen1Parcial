public class Asignatura
{
    public string? NombreAsignatura { get; set; }
    public string? NombreDocente { get; set; }
    public string? Horario { get; set; }
    public void infoAsignatura()
    {
        Console.WriteLine("");
        Console.WriteLine("***** INFORMACION DE SU CLASE *****");
        Console.WriteLine($"{NombreAsignatura}");
        Console.WriteLine($"Nombre del Docente: {NombreDocente}");
        Console.WriteLine($"Horario de clase: {Horario}");
        Console.WriteLine("************************");
        Console.WriteLine("");
    }
    
}