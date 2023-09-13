## Clase 5:  Herencia. Sobrecarga. Sobreescritura.

### Contenido

* Herencia
* Sobrescritura
* Sobrecarga
* Operador is y operador as
* Downcast


### Ejercicios

* Crear una clase Persona con atributos para guardar documento, nombre, apellido y edad. Ingresar por teclado los datos de una serie de personas, al finalizar informar todos los datos de la persona de mayor edad. Si hay más de una con la misma mayor edad, informar la que aparezca al último en orden alfabético por apellido y nombre.

### Tarea

* Modificar el ejercicio de las personas para leerlas desde el archivo [personas.csv](./Personas/personas.csv).
* Un ascensor posee una capacidad máxima de n personas y está
    instalado en un edificio cuyos pisos se encuentran numerados. Se
    necesita desarrollar una clase Ascensor que represente el
    funcionamiento del mismo y que posea métodos para:

    -   Desplazarse a un piso determinado
    -   Subir personas
    -   Bajar personas
    -   Informar el piso donde se encuentra y la cantidad de personas
        que hay adentro

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

* Un partido de fútbol se juega entre dos equipos denominados local y visitante. Desarrollar una clase Partido
que contenga referencias a dos objetos de la clase Equipo. La clase Partido debe poseer atributos para registrar
ademas la cantidad de goles realizada por cada equipo y métodos para informar cuál es el ganador o si hubo empate. 
Por otro lado, la clase Equipo debe poseer un método RegistrarPartido que reciba por parámetro un partido y asigne 
atributos (almacenados o calculados) para informar:
   * Cantidad de partidos jugados
   * Cantidad de partidos jugados como local
   * Cantidad de partidos jugados como visitante
   * Suma de goles realizados
   * Suma de goles recibidos
   * Diferencia total de goles
   * Cantidad de partidos ganados
   * Cantidad de partidos empatados
   * Cantidad de partidos recibidos
   * Sumatoria de puntos (suponiendo que todos los partidos son de un mismo campeonato)


