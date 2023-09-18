namespace Empleados {
public class Obrero: Empleado, IImprimible
{
    public int DiasTrabajados {get; set; }

    public override double Neto() => Basico / 22 * DiasTrabajados;

        public void imprimir()
        {
            System.Console.WriteLine("SALIDA POR IMPRESORA: SOY UN OBRERO =>" + ToString());
        }

        public Obrero(int legajo, string nombre, double basico, int diasTrabajados): base(legajo, nombre, basico) {
        DiasTrabajados = diasTrabajados;
    }
}
}