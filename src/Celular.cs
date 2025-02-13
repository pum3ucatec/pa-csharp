public class Celular : DispositivoElectronico {
    public string SistemaOperativo { get; set; }
    public int Almacenamiento { get; set; } // En GB
    public int MemoriaRam { get; set; } // En GB

    
    
    public Celular(int id, string marca, string modelo, string color, int bateria, string sistemaOperativo, int almacenamiento, int memoriaRam)
        : base(id, marca, modelo, color, bateria) { // Llama al constructor de la clase padre
        SistemaOperativo = sistemaOperativo;
        Almacenamiento = almacenamiento;
        MemoriaRam = memoriaRam;
    }

   
    public new void MostrarInformacion() { 
        base.MostrarInformacion(); // Llama al método de la clase padre
        Console.WriteLine($"Sistema Operativo: {SistemaOperativo}");
        Console.WriteLine($"Almacenamiento: {Almacenamiento} GB");
        Console.WriteLine($"Memoria Ram: {MemoriaRam} GB");
    }
}
