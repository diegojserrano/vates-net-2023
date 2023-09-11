using System.Numerics;

namespace Personas {

    public class Program {

        public static void Main() {
            
            // Cargar por teclado personas
            // Fin de la carga con documento 0
            // Mostrar el toString de la de mayor edad


            // Modificarlo para que lea las personas desde el csv
            // Si hay empate con la mayor edad, tratar de buscar la
            // que quede al último en el diccionario, por apellido y nombre.




            int documento;
            string nombre;
            string apellido;
            int edad;

            String linea = "22861213,RUBEN,GIL,14";
            string []datos = linea.Split(",");
            foreach(string d in datos) {
                documento = int.Parse(datos[0]);
                nombre = datos[1];
                apellido = datos[2];
                edad = int.Parse(datos[3]);
                Persona p = new Persona(documento, nombre, apellido, edad);
            }

            Persona mayor = null;

            System.Console.Write("Ingrese el documento: ");
            documento = int.Parse(Console.ReadLine());

            while(documento != 0) {

                    
                System.Console.Write("Ingrese el nombre: ");
                nombre = Console.ReadLine();

                System.Console.Write("Ingrese el apellido: ");
                apellido = Console.ReadLine();

                System.Console.Write("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());

                Persona nueva = new Persona(documento, nombre, apellido, edad);
                System.Console.WriteLine(nueva);


                if (mayor == null) {
                    if (nueva.Edad > mayor.Edad)
                        mayor = nueva;
                    else if (nueva.Edad == mayor.Edad) {
                        //Comparar apellidos y si tambien son iguales comparar nombres
                    }
                }

                System.Console.Write("Ingrese el documento: ");
                documento = int.Parse(Console.ReadLine());
            }

            if (mayor != null)
                System.Console.WriteLine("La persona de mayor edad es: "+ mayor);
            else
                System.Console.WriteLine("No cargó ninguna persona");


        }
    }
}