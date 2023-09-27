
using System.Text.RegularExpressions;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        var watch = Stopwatch.StartNew();

        var todasQuijote = PalabrasUnicas("Quijote.txt");
        var diccionario = PalabrasUnicas("words_alpha.txt");
        var inexistentes = todasQuijote.Except(diccionario);

        watch.Stop();
        var duracion = watch.Elapsed.TotalSeconds;

        Console.WriteLine(todasQuijote.Count);
        Console.WriteLine(diccionario.Count);
        Console.WriteLine(inexistentes.Count());
        Console.WriteLine(string.Join(", ", inexistentes.OrderBy(x => x)));
        Console.WriteLine(duracion);
    }

    static HashSet<string> PalabrasUnicas(string nombreArchivo)
    {
        Regex regex = new Regex("[^a-z ]");
        var palabras = new HashSet<string>();

        using (var archivo = new StreamReader(nombreArchivo))
        {
            string linea;
            while ((linea = archivo.ReadLine()) != null)
            {
                var palabrasLinea = regex.Replace(linea.ToLower(), "").Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                palabras.UnionWith(palabrasLinea);
            }
        }

        return palabras;
    }
}