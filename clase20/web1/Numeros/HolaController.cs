
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/hola")]
public class HolaController: ControllerBase {

    [HttpGet]
    public string saludo1() {
        return "Hola mundo";
    }

    [HttpGet("{nombre}/{apellido}")]
    public string saludo2(string nombre, string apellido) {
        return "Hola " + nombre + " " + apellido;
    }

}