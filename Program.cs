Alumno alumno = new Alumno();
Asignatura asignatura = new Asignatura();


alumno.Nombre = "Marlon Martinez";
alumno.NumeroCuenta = "T32521055";
alumno.Email = "marlon_arguijo@unitec.edu";

asignatura.NombreAsignatura = "PROGRAMACION II";
asignatura.NombreDocente = "Ing. Roger Iván Gurdián Castillo";
asignatura.Horario = "6:00 PM a 7:30PM";

try
{
   
    Console.Write("Ingrese nota parcial 1: ");
    double n1 = double.Parse(Console.ReadLine()!);

    Console.Write("Ingrese nota parcial 2: ");
    double n2 = double.Parse(Console.ReadLine()!);

    Console.Write("Ingrese nota parcial 3: ");
    double n3 = double.Parse(Console.ReadLine()!);
    
    Matricula.ValidarNotas(n1, n2, n3);
}
catch (FormatException)
{
    Console.WriteLine("Error: Debe ingresar solo valores numéricos.");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error de validación: {ex.Message}");
}