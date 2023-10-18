namespace VeterinariaEF
{
    public class Mascota
    {
        public int MascotaId { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public int Edad { get; set; }
        public int VeterinarioId { get; set; }
        public Veterinario Veterinario { get; set; }

    }
}
