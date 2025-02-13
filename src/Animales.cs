public class Animal
{

public string Nombres{ get; set; }
public int Habitat { get ; set ; }
public double Dieta { get; set; }
public string Edad { get; set;}

public Animal(string nombre, int habitat, double dieta, string edad)
{

   Nombres = nombre;
   Habitat = habitat;
   Dieta = dieta;
   Edad = edad;
}
public void MostrarInformacion()
{
Console.WriteLine($"Nombre: {Nombres}");
        Console.WriteLine($"Habitat: {Habitat}");
        Console.WriteLine($"Dieta: {Dieta} kg");
        Console.WriteLine($"Edad: {Edad}");




}




}