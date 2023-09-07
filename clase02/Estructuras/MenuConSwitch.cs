namespace estructuras{
    public class MenuConSwitch{
        public void Menu(){
            int opcion;
            double n1;
            double n2;
            double resultado;
            string mensaje;
            opcion = -1;
            while (opcion != 0)
            {
                Console.WriteLine("***** CALCULADORA *****");
                Console.WriteLine("1. Sumar.");
                Console.WriteLine("2. Restar.");
                Console.WriteLine("3. Multiplicar.");
                Console.WriteLine("4. Dividir.");
                Console.WriteLine("5. Elevar a la potencia.");
                Console.WriteLine("0. Salir.");
                Console.Write("Seleccione una opción (1 - 5): ");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un número: ");
                n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un número: ");
                n2 = double.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 0:
                        mensaje = $"Adios!";
                        break;
                    case 1:
                        resultado = n1 + n2;
                        mensaje = $"El resultado de la suma de {n1} + {n2} es {resultado}";
                        break;
                    case 2:
                        resultado = n1 - n2;
                        mensaje = $"El resultado de la resta de {n1} + {n2} es {resultado}";
                        break;
                    case 3:
                        resultado = n1 * n2;
                        mensaje = $"El resultado de la multiplicación de {n1} + {n2} es {resultado}";
                        break;
                    case 4:
                        resultado = n1 / n2;
                        mensaje = $"El resultado de la divisón de {n1} + {n2} es {resultado}";
                        break;
                    case 5:
                        resultado = Math.Pow(n1,n2);
                        mensaje = $"El resultado de la potenciación de {n1} + {n2} es {resultado}";
                        break;
                    default:
                        resultado = 0;
                        mensaje = "Seleccione una opción correcta";
                        break;
                }
                Console.WriteLine(mensaje);
            }
        }
    }
}
