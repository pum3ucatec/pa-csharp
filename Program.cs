
public class Program {
    public static void Main(string[] args) {
        Persona persona = new Persona(1, "Gaston", "Quelali", new DateTime(1980, 1, 1), "Calle 123");
        persona.MostrarInformacion();

        Docente objDocente1 = new Docente(1, "Bismark", "Gutierrez", "Licenciado en Matematicas");
        objDocente1.MostrarInformacion();

        Docente objDocente2 = new Docente(1, "Luis", "Nina Jala", "Licenciado en Ingenieria de Sistemas");
        objDocente2.MostrarInformacion();
    }
}