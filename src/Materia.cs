public class Materia {
    public string Nombre { get; set; }
    public Docente Profesor { get; set; } 
    public string Aula { get; set; }
    public string Horario { get; set; } 
    public int Creditos { get; set; }

    public Materia(string nombre, Docente profesor, string aula, string horario, int creditos) {
        Nombre = nombre;
        Profesor = profesor;
        Aula = aula;
        Horario = horario;
        Creditos = creditos;
    }

    public void MostrarInformacion() {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Profesor: {Profesor.Nombres} {Profesor.Apellidos}");
        Console.WriteLine($"Aula: {Aula}");
        Console.WriteLine($"Horario: {Horario}");
        Console.WriteLine($"Creditos: {Creditos}");
    }
}