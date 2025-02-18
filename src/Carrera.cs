public class Carrera {
    public string Nombre { get; set; }  
    public int Duraccion { get; set; }
    public string JefeCarrera { get; set; }
    public List<Materia> Materias { get; set; }

    public Carrera(string nombre, int duraccion, string jefeCarrera) {
        Nombre = nombre;
        Duraccion = duraccion;
        JefeCarrera = jefeCarrera;
        Materias = new List<Materia>();
    }

    public void MostrarInformacion() {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Duracción: {Duraccion}");
        Console.WriteLine($"Jefe de Carrera: {JefeCarrera}");
        Console.WriteLine("Materias:");
        foreach (var materia in Materias) {
            materia.MostrarInformacion();
        }
    }
}