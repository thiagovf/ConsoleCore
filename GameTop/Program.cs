using System;
using GameTop.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogador = new JogoFoda(new Jogador("Ronaldo"), new Jogador("Maradona"));
            jogador.IniciarJogo();
        }
    }

 
}
