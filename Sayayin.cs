using System;
public class Sayayin
{

    public string Nombres{get; set;}
    public string Poder {get ; set;}
    public string Tecnicas {get; set;}
    public int Edad {get; set;}
    public string Evoluciones{get;set;}

    public Sayayin (string nombres ,string poder,string tecnicas,int edad ,string evoluciones)
    {
    
    Nombres=nombres;
    Poder=poder;
    Tecnicas=tecnicas;
    Edad =edad;
    Evoluciones=evoluciones;
    }

public void MostrarInformacion() 
{

    Console.WriteLine($"Nombres: {Nombres}");
    Console.WriteLine($"Poder:{Poder}");
    Console.WriteLine($"Tecnicas:{Tecnicas}");
    Console.WriteLine($"Edad:{Edad}");
    Console.WriteLine($"Evoluciones:{Evoluciones}");
    Console.WriteLine("---------------------------");
    
}

}