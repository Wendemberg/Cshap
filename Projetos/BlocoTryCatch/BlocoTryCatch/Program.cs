using System;

namespace BlocoTryCath
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var nomes = new[] { "Wedemberg", "Esther", "Thalyta", "Breno" };
                for (var indice = 0; indice <= nomes.Length; indice++)
                {
                    Console.WriteLine(nomes[indice]);
                }
            }
            catch (Exception excecao)
            {
                Console.WriteLine("Ocorreu um erro. " + excecao.Message);
                Console.WriteLine("Ocorreu um erro. " + excecao.StackTrace);

            }
        }
    }
}