using System;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            var ativo = false;
            var a = 3;
            var b = 5;
           
            Console.WriteLine(!ativo); //o sinal de exclamação indica a negação do valor contido na variável
            Console.WriteLine(!(a > b));
            Console.WriteLine(ativo == true && a > b);
            Console.WriteLine(ativo == false && a < b);
            Console.WriteLine(ativo == true || a > b);
        }
    }
}