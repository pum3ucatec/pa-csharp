public class Animal
{

public string Especie{ get; set; }
public int Edad { get ; set ; }
public double Peso { get; set; }
public string Color { get; set;}

public Animal(string especie, int edad, double peso, string color)
{

Especie = especie;
Edad = edad;
Peso = peso;
color = color:

}
public void MostrarInformacion()
{
Console.WriteLine($"Especie: {Especie}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Peso: {Peso} kg");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine("________________");



}




}