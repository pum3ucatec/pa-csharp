public class Felinos {
    public string Especie { get; set; } 
    public string Tamaño { get; set; }
    public string Dieta { get; set; }
    public int Velocidad { get; set; }
    public string Estado { get; set; }

    public Felinos(string especie, string tamaño, string dieta, int velocidad, string estado) {
        Especie = especie;
        Tamaño = tamaño;
        Dieta = dieta;
        Velocidad = velocidad;
        Estado = estado;
    }

    public void MostrarInformacion() {
        Console.WriteLine($"ESTADO: {Estado}");
        Console.WriteLine($"TAMAÑO: {Tamaño}");
        Console.WriteLine($"DIETA: {Dieta}");
        Console.WriteLine($"VELOCIDAD: {Velocidad}");
        Console.WriteLine($"ESTADO: {Estado}");
    }
}
