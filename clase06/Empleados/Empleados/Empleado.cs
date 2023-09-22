using System.Collections;
using System.Runtime.CompilerServices;

namespace Empleados {
public abstract class Empleado: IComparable<Empleado>
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

    // La interfaz exige retornar un entero:
    // > 0 => this > obj
    // = 0 => this == obj
    // < 0 => this < obj
    public int CompareTo(Empleado? otro)
    {
        if (otro == null) return 1;
        return (int)(this.Neto() - otro.Neto());
    }
    }



    public class ComparadorLegajo : IComparer<Empleado>
    {
        public int Compare(Empleado? x, Empleado? y)
        {
            return x.Legajo - y.Legajo;
        }
    }

    public class ComparadorNombre : IComparer<Empleado>
{
    public int Compare(Empleado? x, Empleado? y)
    {
        return x.Nombre.CompareTo(y.Nombre);
    }
}

}