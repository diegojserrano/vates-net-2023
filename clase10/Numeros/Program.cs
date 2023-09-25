using System;
using System.Diagnostics;

Random r = new Random();

List<int> lista = new();
HashSet<int> conj = new();
SortedSet<int> ord = new();

Stopwatch s = new();

Console.WriteLine("Antes de insertar");
s.Start();
for (int i = 0; i < 100; i++) {
    int n = r.Next(1000000);
    lista.Add(n);
    conj.Add(n);
    ord.Add(n);    
}
s.Stop();

Console.WriteLine("Después de insertar");
Console.WriteLine(s.ElapsedMilliseconds);
Console.WriteLine("Tamaños:");
Console.WriteLine(lista.Count);
Console.WriteLine(conj.Count);
Console.WriteLine(ord.Count);

Console.WriteLine("Buscando en la lista:");
int c = 0;
s.Restart();
for (int i = 0; i < 1000000; i++) {
    int n = r.Next(1000000);
    if (lista.Contains(n))
        c++;
}
s.Stop();
Console.WriteLine($"Encontre {c} elementos en {s.ElapsedMilliseconds/1000f} milisegundos");

Console.WriteLine("Buscando en el hash set:");
c = 0;
s.Restart();
for (int i = 0; i < 1000000; i++) {
    int n = r.Next(1000000);
    if (conj.Contains(n))
        c++;
}
s.Stop();
Console.WriteLine($"Encontre {c} elementos en {s.ElapsedMilliseconds/1000f} milisegundos");

Console.WriteLine("Buscando en el tree set:");
c = 0;
s.Restart();
for (int i = 0; i < 1000000; i++) {
    int n = r.Next(1000000);
    if (ord.Contains(n))
        c++;
}
s.Stop();
Console.WriteLine($"Encontre {c} elementos en {s.ElapsedMilliseconds/1000f} milisegundos");

foreach(int x in lista) System.Console.Write(x + " ");
System.Console.WriteLine();
foreach(int x in conj) System.Console.Write(x + " ");
System.Console.WriteLine();
foreach(int x in ord) System.Console.Write(x + " ");
System.Console.WriteLine();
