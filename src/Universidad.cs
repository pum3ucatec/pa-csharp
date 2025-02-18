public class Universidad {

    public string Nombre { get; set; }
    public Administrativo Rector { get; set; }
    public List<Carrera> Carreras { get; set; }

    public Universidad(string nombre, Administrativo rector) {
        Nombre = nombre;
        Rector = rector;
        Carreras = new List<Carrera>();
    }

    public void MostrarInformacion() {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine("Rector:");
        Rector.MostrarInformacion();
        Console.WriteLine("Carreras:");
        foreach (var carrera in Carreras) {
            carrera.MostrarInformacion();
        }
    }
}