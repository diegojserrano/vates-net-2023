using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionProductos.Models;
using GestionProductos.Services;
using Microsoft.AspNetCore.Mvc;

namespace GestionProductos.Controllers
{
    [ApiController]
    [Route("clase21/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly ProductosService productosService;

        public ProductosController(ProductosService service)
        {
            productosService = service;
        }

        [HttpGet("{id}")]
        public IActionResult GetProductos()
        {
            List<Producto> productos = productosService.GetProductos();
            return Ok(productos);
        }

        [HttpPost]
        public IActionResult CrearProducto(Producto producto)
        {
            Producto productoCreado = productosService.CrearProducto(producto);
            int idProducto = productoCreado.Id;
            return CreatedAtAction(nameof(GetProductos),idProducto, producto);
        }
    }
}