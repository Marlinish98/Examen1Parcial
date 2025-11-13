public class Matricula : ICalculoNota
{
    public Alumno? Alumno { get; set; }
    public Asignatura? Asignatura { get; set; }
    public List<double> NotasParciales { get; set; } = new List<double>();

public double CalcularNotaFinal()
    {
        double suma = 0;
        foreach (var nota in NotasParciales)
            suma += nota;
        return suma;
    }

    public double CalcularNotaFinal(double n1, double n2, double n3)
    {
        return n1 + n2 + n3;
    }

     public void ValidarNotas(double n1, double n2, double n3)
    {
        if (n1 > 30)
            throw new ArgumentException("ERROR: La nota 1 no puede pasar de 30");
        if (n2 > 30)
            throw new ArgumentException("ERROR: La nota 2 no puede pasar de 30");
        if (n3 > 40)
            throw new ArgumentException("ERROR: la nota 3 no puede pasar de 40");
    }
    public string ObtenerMensajeNota(double notaFinal)
    {
        if (notaFinal >= 0 && notaFinal <= 59)
        {
            return "Reprobado";
        }
        else if (notaFinal <= 79)
        {
            return "Bueno";
        }
        else if (notaFinal <= 89)
        {
            return "Muy Bueno";
        }
        else if (notaFinal <= 100)
        {
            return "Sobresaliente";
        }
        return "Nota fuera de rango";
    }
    
   
}