using System;
using Personagens;

namespace DefinindoHerancaEntreClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var cavaleiro = new Cavaleiro("Aragon", 100);
            var arqueiro = new Arqueiro("Legolas", 100);
            var mago = new Mago("Gandalf", 100, 100);

            cavaleiro.Atacar();
            cavaleiro.Atacarespecial();
            cavaleiro.Defender();

            arqueiro.Atacar();
            arqueiro.Atacarespecial();
            arqueiro.Defender();

            mago.Atacar();
            mago.Atacarespecial();
            mago.Defender(); 
            
           

        }
    }
}