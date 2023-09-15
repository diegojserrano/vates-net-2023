namespace Empleados {
public class Administrativo: Empleado
{
    public bool Presentismo {get; set;}

    public override double Neto() => (Presentismo) ? Basico * 1.31: Basico;

    public Administrativo(int legajo, string nombre, double basico, bool presentismo): base(legajo, nombre, basico) {
        Presentismo = presentismo;
    }
}
}