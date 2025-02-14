using System;


public class Producto
{
    public string Id { get; set; }
    public string Nombre { get; set; }
    public string Precio { get; set; }
    public int Marca { get; set; }
    public string Stock { get; set; }

    public Producto(string id, string nombre, string precio, int marca, string stock)
    {
        Id = id;
        Nombre = nombre;
        Precio = precio;
        Marca = marca;
        Stock = stock;
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Precio: {Precio}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Stock: {Stock}");
        Console.WriteLine("---------------------------");
    }
}
