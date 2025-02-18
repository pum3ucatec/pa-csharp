
public class Program {
    public static void Main(string[] args) {
        Universidad objUcatec = new Universidad("UCATEC", new Administrativo(1, "Juan", "Perez", new DateTime(1980, 1, 1), "Av. 6 de Agosto", "Rector"));
    
        objUcatec.MostrarInformacion();
       
        Docente objDocente1 = new Docente(3,"Sergio","Lopez", new DateTime(1994,5,3), "Av America ", "Algebra Superior","Ingeneria");
        objDocente1.MostrarInformacion();
       
        Docente objDocente2 = new Docente(2, "Luis", "Jala", new DateTime(1992, 10, 6), "Av. Circunvalacion", "Programacion Estructurada", "Licenciatura"); 
        objDocente2.MostrarInformacion();
       
        Administrativo objAdmistrativo1 = new Administrativo(1,"Jannet","Claros", new DateTime(1990,4,5),"Z. Amancayas","Admistrativa de becas ");
        objAdmistrativo1.MostrarInformacion();
       
        Administrativo objAdmistrativo2 = new Administrativo(4,"Kimberli","Candia",new DateTime(1997,8,12),"Z. Quintanilla","Personal de inscripcion");
        objAdmistrativo2.MostrarInformacion();
       
        Materia objMateria1 = new Materia("Algebra Superior", objDocente1, "Aula A 24", "8:00 - 10:00", 5);
        objMateria1.MostrarInformacion();
       
        Materia objMateria2 =new Materia("Programacion Avanzada",objDocente2,"Lab 3","11-01:00",7);
        objMateria2.MostrarInformacion();
    }
}