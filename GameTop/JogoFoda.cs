using System;
using GameTop.Iterface;
using GameTop.Lib;

namespace GameTop
{
    public  class JogoFoda 
    {
        private readonly iJogador _JogadorA;
        private readonly iJogador _JogadorB;

        public JogoFoda(iJogador JogadorA, iJogador JogadorB)
        {
            _JogadorA = JogadorA;
            _JogadorB = JogadorB;

        }

        public void IniciarJogo()
        {
            Console.WriteLine($"{_JogadorA.Passe()}");
            Console.WriteLine($"{_JogadorA.Chuta()}");
            Console.WriteLine($"{_JogadorA.Corre()}");

            Console.WriteLine($"{_JogadorB.Chuta()}");
            Console.WriteLine($"{_JogadorB.Passe()}");
            Console.WriteLine($"{_JogadorB.Corre()}");
        }
    }
}