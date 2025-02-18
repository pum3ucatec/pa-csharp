
public class Program {
    public static void Main(string[] args) {
       Universidad objUcatec = new Universidad("UCATEC", new Administrativo(1, "Juan", "Perez", new DateTime(1980, 1, 1), "Av. 6 de Agosto", "Rector"));
    
       objUcatec.MostrarInformacion();
        Docente objDocente1 = new Docente(1, "Fernando", "Ferrufino", new DateTime(1980, 9, 8), "Av. Ayacucho", "Algebra Lineal", "Licenciatura"); 
        objDocente1.MostrarInformacion();
        
        Docente objDocente2 = new Docente(2, "Joseph", "Ferrufino", new DateTime(1995, 10, 5), "Av. Panamericana", "Administracion General", "Licenciatura");
        objDocente2.MostrarInformacion();

        Administrativo objAdministrativo1 = new Administrativo(1, "Jeanneth", "Vargas", new DateTime(2000, 12, 25), "Av. Heroinas", "Caja");
        objAdministrativo1.MostrarInformacion();
        
        Administrativo objAdministrativo2 = new Administrativo(2, "Luna", "Lujan", new DateTime(1998, 01, 01), "Av. Bush", "Seguridad");
        objAdministrativo2.MostrarInformacion();

        Materia objMateria1 = new Materia("Algebra Lineal", objDocente1, "Aula L3", "8:30 - 10:30", 10);
        objMateria1.MostrarInformacion();
        
        Materia objMateria2 = new Materia("Administracion General", objDocente2, "Aula C23", "11:00 - 13:00", 5);
        objMateria2.MostrarInformacion();


    }
}


