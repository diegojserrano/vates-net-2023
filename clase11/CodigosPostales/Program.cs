


using System.Xml.Serialization;

namespace CodigosPostales
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Carga del Array
            List<CodigoPostal>[] codigosPostales = CargarCodigosPostales();
            int cantidadNoNulos = codigosPostales.Count(elemento => elemento != null);
            Console.WriteLine($"Cargado! Se procesaron {cantidadNoNulos} códigos postales únicos");
            // Búsqueda por código
            MostrarBusquedaPorCodigo(codigosPostales);
            // Búsqueda por nombre
            MostrarBusquedaPorNombre(codigosPostales);

        }

        private static void MostrarBusquedaPorNombre(List<CodigoPostal>[] codigosPostales)
        {
            Console.WriteLine("Búsqueda por Nombre: ");
            string nombre = "CALERA";
            List<CodigoPostal> codigosFiltrados = BuscarPorNombre(codigosPostales, nombre);
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

        private static List<CodigoPostal> BuscarPorNombre(List<CodigoPostal>[] codigosPostales, string nombre)
        {
            List<CodigoPostal> resultado = new List<CodigoPostal>();
            foreach (List<CodigoPostal> lista in codigosPostales)
            {
                if (lista != null)
                {
                    resultado.AddRange(lista.Where(cp => cp.Nombre == nombre));
                }
            }
            return resultado;
        }

        private static void MostrarBusquedaPorCodigo(List<CodigoPostal>[] codigosPostales)
        {
            Console.WriteLine("Búsqueda por Codigo: ");
            int codigo = 4701;
            List<CodigoPostal> codigosFiltrados = BuscarPorCodigo(codigosPostales, codigo);
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

        private static List<CodigoPostal> BuscarPorCodigo(List<CodigoPostal>[] codigosPostales, int codigo)
        {
            if (codigosPostales[codigo] != null)
            {
                return codigosPostales[codigo];
            }
            else
            {
                return new List<CodigoPostal>();
            }
        }

        private static List<CodigoPostal>[] CargarCodigosPostales()
        {
            List<CodigoPostal>[] codigosPostales = new List<CodigoPostal>[9000];
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
                    if (codigosPostales[codigo] == null)
                    {
                        codigosPostales[codigo] = new List<CodigoPostal>();
                    }
                    codigosPostales[codigo].Add(cp);
                }
            }
            return codigosPostales;

        }
    }
}