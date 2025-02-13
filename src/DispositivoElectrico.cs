public class DispositivoElectronico {
    public int Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Color { get; set; }
    public int Bateria { get; set; }
    

    
    public DispositivoElectronico (int id, string marca, string modelo, string color, int bateria) {

    Id = id;
    Marca = marca;
    Modelo = modelo;
    Color = color;
    Bateria = bateria;
    }


    public void MostrarInformacion() { 
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"modelo: {Modelo}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"bateria: {Bateria}");
        
        } 




}