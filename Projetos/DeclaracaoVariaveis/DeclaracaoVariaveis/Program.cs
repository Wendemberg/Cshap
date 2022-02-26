using System;

namespace DeclaracaoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            decimal altura;
            string nome;

            idade = 27;
            nome = "Joel";
            altura = 1.75M;

            var Nome = "Joel";

            string email = "bergwer99@gmail.com";

            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Seu email é: " + email);
            Console.WriteLine("Sua idade é: " + idade);
            Console.WriteLine("Sua altura é " + altura);


        }
    }
}