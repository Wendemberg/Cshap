using System;

namespace TrabalhandoClasses
{
    class Aluno
    {
        public string Nome;
        public int Idade;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var aluno1 = new Aluno();
            aluno1.Nome = "Wendemberg";
            aluno1.Idade = 28;

            Console.WriteLine(aluno1.Nome);
            Console.WriteLine(aluno1.Idade);    
        }
    }
}