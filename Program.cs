
public class Program {
    public static void Main(string[] args) {
        Persona persona = new Persona(1, "Gaston", "Quelali", new DateTime(1980, 1, 1), "Calle 123");
        persona.MostrarInformacion();


        Celular objCelular1 = new Celular(1, "Samsung", "GalaxyA15", "Negro", 5000, "Android", 128, 6);
        objCelular1.MostrarInformacion();
        
        Celular objCelular2 = new Celular(2, "Realme", "Realme12PRo", "Verde", 5000, "Android", 256, 8);
        objCelular2.MostrarInformacion();
        
        Celular objCelular3 = new Celular(3, "Samsung", "GalaxyA54", "Blanco", 5000, "Android", 128, 6);
        objCelular3.MostrarInformacion();

        Celular objCelular4 = new Celular(4, "Google", "Pixel7", "Obsidian", 4355, "Android", 128, 8);
        objCelular4.MostrarInformacion();

        Celular objCelular5 = new Celular(5, "Samsung", "S22", "Borgoña", 3700, "Android", 256, 12);
        objCelular5.MostrarInformacion();
    }
}