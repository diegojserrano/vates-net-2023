/*


Un ascensor posee una capacidad máxima de n personas y está
instalado en un edificio cuyos pisos se encuentran numerados. Se
necesita desarrollar una clase Ascensor que represente el
funcionamiento del mismo y que posea métodos para:

*   Desplazarse a un piso determinado
*   Subir personas
*   Bajar personas
*   Informar el piso donde se encuentra y la cantidad de personas que hay adentro

Los métodos deben verificar que el estado siempre sea correcto:

-   Si se solicitar ir a un piso debe retornar verdadero si el piso
    existe y falso si no. Por ejemplo, si el ascensor puede viajar
    entre los pisos -2 y 10, debe retornar falso si le solicitan ir
    a un piso fuera de ese rango.
-   Si la cantidad de personas que quieren subir supera la
    capacidad, debe retornar la cantidad de personas que
    efectivamente entren.
-   Si la cantidad de personas que quieren bajar supera a la
    cantidad de personas que efectivamente hay adentro del ascensor,
    debe retornar esa última cantidad, es decir, que todos salen.
-   Si para subir o bajar el método recibe una cantidad no válida,
    debe retornar -1.
-   El método toString debe informar el piso en que se encuentra y
    la cantidad de personas que hay adentro en ese momento.

*/

public class Ascensor {

    public int Piso { get; private set; }
    public int PisoMinimo { get; }
    public int PisoMaximo { get; }

    public int Personas { get; private set; }
    public int Capacidad { get; }

    public int Disponible => Capacidad - Personas;

    public bool IrAPiso(int piso) {
        if (piso >= PisoMinimo && piso <= PisoMaximo) {
            Piso = piso;
            return true;
        }
        return false;
    }

    public int Subir(int cantidad) {
        int suben = cantidad switch
        {   
             <= 0 => -1,
             > 0 when cantidad <= Disponible => cantidad,
            _ => Disponible
        };
        if (suben > 0) Personas += suben;
        return suben;
    }
    public int Bajar(int cantidad) {
        return cantidad switch
        {   
             <= 0 => -1,
             > 0 when cantidad <= Personas => Personas,
            _ => cantidad
        };
    }

    public override string ToString() => $"Piso: {Piso} - Personas: {Personas}";
    
    public Ascensor(int pisoMinimo, int pisoMaximo, int capacidad) {
        PisoMinimo = pisoMinimo;
        PisoMaximo = pisoMaximo;
        Capacidad = capacidad;
    }
}