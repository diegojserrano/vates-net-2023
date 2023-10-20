using System.ComponentModel.DataAnnotations;

public class Persona {

    [Key]
    public int Documento { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }

    public string NombreCompleto => $"{Apellido}, {Nombre}";


    public override string ToString() => $"{Documento} {Nombre} {Apellido} {Edad}";
}