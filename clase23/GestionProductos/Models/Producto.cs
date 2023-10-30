using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProductos.Models
{
    [Table("Productos")]
    public class Producto
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public decimal Precio {get;set;}

        public int IdCategoria { get; set; }
        
    }
}