public class ProductoAlimento : Producto
{
    public DateTime FechaVencimiento;
    public double Cantidad;
    public string Tipo;

    public ProductoAlimento(DateTime fechaVencimiento, string id, double cantidad, string tipo, string marca, string stock)
        : base(id, "Producto Alimento", "0", 0, stock)
    {
        FechaVencimiento = fechaVencimiento;
        Cantidad = cantidad;
        Tipo = tipo;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Fecha de Vencimiento: {FechaVencimiento:dd/MM/yyyy}");
        Console.WriteLine($"Cantidad: {Cantidad}");
        Console.WriteLine($"Tipo: {Tipo}");
    }
}


