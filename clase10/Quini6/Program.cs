

Boleta b1 = new Boleta();
b1.AgregarNumero(4);
b1.AgregarNumero(14);
b1.AgregarNumero(25);
b1.AgregarNumero(5);
b1.AgregarNumero(8);
b1.AgregarNumero(12);

System.Console.WriteLine(b1);

SortedSet<int> sorteados = new();
Random r = new Random();
while(sorteados.Count < 5)
    sorteados.Add(r.Next(43));

do
{
    while(!sorteados.Add(r.Next(43))); // Agrega un número nuevo
    System.Console.Write($"Salieron los siguientes números ({sorteados.Count}): ");
    foreach(int x in sorteados)
        System.Console.Write(x + " ");
    System.Console.WriteLine();

    System.Console.WriteLine(b1.EsValida);
    System.Console.WriteLine(b1.EsGanadora(sorteados));
} while(!b1.EsGanadora(sorteados));