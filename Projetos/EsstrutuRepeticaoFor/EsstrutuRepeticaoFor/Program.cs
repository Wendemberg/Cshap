using System;

namespace EstruturaRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeros = new[] { 1, 2, 3, 4 };
          //for(var indice = 0; indice < 5; indice++)
            for(var indice = 0; indice < numeros.Length; indice++)
            {
                Console.WriteLine(numeros[indice]);
            }
        }
    }
}