using System;
using Contas;

namespace CriandoPrimeiraClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta();
            conta.Numero = "001";
            conta.DataAbertura = DateTime.Today;
            conta.Saldo = 0;

            conta.ExibirExtrato();
            
        }
    }
}
