﻿using System;

namespace EstruturaCondicionalIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            var idade = 16;
            var nota = 6;

            if(idade >= 18)
            {
                Console.WriteLine("Maior de idade");
                Console.WriteLine("Cadastro autorizado");
            }
            else if(idade >= 16 && idade < 18)
            {
                Console.WriteLine("Menor de idade");
                Console.WriteLine("Cadastro autorizado com responsáveis");
                
            }
            else
            {
                Console.WriteLine("Menor de idade");
                Console.WriteLine("Cadastro não autorizado");

            }
            
            if (nota >= 7)
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Prossiga com o cadastro");
               
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Não foi possível continuar o cadastro, nota abaixo da média");
                
            }
        }
    }
}