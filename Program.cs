public class Program {
    public static void Main(string[] args) {
        Universidad objUcatec = new Universidad("UCATEC", new Administrativo(1, "Juan", "Perez", new DateTime(1980, 1, 1), "Av. 6 de Agosto", "Rector"));
    
        objUcatec.MostrarInformacion();
       
        Docente objDocente1 = new Docente(3,"Bismar","Guetierres", new DateTime(1995,9,15), "Av German Buch ", "Calculo ","Licenciado");
        objDocente1.MostrarInformacion();
       
        Docente objDocente2 = new Docente(2, "Boris", "Pastor", new DateTime(1999, 6, 10), "Z. Cala cala ", "Tecnicas De  Estudio", "Licenciatura"); 
        objDocente2.MostrarInformacion();
       
        Administrativo objAdmistrativo1 = new Administrativo(1,"Carmen","Villa Nueva", new DateTime(1991,8,25),"Av. Atawalpa","Cajera ");
        objAdmistrativo1.MostrarInformacion();
       
        Administrativo objAdmistrativo2 = new Administrativo(4,"Raul","Mamani",new DateTime(1993,12,31),"Av. Circunvalacion","persolana de cuentas ");
        objAdmistrativo2.MostrarInformacion();
       
        Materia objMateria1 = new Materia("Algebra Superior", objDocente1, "Aula A 24", "8:00 - 10:00", 8);
        objMateria1.MostrarInformacion();
       
        Materia objMateria2 =new Materia("Programacion Avanzada",objDocente2,"Lab 3","11-01:00",4);
        objMateria2.MostrarInformacion();
    }
}