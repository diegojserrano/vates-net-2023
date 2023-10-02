
using System.Security.Cryptography.X509Certificates;

List<int> numeros = new();
Random r = new Random();

for (int i = 0; i < 100; i++)
{
    numeros.Add(r.Next(-1000, 1000));
}

//foreach (int  x in numeros)
//{
//    System.Console.WriteLine(x);
//}


// Informar la cantidad de positivos y de negativos
int cp = 0, cn = 0;
foreach(int x in numeros) {
    if (x > 0) cp++;
    else if (x < 0) cn++;
}

int c0 = 100 - cn - cp;
System.Console.WriteLine("Con conteo secuencial:");
System.Console.WriteLine($"Cantidad de positivos: {cp}");
System.Console.WriteLine($"Cantidad de negativos: {cn}");
System.Console.WriteLine($"Cantidad de 0: {c0}");

// En matematica pondriamos f(x) = x > 0
// La variable esPositivo guarda código fuente
// Podemos decir que es una variable de "tipo funcion"
var esPositivo = (int x) => x > 0;
var esNegativo = (int x) => x < 0;
//var esNegativo = (int x) => x != 0 && !esPositivo(x);

System.Console.WriteLine("Con LINQ");
cp = numeros.Count(esPositivo);
cn = numeros.Count(esNegativo);
c0 = 100 - cn - cp;

System.Console.WriteLine($"Cantidad de positivos: {cp}");
System.Console.WriteLine($"Cantidad de negativos: {cn}");
System.Console.WriteLine($"Cantidad de 0: {c0}");

// Listar sólo los positivos
IEnumerable<int> cuadrados = numeros.Where(esPositivo).Select(x => x * x).Order();
System.Console.WriteLine("Listado de los cuadrados de los positivos");
foreach(int x in cuadrados) {
    System.Console.WriteLine(x);
}

bool hayCeros = numeros.Any(x => x == 0);
/* Any, All, None reciben predicados */

/* Max / Min / Average */


System.Console.WriteLine("Listado de los positivos:");
var positivos = from n in numeros where esPositivo(n) select n;
foreach(int x in positivos) {
    System.Console.WriteLine(x);
}

System.Console.WriteLine("Listado de los positivos:");
cuadrados = from n 
            in numeros 
            where esPositivo(n) 
            let cuadrado = n * n
            orderby cuadrado
            select cuadrado;

foreach(int x in cuadrados) {
    System.Console.WriteLine(x);
}

/*

from in
where
orderby
select

let: declara una variable temporal
into: guarda el resultado en un IEnumerable temporal
join: hace join entre dos IEnumerables
group by: similar al group by de SQL

*/



