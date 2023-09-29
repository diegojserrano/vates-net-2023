namespace CodigosPostales
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Carga del Array
            Correo c = CargarCodigosPostales();
            
            Console.WriteLine($"Cargado! Se procesaron {c.CantidadCodigosUnicos} códigos postales únicos");
            // Búsqueda por código
            MostrarBusquedaPorCodigo(c);
            // Búsqueda por nombre
            MostrarBusquedaPorNombre(c);

            System.Console.WriteLine("Cantidad de codigos por cada provincia ");
            foreach(KeyValuePair<string, int> par in c.CantidadPorProvincia) {
                System.Console.WriteLine($"{par.Key} = {par.Value}");
            }

        }

        private static void MostrarBusquedaPorNombre(Correo c)
        {
            Console.WriteLine("Búsqueda por Nombre: ");
            string nombre = "LAS";
            List<CodigoPostal> codigosFiltrados = c.BuscarPorNombre(nombre);
            if (codigosFiltrados.Count != 0)
            {
                Console.WriteLine("Se encontraron las siguientes localidades: ");
                foreach (CodigoPostal cp in codigosFiltrados) { Console.WriteLine(cp); }
            }
            else
            {
                Console.WriteLine("No se encontró ninguna localidad con ese nombre");
            }
        }

        private static void MostrarBusquedaPorCodigo(Correo c)
        {
            Console.WriteLine("Búsqueda por Codigo: ");
            int codigo = 4701;
            List<CodigoPostal> codigosFiltrados = c.BuscarPorCodigo(codigo);
            if (codigosFiltrados.Count != 0)
            {
                Console.WriteLine($"Códigos Postales encontrados correspondientes al código {codigo}");
                foreach (CodigoPostal cp in codigosFiltrados) {Console.WriteLine(cp);}
            }
            else
            {
                Console.WriteLine("No se encontraron códigos");
            }

        }
        private static Correo CargarCodigosPostales()
        {
            Correo c = new Correo();
            using (StreamReader reader = new StreamReader("cp.csv"))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] datos = linea.Split(";");
                    string provincia = datos[0];
                    int codigo = int.Parse(datos[1]);
                    string nombre = datos[2];
                    CodigoPostal cp = new CodigoPostal(provincia, nombre, codigo);
                    c.AgregarCodigo(cp);
                }
            }
            return c;

        }
    }
}