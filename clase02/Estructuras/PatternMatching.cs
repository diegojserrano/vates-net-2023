using System;
using System.Collections;
namespace estructuras
{
    public class PatternMatching
    {
        // Type Matching
        public static void MostrarLongitud(object obj)
        {
            if (obj is string str) 
            {
                Console.WriteLine($"El string tiene {str.Length} caracteres");
            }
            else if (obj is ICollection collection) 
            {
                Console.WriteLine($"La colección tiene {collection.Count} items");
            }
        }
    }
}