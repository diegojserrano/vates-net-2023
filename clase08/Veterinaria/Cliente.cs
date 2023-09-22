namespace Veterinaria
{
    public class Cliente
    {
        public int NroCliente { get; set; }
        public string Nombre { get; set; }
        public int Antiguedad { get; set; }
        public List<Mascota> Mascotas { get; set; }

        public Cliente() { }

        public Cliente(int nro, string nom, int ant, List<Mascota> masc)
        {
            NroCliente = nro;
            Nombre = nom;
            Antiguedad = ant;
            Mascota = masc;
        }

        public override string ToString()
        {
            string output = "";
            output += $"Número de cliente: {this.NroCliente}" + Environment.NewLine;
            output += $"Nombre: {this.Nombre}" + Environment.NewLine;
            output += $"Antigüedad: {this.Antiguedad}" + Environment.NewLine;
            //output += $"Mascota: {this.Mascota.Nombre} ({this.Mascota.Edad} años)" + Environment.NewLine;
            output += $"Mascotas del cliente:"+ Environment.NewLine;
            foreach (Mascota mascota in Mascotas)
            {
                output += $"Mascota: {mascota.Nombre} ({mascota.Edad} años)" + Environment.NewLine;
            }
            return output;
        }

        public int ObtenerEdadMascota()
        {
            return Mascota.Edad;
        }
    }
}