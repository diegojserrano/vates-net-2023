namespace Empleados {
public class Vendedor: Empleado
{
    public double Ventas {get; set;}

    public override double Neto() => Basico + Ventas * 0.01;

    public Vendedor(int legajo, string nombre, double basico, double ventas): base(legajo, nombre, basico) {
        Ventas = ventas;
    }
}
}