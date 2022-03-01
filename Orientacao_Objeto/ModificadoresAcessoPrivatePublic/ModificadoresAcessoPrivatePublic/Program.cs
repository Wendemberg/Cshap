using System;
using RH;

namespace ModificadoresAcessoPrivatePublic
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario();
            funcionario.Nome = "Wendemberh";
            funcionario.CPF = "000.000.000-00";
        }
    }
}