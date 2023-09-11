namespace Clase03 {

public class Persona {

    // Atributos
    // Propiedades
    public int Documento { get; init; }
    public string Nombre { get; set; } = "No especificado";
    public string Apellido { get; set; }
    public int Nacimiento { get; set; }

    // Metodos
    public string NombreCompleto { get { return $"{Nombre} {Apellido}"; } }

    public int Edad { get { return 2023 - Nacimiento - 5; } }

    public override string ToString() {
        return $"{Documento} {Nombre} {Apellido} {Edad}";
    }

    public Persona(int documento, string nombre, string apellido, int nacimiento)
    {
        this.Documento = documento;
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Nacimiento = nacimiento;
    }

}

/*

public record Persona(int Documento, string Nombre, string Apellido, int Nacimiento) {

    public int Edad { 
        get  => 2023 - Nacimiento;
    }

    public string NombreCompleto { get => $"{Apellido}, {Nombre}"; }   

    public override string ToString() {
        return $"{Documento}: {Nombre} {Apellido} nacio en {Nacimiento} y tiene {Edad} años";
    }
}


**/

}