public class Celular {
    public int Id { get; set; }
    public string Phonemodel { get; set; }
    public string Android { get; set; }
    public string Color { get; set; }
    public int Megapixels { get; set; }
    public int Ram { get; set; }
    public int  Internalstorage { get; set; }

    
    public Celular (int id, string phonemodel, string android, string color, int megapixels, int ram, int  internalstorage) {

    Id = id;
    Phonemodel = phonemodel;
    Android = android;
    Color = color;
    Megapixels = megapixels;
    Ram = ram;
    Internalstorage = internalstorage;
    }


    public void MostrarInformacion() { 
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Phonemodel: {Phonemodel}");
        Console.WriteLine($"Android: {Android}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Megapixels: {Megapixels}");
        Console.WriteLine($"Ram: {Ram}");
        Console.WriteLine($"Internalstorage: {Internalstorage}");
        } 




}