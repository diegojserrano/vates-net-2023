
public class Principal {

    public static void Main() {

        Console.Write("Ingrese su apellido: ");
        string apellido = Console.ReadLine();
        Console.WriteLine($"Hola {apellido}!");

        int x = 34523432;
        float precio = 234.345f;

        Console.WriteLine($"""
                    Estoy en

                    |{x,-17:N0}|
                    la clase\n 1.....
                    {precio,8:C}
                    """);
        string? nombre = null;
        Console.WriteLine(nombre??"No indicado");
        Console.WriteLine(nombre?.Length);
    }
}