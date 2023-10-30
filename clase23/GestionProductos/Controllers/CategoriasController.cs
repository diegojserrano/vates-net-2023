
using GestionProductos.Models;
using GestionProductos.Services;
using Microsoft.AspNetCore.Mvc;

namespace GestionProductos.Controllers;

[ApiController]
[Route("/categorias")]
public class CategoriasController : ControllerBase {

    private readonly CategoriasService catService;
    private readonly ProductosService prodService;
    public CategoriasController(CategoriasService serv, ProductosService serv2)
    {
        catService = serv;
        prodService = serv2;
    }

    [HttpGet]
    public ActionResult<List<Categoria>> obtenerTodas() {
        return Ok(catService.obtenerTodas());
    }


    [HttpGet("{id}")]
    public ActionResult<Categoria> obtenerUna(int id) {
        Categoria? encontrada = catService.obtenerUna(id);
        if (encontrada != null)
            return Ok(encontrada);
        return NotFound($"No se encontro la categoria {id}");
    }

    [HttpGet("{id}/productos")]
    public ActionResult<List<Producto>> obtenerProductos(int id) {
        Categoria? encontrada = catService.obtenerUna(id);
        if (encontrada != null)
            return prodService.GetProductosCategoria(encontrada.Id);// buscar los productos de esa categoria
        return NotFound($"No se encontro la categoria {id}");

    }
}