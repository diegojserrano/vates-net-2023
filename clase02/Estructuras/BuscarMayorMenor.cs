namespace estructuras{
    public class BuscarMayorMenor{
        public void buscarMayorMenor(){
        // Console.WriteLine("Ingrese un número: ");
            int n = int.Parse(Console.ReadLine());
            int mayor = n;
            int menor = n;
            while (n != 0)
            {
                if (n > mayor)
                {
                    mayor = n;
                }
                else if (n < menor)
                {
                    menor = n;
                }
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"El mayor fue {mayor} y el menor fue {menor}");
        }
    }
}







