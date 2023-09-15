namespace Empleados {

public class Programa {

    public static void Main() {

        Empleado e1 = new Obrero(1, "Juan Perez", 200000, 24);
        Empleado e2 = new Vendedor(2, "Otro vendedor", 200000, 10000000);
        Empleado e3 = new Administrativo(3, "Otro adm.", 200000, true);
        
        List<Empleado> plantel = new List<Empleado>();
        plantel.Add(e1);
        plantel.Add(e2);
        plantel.Add(e3);
        plantel.Add(new Obrero(4, "Otro obrero", 200000, 21));

        

        foreach (Empleado e in plantel)
            System.Console.WriteLine(e);

        // Promedio de los dias trabajados de los obreros
        int suma = 0, cantidad = 0;

        foreach (Empleado e in plantel)

            if (e is Obrero o) { // El operador is sólo tiene sentido con clases derivadas
                suma += o.DiasTrabajados;
                cantidad++;
            }

        double promedio = (double)suma / cantidad;
        System.Console.WriteLine($"Promedio de días:{promedio:N2}");
    }

}

}