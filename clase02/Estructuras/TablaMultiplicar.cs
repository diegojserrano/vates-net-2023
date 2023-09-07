namespace estructuras{
    public class TablaMultiplicar{
        public void MostrarTabla(){
            Console.WriteLine("Ingrese un número: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                int resultado = n * i;
                Console.WriteLine($"{n} * {i} = {resultado}");
            }
        }
    }
}