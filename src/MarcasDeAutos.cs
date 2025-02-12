
public class MarcasDeAutos {
    public int Id { get; set; } 
    public string Nombres { get; set; }
    public string Estilo { get; set; }
    public DateTime FechaLansamiento { get; set; }
    public string Fundador { get; set; }

    public MarcasDeAutos(int id, string nombres, string estilo, DateTime fechalansamiento, string fundador ) {
        Id = id;
        Nombres = nombres;
        Estilo = estilo;
        FechaLansamiento = fechalansamiento;
        Fundador = fundador;
    }

    public void MostrarInformacion() {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Estilo: {Estilo}");
        Console.WriteLine($"Fecha de Lansamiento: {FechaLansamiento}");
        Console.WriteLine($"Fundador de la Marca: {Fundador}");
    }


}