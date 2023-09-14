namespace EjercicioHospital
{
    public class Paciente 
    {
        public string Nombre {get;set;}
        public int Sintoma {get;set;} // 1- Corazón | 2- Pulmon | 3- Otro
        public bool EsHabitual {get;set;}

        public Paciente(string nombre, int sintoma, bool habitual)
        {
            Nombre = nombre;
            Sintoma = sintoma;
            EsHabitual = habitual;
        }
    }
}