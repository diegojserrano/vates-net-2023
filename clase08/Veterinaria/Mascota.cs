namespace Veterinaria 
{
    public class Mascota 
    {
        public string Nombre {get;set;}
        public int Edad {get;set;}

        public Mascota(){}
        public Mascota(string nom, int edad) 
        {
            Nombre = nom;
            Edad = edad;
        }

    }
}