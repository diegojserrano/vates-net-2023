using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionProductos.Models;
using GestionProductos.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace GestionProductos.Controllers
{
    [ApiController]
    [Route("/productos")]
    public class ProductosController : ControllerBase
    {
        private readonly ProductosService productosService;


        public ProductosController(ProductosService service)
        {
            productosService = service;
        }

        [HttpGet]
        public IActionResult GetProductos()
        {
            List<Producto> productos = productosService.GetProductos();
            return Ok(productos);
        }


        [HttpGet("{id}")]
        public IActionResult GetProducto(int id)
        {
            Producto? encontrado = productosService.GetProducto(id);
            if (encontrado != null)
                return Ok(encontrado);
            return NotFound();
        }


        [HttpPut("{id}")]
        public IActionResult ModificarProducto(int id, Producto p)
        {
            Producto? encontrado = productosService.GetProducto(id);
            if (encontrado != null) {
                p.Id = id;
                Producto modificado = productosService.ModificarProducto(p);
                return Ok(modificado);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult CrearProducto(Producto producto)
        {
            if (producto.Nombre.IsNullOrEmpty() || producto.Precio == 0) 
                return BadRequest("Faltan datos");
            Producto productoCreado = productosService.CrearProducto(producto);
            int idProducto = productoCreado.Id;
            return CreatedAtAction(nameof(GetProductos),idProducto, producto);
        }
    }
}