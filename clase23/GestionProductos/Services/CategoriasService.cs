
using GestionProductos.Models;
using Microsoft.EntityFrameworkCore.Storage;

namespace GestionProductos.Services;
public class CategoriasService {

    private ProductosContext bd = new ProductosContext();
    public List<Categoria> obtenerTodas() {
        return bd.categorias.ToList();
    }


    public Categoria? obtenerUna(int id) {
        return bd.categorias.Find(id);
    }

}