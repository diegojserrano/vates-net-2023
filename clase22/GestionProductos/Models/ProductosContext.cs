using GestionProductos.Models;
using Microsoft.EntityFrameworkCore;

public class ProductosContext: DbContext {
    public DbSet<Producto> productos { get; set; }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => optionsBuilder
            .UseSqlServer("Server=localhost;Database=Productos;User Id=sa;Password=sa2k19..;TrustServerCertificate=true")
            .LogTo(Console.WriteLine,LogLevel.Information);
    
}