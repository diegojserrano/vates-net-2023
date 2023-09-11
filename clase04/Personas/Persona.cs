namespace Personas {

    public class Persona {

        public int Documento {get; set; }
        public string Nombre {get; set; }
        public string Apellido {get; set; }
        public int Edad {get; set; }
        
        public Persona(int documento, string nombre, string apellido, int edad)
        {
            Documento = documento;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public override string ToString()
        {
            return $" {Documento} {Nombre} {Apellido} {Edad}";
        }
    }
}