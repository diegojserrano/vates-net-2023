namespace Empleados {
public abstract class Empleado
{
    public int Legajo { get; set; }

    public string Nombre { get; set; }
    public double Basico { get; set; }

    public abstract double Neto();

    public Empleado(int legajo, string nombre, double basico) {
        Legajo = legajo;
        Nombre = nombre;
        Basico = basico;
    }

    public override string ToString() => $"{Legajo,4} {Nombre,-20} {Basico:C2} {Neto():C2}";

}
}