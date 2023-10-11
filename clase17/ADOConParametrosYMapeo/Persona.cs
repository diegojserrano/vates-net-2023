namespace ADOConParametrosYMapeo
{
    public class Persona
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get;set;}
        public int Edad {get;set;}
        public EstadoCivil EstadoCivil {get;set;}
        public Persona(int id, string nombre, string apellido, int edad, EstadoCivil estadoCivil)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            EstadoCivil = estadoCivil;
        }
    }
}