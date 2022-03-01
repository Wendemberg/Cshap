using System;

namespace Personagens
{
    public class Cavaleiro : Personagem
    {

        public Cavaleiro(string nome, int vida) : base(nome, vida)
        {
            Id = "Cavaleiro1";
        }

        public override void Atacar()
        {
            Console.WriteLine($"{Nome} atacou com espada.");
        }
        public override void Atacarespecial()
        {
            Console.WriteLine($"{Nome} Ataque Especial com espada.");
        }

    }
}