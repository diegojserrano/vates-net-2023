## Clase 5:  Herencia. Sobrecarga. Sobreescritura.

### Contenido

* Herencia
* Sobrescritura
* Sobrecarga
* Operador is y operador as
* Downcast


### Ejercicios

Un hospital de nuestra ciudad necesita conocer cierta información respecto a los importes cobrados por las distintas atenciones que realiza,y requiere de un sistema orientado a objetos que le dé soporte a ello. Los datos relevantes son los siguientes:
* Del Hospital sólo interesa registrar la razón social; y una colección con todas las atenciones realizadas.
* Cada atención tiene los siguientes datos: un código numérico que identifica a cada atención; y un valor numérico que representa el tipode cobro (1: “efectivo”; 2: “tarjeta de crédito”). Las atenciones pueden ser médicas o de farmacia:
    * Una atención médica agrega los siguientes datos: el paciente atendido; y el importe de la consulta.
    * Una atención de farmacia agregan los siguientes datos: el importe total de los medicamentos vendidos en dicha atención; y un cupón de descuento que especifica el monto de descuento que se aplicaría sobre el importe total de los medicamentos; en caso que el cupón de descuento sea igual que 0, no se realizará ningún descuento; cabe aclarar que el cupón de descuento debe ser 0 o positivo.
    * Del paciente asociado a la atención médica se registran: su nombre; el síntoma que prevalece (1: “corazon”, 2: “pulmon”, 3: “otras”); y un valor booleano que representa si el paciente es habitual (true) o no (false) del hospital.
De cada clase de atención se debe calcular un importeACobrar en pesos, que representa lo que el hospital cobra al paciente por la atención brindada. Este cálculo dependerá del tipo de cobro de la atención y de la clase de atención brindada:
* El importe total de las atenciones médicas se calcula a partir del importe de la consulta. En caso que el paciente sea “habitual” se leaplicará un descuento del 25%. Por último, si el tipo de cobro es igual a 2 (“tarjeta de crédito”) se le incrementa al anterior importe un20% más; en caso que el cobro sea igual a 1 (“efectivo”) se le realiza un descuento del 10% sobre el anterior importe.
* El importe total de las atenciones de farmacia se calcula a partir del importe total de los medicamentos vendidos. Luego se le realiza el descuento del cupón de descuento cuyo importe está especificado. Por último, si el tipo de cobro es igual a 2 (“tarjeta de crédito”) se leincrementa al anterior importe un 30% más; en caso que el cobro sea igual a 1 (“efectivo”) se le realiza un descuento del 5% sobre elanterior importe.
Con lo expuesto anteriormente, usted deberá implementar:
* Todas las clases del modelo presentado.
* Los siguientes requerimientos de métodos:
    * Para las clases Atención, Médica, Farmacia y Paciente implementar su constructor, acceso y modificación y toString.
    * Para la clase Hospital implementar el método addAtención que agrega una atención a la colección.
* Definir e implementar los métodos importeACobrar de las atenciones, que calcule y devuelva el importe a cobrar por la atención de acuerdo a los criterios anteriormente especificados.
* En clase Hospital se requiere la implementación de los siguientes métodos:
    * importeACobrarPromedioAtencionesMedicas - debe calcular y retornar el importe a cobrar promedio de todas las atenciones médicas realizadas.
    * cantidadAtencionesConImporteACobrar(desde, hasta) - debe determinar y retornar la cantidad de atenciones médicas cuyo importe a cobrar esté comprendido entre dos valores que se reciben como parámetros.
    * nombrePrimerPacienteDeOtroSintomaAtendido - debe retornar el nombre del primer paciente que corresponda a otros síntomas(es decir, cuyo código de síntoma sea igual a 3). En caso que no se haya realizado ninguna atención médica a ningún paciente de otros síntomas, se deberá informar con un mensaje.
### Tarea
#### Cuentas bancarias
En un banco hay dos tipos de cuentas: cajas de ahorro y cuentas corrientes. Programar una clase Cuenta y dos derivadas correspondientes a cada uno de los tipos de cuenta.
La clase Cuenta debe poseer dos métodos para operar con las mismas llamados Depositar y Extraer.
Las cajas de ahorro no permiten extracciones si el saldo no es suficiente, mientras que las cuentas corrientes poseen un atributo “acuerdo” que indica el máximo saldo negativo admisible.
La clase cuenta debe poseer al menos los atributos número, nombre y saldo.
Con las clases de las cuentas bancarias realizar un programa que permita ingresar un conjunto de cuentas bancarias en un arreglo. Luego de la carga el programa debe permitir ingresar operaciones de depósitos y extracciones en las cuentas. Al finalizar la carga de las operaciones el programa debe mostrar el listado de las cuentas con sus saldos definitivos.
#### Empleados
Diseñar y programar las clases necesarias para manipular la información de los datos de los empleados de una empresa.
De cada empleado se conoce su legajo, nombre y sueldo básico. Sin embargo la empresa posee tres tipos de empleados:
* Obrero: cobra un monto fijo por cada día trabajado igual al sueldo básico dividido en 22.
* Administrativo: cobra un monto fijo por mes más un 13 % si cumplió con el presentismo.
* Vendedor: cobra un monto fijo por mes más una comisión de 1 % del total de sus ventas.

En un programa crear un objeto de cada uno de los tipos de empleados, les asigne a todos el mismo sueldo básico y muestre el sueldo neto que le corresponda a cada uno.
