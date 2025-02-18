
public class Program {
    public static void Main(string[] args) {
       Universidad objUcatec = new Universidad("UCATEC", new Administrativo(1, "Juan", "Perez", new DateTime(1980, 1, 1), "Av. 6 de Agosto", "Rector"));
    
       objUcatec.MostrarInformacion();
        Docente objDocente1 = new Docente(2, "Maria", "Lopez", new DateTime(1985, 2, 2), "Av. 6 de Agosto", "Matemáticas", "Licenciatura"); 
        Materia objMateria1 = new Materia("Matemáticas", objDocente1, "Aula 1", "8:00 - 10:00", 4);
        objMateria1.MostrarInformacion();
    }
}