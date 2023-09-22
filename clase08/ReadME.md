## Clase 8: Composición.
* Composición
* Composición con instancias simples
* Composición con colecciones
### Ejercicios
#### Veterinaria 
Una Veterinaria encargada del cuidado de mascotas ha solicitado la
realización de un software para obtener resultados sobre sus clientes y sus
respectivas mascotas. (Suponer que cada cliente posee una sola mascota)

Se sabe que cada Cliente de esta veterinaria tiene: un numero de cliente, un
nombre, una antigüedad (hace cuántos años que son clientes de la veterinaria) y una
Mascota.

De la Mascota se dispone los siguientes datos: el nombre y la edad.

El software requiere cargar por teclado los datos de varios clientes y almacenarlos en alguna colección adecuada.

Se pide:

* Mostrar la cantidad de clientes.
* Mostrar el promedio de edad de las mascotas.
* Informar cuántos clientes tienen una antigüedad mayor igual a 5 años.
* Listado de los datos de todos los clientes cuya mascota tiene más de 5 años de edad.


#### Quini 6
Desarrollar un simulador de jugadas del Quini 6.

Cada jugada consiste en un conjunto de 6 números diferentes
elegidos en el rango 1 a 46 inclusive.

Hacer un programa que permita registrar todas las apuestas
(generadas al azar).

El diseño de las clases debe:
* rechazar las apuestas con números repetidos.
* almacenar los números de cada apuesta en una estructura de datos adecuada.
* almacenar todas las apuestas en alguna estructura de datos adecuada.
  

### Tarea 
#### Biblioteca
Una biblioteca necesita un software que le permita registrar los datos de los libros que posee y de sus préstamos. De cada libro conoce su código, título, precio de reposición (para el caso de extravíos o daños) y estado (1: disponible, 2: prestado, 3: extraviado).

Por otro lado, cada vez que un libro es prestado se registra el nombre del solicitante, la cantidad de días del préstamo y si fue devuelto o no. El conjunto de préstamos debe ser almacenado como un atributo del libro en cuestión.
	
Se necesita entonces un programa en Java que obtenga de dos archivos de texto los datos de los libros y sus préstamos y luego de finalizada la carga informe:
* Cantidad de libros en cada estado (tres totales)
* Sumatoria del precio de reposición de todos los libros extraviados
* Nombre de todos los solicitantes de un libro en particular identificado por su título
* Promedio de veces que fueron prestados los libros de la biblioteca. Es decir, se debe responder a la consulta de cuántas veces es prestado en promedio cada libro (es un promedio simple entre cantidad de prestamos y cantidad de libros)
