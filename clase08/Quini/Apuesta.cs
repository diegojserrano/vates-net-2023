namespace Quini6
{
    public class Apuesta 
    {
        // Colección de números -> array, lista, HashSet
        public HashSet<int> Numeros {get;}
        public Apuesta()
        {
            Numeros = new HashSet<int>();
            var random = new Random();
            while (Numeros.Count < 6)
            {
                Numeros.Add(random.Next(1,47));
            }
        }
        public override string ToString()
        {
            return string.Join(", ", Numeros);
        }

    }
}