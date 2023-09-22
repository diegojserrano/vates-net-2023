

Par<int> par1 = new Par<int>(5,67);

Par<string> par2 = new Par<string>("Hola", "Alejandro");

HashSet

// Para convertir de Par de T a Par de object hay que hacerla covariant 
// https://www.csharptutorial.net/csharp-tutorial/csharp-covariance/

System.Console.WriteLine(par1 + "  " + par1.Ascendente);
System.Console.WriteLine(par2 + "  " + par2.Ascendente);
