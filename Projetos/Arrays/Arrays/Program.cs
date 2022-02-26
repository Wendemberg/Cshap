using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
         /* int[] numeros = new int[3];
            numeros[0] = 10;
            numeros[1] = 11;
            numeros[2] = 12;
            numeros[3] = 13;
            Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[1]);
            Console.WriteLine(numeros[3]); */

         /* int[] pares = new int[3] { 2, 4, 6 };
            Console.WriteLine(pares[0]);
            Console.WriteLine(pares[1]);
            Console.WriteLine(pares[2]);*/

         /* int[] impares = new int[] {1, 3, 5, 7 };
            Console.WriteLine(impares[0]);
            Console.WriteLine(impares[1]);
            Console.WriteLine(impares[2]);
            Console.WriteLine(impares[3]);*/

         /* string[] nomes = new[] {"Wendemberg", "Esther", "Thalyta", "Pedro", "Everaldo" };
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);
            Console.WriteLine(nomes[3]);*/

         /* string[] paises = { "França", "Brasil", "Russia" };
            Console.WriteLine(paises[0]);
            Console.WriteLine(paises[1]);
            Console.WriteLine(paises[2]); */

            var cidades = new[] { "São Paulo", "Fortalez", "Rio de Janeiro" };
            Console.WriteLine(cidades[0]);
            Console.WriteLine(cidades[1]);
            Console.WriteLine(cidades[2]); //Inferencia de tipo

        }

    }
}