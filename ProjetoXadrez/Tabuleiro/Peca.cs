using System;

namespace tabuleiro
{
    internal abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdaMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QtdaMovimentos = 0;
        }

        public void incrementarQtdaMovimentos()
        {
            QtdaMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
