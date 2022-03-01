using System;

namespace TrabalhandoComMetodos
{
    class ContaCorrente
    {
        public string Numero;
        public decimal Saldo;

        public void ImprimirInformacoes() // Metodo
        {
            Console.WriteLine($"Número:{Numero} | Saldo:{Saldo}");
        }
        
        public string ListaInformacoes() //Todo método que não é void tem que ter um tipo de retorno
        {
            return $"NUMERO: {Numero} | SALDO: {Saldo}";
        }

        public void Depositar(decimal valor) //Os paramêtros de um método são descritos no parêntesis a seguida do métod
        {
            Saldo += valor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new ContaCorrente();
            conta.Numero = "000-01";
            conta.Saldo = 0;
            //conta.ImprimirInformacoes();
            var informacoes = conta.ListaInformacoes();
            Console.WriteLine(informacoes);
            conta.Depositar(100);
            Console.WriteLine(conta.ListaInformacoes());
         
        }
    }
}