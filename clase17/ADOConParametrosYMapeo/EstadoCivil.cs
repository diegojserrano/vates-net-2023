namespace ADOConParametrosYMapeo
{
    public class EstadoCivil
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public EstadoCivil(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}