
public class Program {
    public static void Main(string[] args) {
        Persona persona = new Persona(1, "Gaston", "Quelali", new DateTime(1980, 1, 1), "Calle 123");
        persona.MostrarInformacion();


        Celular objCelular1 = new Celular(1, "GalaxyA15", "14", "Negro", 50, 4, 128);
        objCelular1.MostrarInformacion();
        
        Celular objCelular2 = new Celular(2, "Realme12PRo", "13", "Verde", 100, 8, 128);
        objCelular2.MostrarInformacion();
        
        Celular objCelular3 = new Celular(3, "GalaxyA54", "13", "Blanco", 50, 8, 256); 
        objCelular3.MostrarInformacion();

        Celular objCelular4 = new Celular(4, "GooglePixel7", "13", "Obsidian", 50, 8, 256);
        objCelular4.MostrarInformacion();

        Celular objCelular5 = new Celular(5, "GalacyS22", "13", "Borgoña", 108, 12, 512);
        objCelular5.MostrarInformacion();
    }
}