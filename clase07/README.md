## Clase 7: Interfaces

### Contenido

* Interfaces
* Polimorfismo con interfaces
* Implementación
* Interfaz IComparable
* Interfaz IComparer


### Ejercicios

#### Empleados

Al plantel de empleados agregarle una interfaz Imprimible y un método imprimir en la clase Obrero. Agregar un listado que llame al método imprimir.
Al Plantel de empleados agregarle listados ordenados por diversos criterios con IComparable y IComparer.

### Tarea

El archivo personas.csv contiene un padrón de personas a razón de una persona por línea y en cada una separadas con comas el documento, nombre, apellido y edad.
Desarrollar un programa que cargue todas las personas en una List<> y luego ofrezca un menú con las siguientes opciones:

* Listar todas las personas cuyo apellido coincida con uno ingresado por el usuario
* Listar todas las personas cuya edad se encuentre en un rango ingresado por el usuario
* Listar todas las personas cuyo documento finalice en una secuencia ingresada por el usuario como un número de uno o más dígitos

Por cada uno de esos listados el usuario puede elegir el criterio y dirección del orden en que se debe presentar el mismo. El usuario podrá elegir entre ordenamiento por documento, apellido + nombre y edad, en dirección creciente o decreciente.

