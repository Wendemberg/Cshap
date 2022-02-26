using System;

namespace ConvesoesTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "Wendemberg";
            Console.WriteLine(nome.IndexOf('e'));
            Console.WriteLine(nome.LastIndexOf('e'));
        }
    }
}