using System;

namespace Clase03 {
class Program
{
    public static void Main(string[] args) {
        Persona per1 =  new Persona(12, "Juan", "Perez", 2003);
    
        System.Console.WriteLine(per1.Nombre);
        System.Console.WriteLine(per1.NombreCompleto);
        Console.WriteLine(per1);

    }
    
}


}