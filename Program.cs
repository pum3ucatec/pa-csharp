
public class Program {
    public static void Main(string[] args) {
        Persona persona = new Persona(1, "Gaston", "Quelali", new DateTime(1980, 1, 1), "Calle 123");
        persona.MostrarInformacion();

        MarcasDeAutos marca1 = new MarcasDeAutos(1, "Lamborghini", "Deportivo", new DateTime(1910, 4, 25), "Enzo Lamborghini");
        marca1.MostrarInformacion();
    }
}