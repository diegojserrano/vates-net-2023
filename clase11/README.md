## Clase 11: Colecciones - Ejercitación

* Colecciones
* Colecciones de valores
* Clases List<>, HashSet<> y SortedSet<>

### Ejercicios

#### Lectura de códigos postales
El archivo cp.csv contiene el listado de los códigos postales de tres provincias argentinas. En cada línea se encuentran, separados por un símbolo de punto y coma (;) los siguientes datos: 
* Provincia, representada por una letra mayúscula según el estándar ISO correspondiente.
* Código, es un número entero de cuatro dígitos que identifica una localidad o varias localidades vecinas. Puede estar repetido.
* Nombre, es el nombre de la localidad correspondiente a ese código.

Se requiere: 
* Leer todo el contenido del archivo y guardarlo en una lista que contenga un elemento por cada línea. En cada elemento debe almacenarse alguna estructura de datos que permita acceder individualmente a cada dato que conforma un codigo postal. 
* Luego de la carga el programa debe permitir el ingreso de uno o más códigos numéricos y listar provincia y nombre de todas las localidades
asignadas a dichos códigos

### Tarea 
#### Veterinaria 2.0
Una veterinaria de nuestra ciudad necesita conocer cierta información respecto a los importes cobrados por las distintas atenciones que realiza, y requiere de un sistema que le dé soporte a ello.
Se detallan las clases identificadas para el dominio bajo estudio.
* Mascota: posee su nombre; la especie a la que pertenece (1: “perro”, 2: “gato”, 3: “otras”), un valor booleano que representa si la mascota es habitual (true) o no (false) de la veterinaria y su código de Mascota. Debe ser único para cada mascota.
* Veterinaria: posee la razón social; y una colección con todas las atenciones realizadas. Las atenciones no deben repetirse.
* Atención: posee un código numérico que identifica a cada atención; y un valor numérico que representa el tipo de cobro (1: “efectivo”; 2:“tarjeta de crédito”). Las atenciones a las mascotas pueden ser del tipo que se describen a continuación.
    * Médica: posee la mascota atendida; y el importe de la consulta.
    * Tienda: posee el importe total de los artículos vendidos en dicha atención; y un vale que especifica el monto de descuento que se aplicaría sobre el importe total de los artículos; en caso que el vale sea igual que 0, no se realizará ningún descuento; cabe aclarar que el vale debe ser 0 o positivo.

Se pide:
* Leer el archivo csv AtencionesTienda.csv y AtencionesMedica.csv provisto y cargar todas las atenciones que hay en él.
* Implementar las clases anteriormente descritas, con un método agregarAtención para la clase Veterinaria.
* Definir e implementar los métodos importeACobrar de las atenciones, que retornen el importe a cobrar por la atención según los siguientes criterios:
    * Para las atenciones médicas el importe total se calcula a partir del importe de la consulta. En caso que la mascota sea “habitual” se le aplicará un descuento del 25%. Por último, si el tipo de cobro es igual a 2 (“tarjeta de crédito”) se le incrementa al anterior importe un 20% más; en caso que el cobro sea igual a 1 (“efectivo”) se le realiza un descuento del 10% sobre el anterior importe.
    * Para las atenciones de la tienda el importe total se calcula a partir del importe total de los artículos vendidos. Luego se le realiza el descuento del bono de descuento cuyo importe está especificado. Por último, si el tipo de cobro es igual a 2 (“tarjeta de crédito”) se le incrementa al anterior importe un 30% más; en caso que el cobro sea igual a 1 (“efectivo”) se le realiza un descuento del 5% sobre el anterior importe.
* En la clase Veterinaria los siguientes métodos:
    * importeTotalGatos: debe retornar la sumatoria de los importes total de los artículos de todas las atenciones médicas que se realizaron a las mascotas de la especie Gato.
    * cantidadAtencionesHasta: debe retornar la cantidad de atenciones cuyo importe a cobrar sea mayor a $1000 y menor a un valor que se reciba como parámetro.
    * primerAtencionMedicaGato: debe retornar la primera atención de la primera mascota de la especie Gato que haya recibido atención médica. En caso de no encontrarse ninguna atención médica a ningún gato, retornar nulo.
