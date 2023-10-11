namespace ADOConParametrosYMapeo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola! Seguimos con ADO .NET");
            GestorPersonas gestor = new GestorPersonas();
            // Persona nuevaPersona1 = new Persona(0, "Daniel", "Giacinto", 22, new EstadoCivil(1, "Soltero"));
            // Persona nuevaPersona2 = new Persona(0, "Fabrizio", "Rodriguez", 27, new EstadoCivil(4, "Viudo"));
            // Persona nuevaPersona3 = new Persona(0, "Paloma", "Sosa", 23, new EstadoCivil(2, "Casado"));
            // gestor.Agregar(nuevaPersona1);
            // gestor.Agregar(nuevaPersona2);
            // gestor.Agregar(nuevaPersona3);

            List<Persona> personas = gestor.ObtenerTodos();
            foreach (Persona persona in personas)
            {
                Console.WriteLine($"Nombre: {persona.Nombre}, Apellido: {persona.Apellido}, Edad: {persona.Edad}, Estado Civil: {persona.EstadoCivil.Nombre}");

            }
            List<EstadoCivil> estadoCiviles = gestor.ObtenerEstadosCiviles();
            foreach (EstadoCivil estadoCivil in estadoCiviles)
            {
                Console.WriteLine($"Id: {estadoCivil.Id}, Nombre: {estadoCivil.Nombre}");
            } 

        }
    }
}