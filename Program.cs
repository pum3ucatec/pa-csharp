
public class Program {
    public static void Main(string[] args) {
       Universidad objUcatec = new Universidad("UCATEC", new Administrativo(1, "Juan", "Perez", new DateTime(1980, 1, 1), "Av. 6 de Agosto", "Rector"));

       objUcatec.MostrarInformacion();
    }
}