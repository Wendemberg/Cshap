using System;
using Contas;

namespace CriandoPrimeiraClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta();
            Console.WriteLine(conta.ExibirExtrato());

            var conta2 = new Conta("0001", DateTime.Now, 500);
            Console.WriteLine(conta2.ExibirExtrato());

            


        }
    }
}
