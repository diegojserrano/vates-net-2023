using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace VeterinariaEF
{
    public class VeterinariaContext : DbContext
    {
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public string DbPath { get; private set; }
        private string CONN = "Server=SOL-DESKTOP\\SQLEXPRESS;Database=VeterinariaDB; User Id=SOL-DESKTOP\\Sol; Trusted_Connection=true;Encrypt=False;";

        public VeterinariaContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "veterinaria.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(CONN);
    }
}
