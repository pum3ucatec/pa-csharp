public class Administrativo: Persona {
    public string Cargo { get; set; }
    public Administrativo(int id, string nombres, string apellidos, DateTime fechaNacimiento, string direccion, string cargo) : base(id, nombres, apellidos, fechaNacimiento, direccion) {
        Cargo = cargo;
    }
    public new void MostrarInformacion() {
        base.MostrarInformacion();
        Console.WriteLine($"Cargo: {Cargo}");
    }
}