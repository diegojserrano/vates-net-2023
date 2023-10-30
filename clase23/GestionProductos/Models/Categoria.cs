using System.ComponentModel.DataAnnotations.Schema;

namespace GestionProductos.Models;

[Table("Categorias")]
public class Categoria {
    public int Id { get; set; }
    public string Nombre { get; set; }
    
}