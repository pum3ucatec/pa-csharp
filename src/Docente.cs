public class Docente : Persona
{
    public string Especialidad { get; set; }
    public string GradoAcademico { get; set; }
    public string CursosAsignados { get; set; }

    public Docente(int id, string nombres, string apellidos, DateTime fechaNacimiento, string direccion, string especialidad, string gradoAcademico, string cursosAsignados) : base(id, nombres, apellidos, fechaNacimiento, direccion) {
        Especialidad = especialidad;
        GradoAcademico = gradoAcademico;
        CursosAsignados = cursosAsignados;
    }

    public new void MostrarInformacion() {
        base.MostrarInformacion();
        Console.WriteLine($"Especialidad: {Especialidad}");
        Console.WriteLine($"Grado Académico: {GradoAcademico}");
        Console.WriteLine($"Cursos Asignados: {CursosAsignados}");
    }
}