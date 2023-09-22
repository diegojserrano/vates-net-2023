
namespace Quini6
{
    public class Simulador
    {
        public List<Apuesta> Apuestas {get;}
        public Simulador()
        {
            Apuestas = new List<Apuesta>();
        }
        public void GenerarApuesta()
        {
            Apuesta apuesta = new Apuesta();
            Apuestas.Add(apuesta);
        }

        public void MostrarApuesta()
        {
            Console.WriteLine("Listado de apuestas:");
            foreach (Apuesta a in Apuestas)
            {
                Console.WriteLine(a.ToString());
            }
        }
    }
}