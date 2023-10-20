using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

public class PersonasContext: DbContext {

    public DbSet<Persona> Personas {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => optionsBuilder
            .UseSqlServer("Server=localhost;Database=Personas;User Id=sa;Password=sa2k19..;TrustServerCertificate=true")
            .LogTo(Console.WriteLine,LogLevel.Information);
}