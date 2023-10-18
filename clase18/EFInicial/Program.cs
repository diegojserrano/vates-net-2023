using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace VeterinariaEF
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new VeterinariaContext();
            Console.WriteLine("Listado de Veterinarios");
            List<Veterinario> veterinarios = db.Veterinarios.ToList();
            foreach (Veterinario vet in veterinarios)
            {
                Console.WriteLine(vet.Nombre);
            }

            List<Mascota> mascotas = db.Mascotas.Include(m=>m.Veterinario).ToList();
            foreach (Mascota mas in mascotas)
            {
                Console.WriteLine($"Mascota: {mas.Nombre}, Veterinario: {mas.Veterinario.Nombre}");
            }
            // Create
            Console.WriteLine("Insertando un nuevo veterinario: ");
            db.Add(new Veterinario {Nombre = "Dr. Daniel Giacinto"});
            db.SaveChanges();
            // Read
            Console.WriteLine("Buscando a un veterinario");
            Veterinario veterinario = db.Veterinarios
                        .OrderBy(v=>v.VeterinarioId)
                        .First();
            Console.WriteLine($"Veterinario encontrado:{veterinario.Nombre}");
            // Update
            veterinario.Nombre = "Dra. Sol Vega";
            veterinario.Mascotas.Add(new Mascota {Nombre = "Lila", Especie = "Caniche", Edad = 7});
            db.SaveChanges();
            // Delete
            Console.WriteLine("Borrando al Veterinario");
            db.Remove(veterinario);
            db.SaveChanges();
        }
    }
}