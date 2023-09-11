// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

namespace Puntos {
public class Program {

    public static void Main() {

        Punto p1 = new Punto(4,5); 
        Punto p2 = new Punto(0,0);
        System.Console.WriteLine(p1);
        System.Console.WriteLine(p2);
        System.Console.WriteLine((int)Cuadrante.Origen);

        if (p1.Cuadrante != p2.Cuadrante) {}

    }

}




}