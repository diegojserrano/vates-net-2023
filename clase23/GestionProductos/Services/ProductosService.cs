using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionProductos.Models;

namespace GestionProductos.Services
{
    public class ProductosService
    {
        //private static readonly List<Producto> productos = new();
        // private readonly ProductosContext context;

        public List<Producto> GetProductos()
        {
            return new ProductosContext().productos.ToList();
        }

        public Producto? GetProducto(int id)
        {
            return new ProductosContext().productos.Find(id);
        }
        public Producto CrearProducto(Producto producto)
        {
            ProductosContext pc = new ProductosContext();
            pc.productos.Add(producto);
            pc.SaveChanges();
            return producto;
        }
        public Producto? ModificarProducto(Producto producto)
        {
            ProductosContext pc = new ProductosContext();
            Producto? existente = pc.productos.Find(producto.Id);
            if (existente != null) {
                pc.productos.Entry(existente).CurrentValues.SetValues(producto);
                pc.SaveChanges();
                return existente;
            }
            return null;
        }

        public List<Producto> GetProductosCategoria(int idCategoria)
        {
            return new ProductosContext()
                        .productos
                        .Where(p => p.IdCategoria == idCategoria)
                        .ToList();
        }




    }
}