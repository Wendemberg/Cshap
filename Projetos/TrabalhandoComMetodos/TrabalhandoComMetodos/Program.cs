using System;

namespace TrabalhandoComMetodos
{
    class ContaCorrente
    {
        public string Numero;
        public decimal Saldo;

        public void ImprimirInformacoes()
        {
            Console.WriteLine($"Número: {Numero} | Saldo: {Saldo}");
        }

        public string ListarInformacoes()
        {
            return $"Número: {Numero} | Saldo: {Saldo}";
        }
        
        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var conta1 = new ContaCorrente();
            conta1.Numero = "001-002";
            conta1.Saldo = 0;
            //conta1.ImprimirInformacoes();
            var infomacoes = conta1.ListarInformacoes();
            Console.WriteLine(infomacoes);
            conta1.Depositar(100);
            Console.WriteLine(conta1.ListarInformacoes());

            
        }
    }
}