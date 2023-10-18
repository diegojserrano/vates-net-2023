namespace VeterinariaEF
{
    public class Veterinario
    {
        public int VeterinarioId {get;set;}
        public string Nombre {get;set;}
        public List<Mascota> Mascotas {get;set;}
    }
}