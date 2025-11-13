Alumno alumno = new Alumno();
Asignatura asignatura = new Asignatura();
Matricula matricula = new Matricula();


alumno.Nombre = "Marlon Martinez";
alumno.NumeroCuenta = "T32521055";
alumno.Email = "marlon_arguijo@unitec.edu";

asignatura.NombreAsignatura = "PROGRAMACION II";
asignatura.NombreDocente = "Ing. Roger Iván Gurdián Castillo";
asignatura.Horario = "6:00 PM a 7:30PM";

try
{

    alumno.infoAlumno();
    asignatura.infoAsignatura();
    Console.Write("Ingrese nota parcial 1: ");
    double n1 = double.Parse(Console.ReadLine()!);

    Console.Write("Ingrese nota parcial 2: ");
    double n2 = double.Parse(Console.ReadLine()!);

    Console.Write("Ingrese nota parcial 3: ");
    double n3 = double.Parse(Console.ReadLine()!);

    matricula.ValidarNotas(n1, n2, n3);

    matricula.NotasParciales.Add(n1);
    matricula.NotasParciales.Add(n2);
    matricula.NotasParciales.Add(n3);

    double notaFinalLista = matricula.CalcularNotaFinal();
    double notaFinalParametros = matricula.CalcularNotaFinal(n1, n2, n3);

    Console.WriteLine("\n--- RESULTADOS DE NOTAS ---");
    Console.WriteLine($"Su nota es de: {notaFinalLista} {matricula.ObtenerMensajeNota(notaFinalLista)}");// sin parametro
    Console.WriteLine($"Su Nota final es: {notaFinalParametros} {matricula.ObtenerMensajeNota(notaFinalParametros)}");// Parametro
   
}
catch (FormatException)
{
    Console.WriteLine("ERRO: Solo se aceptan valores Numericos");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error de validación: {ex.Message}");
}
