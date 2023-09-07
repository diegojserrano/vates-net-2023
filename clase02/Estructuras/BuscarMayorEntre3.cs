namespace estructuras{
    public class BuscarMayorEntre3{
        public void buscarMayor(){
            Console.WriteLine("Hello, World!");
            int n1, n2, n3;
            Console.WriteLine("Ingrese un número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número: ");
            n3 = int.Parse(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine($"El número más grande es {n1}");
            }
            else if (n2 > n3)
            {
                Console.WriteLine($"El número más grande es {n2}");
            }
            else
            {
                Console.WriteLine($"El número más grande es {n3}");
            }
        }
    }
}