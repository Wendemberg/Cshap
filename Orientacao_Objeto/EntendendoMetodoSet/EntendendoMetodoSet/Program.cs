using System;
using RH;

namespace AplicandoEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario("Wendemberg", "000.000.000-00");
            funcionario.CPF = "111.111.111-11";
            Console.WriteLine(funcionario.CPF);

        }
    }
}