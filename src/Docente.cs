public class Docente {
    public int Id { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; } 
    public string Profesion { get; set; }

    public Docente(int id, string nombres, string apellidos, string profesion) {
        Id = id;
        Nombres = nombres;
        Apellidos = apellidos;
        Profesion = profesion;
    }


    public void MostrarInformacion() {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Profesión: {Profesion}");
    }

}