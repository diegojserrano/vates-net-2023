using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionProductos.Models;

namespace GestionProductos.Services
{
    public class ProductosService
    {
        private static readonly List<Producto> productos = new();
        // private readonly ProductosContext context;

        public List<Producto> GetProductos()
        {
            return productos;
        }
        public Producto CrearProducto(Producto producto)
        {
            producto.Id = productos.Count + 1;
            productos.Add(producto);
            return producto;
        }

    }
}