﻿namespace OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome);
        }
    }
}