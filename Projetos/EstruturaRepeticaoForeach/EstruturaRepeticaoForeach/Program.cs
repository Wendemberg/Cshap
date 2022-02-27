using System;

namespace EstruturaRepeticaoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomes = new[] { "Wendemberg", "Jhon", "Ph", "Felps", "Renan" };
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}