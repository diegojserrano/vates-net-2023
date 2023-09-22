
using System.Runtime.InteropServices;

namespace Veterinaria
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            Cliente c1 = new Cliente(14, "Sol", 4, new Mascota("Lila", 6));
            Cliente c2 = new Cliente(23, "Juan", 6, new Mascota("Mora", 5));
            Cliente c3 = new Cliente(12, "Paloma", 3, new Mascota("Polo", 4));
            Cliente c4 = new Cliente(17, "Fabrizio", 8, new Mascota("Zeus", 2));
            List<Cliente> listaClientes = new List<Cliente>() {c1, c2, c3, c4};
            // List<Cliente> listaClientesTeclado = CargarClientesTeclado();
            Console.WriteLine($"La cantidad de clientes es de {listaClientes.Count}");
            double promedio = CalcularPromedioEdad(listaClientes);
            Console.WriteLine($"El promedio de edad de las mascotas es de {promedio}");
            int cantidadClientesAntiguedad = InformarCantidad(listaClientes);
            Console.WriteLine($"La cantidad de clientes con una antiguedad de 5 años o más es de {cantidadClientesAntiguedad}");
            List<Cliente> clientesAntiguedad = ListadoClientes(listaClientes);
            Console.WriteLine("Listado de los datos de todos los clientes cuya mascota tiene más de 5 años de edad:");
            foreach (Cliente cliente in clientesAntiguedad)
            {
                Console.WriteLine(cliente.ToString());
            }

        }

        private static List<Cliente> ListadoClientes(List<Cliente> listaClientes)
        {
            return listaClientes.Where(c=> c.ObtenerEdadMascota() >= 5).ToList();
        }

        private static int InformarCantidad(List<Cliente> listaClientes)
        {
            return listaClientes.Count(c => c.Antiguedad >= 5);
        }

        private static double CalcularPromedioEdad(List<Cliente> listaClientes)
        {
            int suma = 0;
            int cantidad = listaClientes.Count;
            foreach (Cliente c in listaClientes)
            {
                suma += c.ObtenerEdadMascota();
            }
            return suma / cantidad;
        }

        private static List<Cliente> CargarClientesTeclado()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            return listaClientes;
            // Pedir la cantidad de clientes
            // A razon de cada cliente, cargar sus datos
            // Cargar una mascota por cada cliente
            // Agregar el cliente a la lista
        }
    }
}