namespace Empleados {
public class Obrero: Empleado
{
    public int DiasTrabajados {get; set; }

    public override double Neto() => Basico / 22 * DiasTrabajados;

    public Obrero(int legajo, string nombre, double basico, int diasTrabajados): base(legajo, nombre, basico) {
        DiasTrabajados = diasTrabajados;
    }
}
}