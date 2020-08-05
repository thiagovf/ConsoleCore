using System;
using GameTop.Iterface;

namespace GameTop.Lib
{
    public class Jogador : iJogador
    {
        public readonly string _Nome;

        public Jogador(string Nome)
        {
            _Nome = Nome;
        }

    public string Chuta()
    {
        return $"{_Nome} está chutando.";
    }

    public string Corre()
    {
        return $"{_Nome} está correndo.";
    }

    public string Passe() 
    {
        return $"{_Nome} está passando.";
    }
    }
}