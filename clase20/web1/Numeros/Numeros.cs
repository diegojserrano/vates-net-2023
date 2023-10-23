using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/numeros")]
public class NumerosController: ControllerBase {

    [HttpGet("aleatorio")]
    public int aleatorio() {
        return new Random().Next(2000);
    }


    
}