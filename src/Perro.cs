public class Perro
{
    public string Raza{get; set;}
    public string Nombre{get; set;}
    public string Color{get; set;}
    public int Edad{get; set;}
    public string Habilidades{get; set;}
    public Perro(string raza , string nombre , string color , int edad ,string habilidades)
    {
        Raza=raza;
        Nombre=nombre;
        Color=color;
        Edad=edad;
        Habilidades=habilidades;
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Raza: {Raza}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Habilidad: {Habilidades}");
        Console.WriteLine("________________");
    }
}